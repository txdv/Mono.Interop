using System;
using System.IO;
using System.Globalization;
using System.Runtime.InteropServices;
using Managed.X86;

namespace Mono.Interop
{
	public enum mprot : int {
		Read = 0x1,
		Write = 0x2,
		Exec = 0x4,
		None = 0
	}

	public class MemoryPatch
	{
		public byte[] Patched { get; protected set; }
		public byte[] Unpatched { get; protected set; }

		public Delegate Delegate { get; protected set; }
		public IntPtr DelegatePointer { get; protected set; }
		public IntPtr Target { get; protected set; }

		public MemoryPatch(IntPtr target, Delegate @delegate, byte[] patched, byte[] unpatched)
		{
			Target = target;
			Delegate = @delegate;
			DelegatePointer = Marshal.GetFunctionPointerForDelegate(@delegate);

			Patched = patched;
			Unpatched = unpatched;
		}

		public void Unpatch()
		{
		}
	}

	public class MemoryRange
	{
		public MemoryRange(IntPtr start, IntPtr end, bool read, bool write, bool exec)
		{
			Start = start;
			End = end;
			Read = read;
			Write = write;
			Exec = exec;
		}

		public IntPtr Start { get; protected set; }
		public IntPtr End { get; protected set; }
		public bool Read { get; protected set; }
		public bool Write { get; protected set; }
		public bool Exec { get; protected set; }

		public bool Fits(IntPtr pointer)
		{
			return (Start.ToInt64() >= pointer.ToInt64() &&
			        pointer.ToInt64() <= End.ToInt64());
		}

		public mprot mprot {
			get {
				mprot ret = mprot.None;
				if (Read) ret |= mprot.Read;
				if (Write) ret |= mprot.Write;
				if (Exec) ret |= mprot.Exec;
				return ret;
			}
		}
	}

	public class Memory
	{
		[DllImport("__Internal")]
		extern static int getpagesize();

		static readonly int pagesize = getpagesize();

		[DllImport("__Internal")]
		extern static int mprotect(IntPtr addr, IntPtr len, mprot prot);

		public static GCHandle Unlock(byte[] arr)
		{
			var handle = GCHandle.Alloc(arr, GCHandleType.Pinned);

			var ptr = handle.AddrOfPinnedObject();

			long start = ptr.ToInt64() % pagesize;
			long size = pagesize - start;

			var page = new IntPtr(ptr.ToInt64() - start);

			int i;
			for (i = 1; arr.Length - size > pagesize * i; i++);

			mprotect(page, (IntPtr)(pagesize * i), mprot.Read | mprot.Write | mprot.Exec);

			return handle;
		}

		public static int MemoryProtection(IntPtr ptr, long length, mprot prot)
		{
			long start = ptr.ToInt64() % pagesize;
			long size = pagesize - start;

			var page = new IntPtr(ptr.ToInt64() - start);

			int i;
			for (i = 1; length - size > pagesize * i; i++);

			if (mprotect(page, (IntPtr)(pagesize * i), prot) < 0) {
				return -1;
			}
			return i;
		}

		unsafe static public MemoryPatch Patch(IntPtr target, Action action)
		{
			int size = 8;
			var mr = GetPermissions(target);
			if (mr != null) {
				MemoryProtection(target, size, mprot.Read|mprot.Write);
				var ums = new UnmanagedMemoryStream((byte *)target, 0, size, FileAccess.ReadWrite);

				byte[] unpatched = new byte[size];
				ums.Read(unpatched, 0, size);

				ums.Seek(0, SeekOrigin.Begin);
				var writer = new X86Writer(ums, (IntPtr)size);
				writer.Mov32(X86Register32.EAX, Marshal.GetFunctionPointerForDelegate(action).ToInt32());
				writer.Jmp(X86Register32.EAX);

				ums.Seek(0, SeekOrigin.Begin);
				byte[] patched = new byte[size];
				ums.Read(patched, 0, size);

				return new MemoryPatch(target, action, patched, unpatched);
			} else {
				throw new Exception();
			}
		}

		private static MemoryRange GetPermissions(IntPtr ptr)
		{
			using (var r = new StreamReader(File.OpenRead("/proc/self/maps")))
			for (string line; (line = r.ReadLine()) != null;) {
				var lines = line.Split(new char[] { ' ' });
				var range = lines[0].Split(new char[] { '-' });

				IntPtr start = (IntPtr)long.Parse(range[0], NumberStyles.HexNumber);
				IntPtr end = (IntPtr)long.Parse(range[1], NumberStyles.HexNumber);

				var permissions = lines[1];

				var mr = new MemoryRange(start, end, permissions[0] == 'r', permissions[1] == 'w', permissions[2] == 'x');

				if (mr.Fits(ptr)) {
					return mr;
				}

			}
			return null;
		}
	}
}

