using System;
using System.Runtime.InteropServices;

namespace Mono.Interop
{
	public class CActionBase : IDisposable
	{
		GCHandle GCHandle { get; set; }

		public CActionBase()
		{
			GCHandle = GCHandle.Alloc(this);
		}
		~CActionBase()
		{
			Dispose(false);
		}

		public void Dispose()
		{
			Dispose(true);
		}

		protected void Dispose(bool disposing)
		{
			if (disposing) {
				GC.SuppressFinalize(this);
			}

			if (GCHandle.IsAllocated) {
				GCHandle.Free();
			}
		}
	}
	
	public class CAction : CActionBase
	{
		public Action Callback { get; protected set; }

		Action cb;

		public CAction(Action callback)
			: base()
		{
			cb = callback;
			Callback = PrivateCallback;
		}

		void PrivateCallback()
		{
			if (cb != null) {
				cb();
			}

			Dispose();
		}
	}
	
	public class CAction<T1> : CActionBase
	{
		public Action<T1> Callback { get; protected set; }

		Action<T1> cb;

		public CAction(Action<T1> callback)
			: base()
		{
			cb = callback;
			Callback = PrivateCallback;
		}

		void PrivateCallback(T1 arg1)
		{
			if (cb != null) {
				cb(arg1);
			}

			Dispose();
		}
	}
	
	public class CAction<T1, T2> : CActionBase	
	{
		public Action<T1, T2> Callback { get; protected set; }
		
		Action<T1, T2> cb;
		
		public CAction(Action<T1, T2> callback)
		{
			cb = callback;
			Callback = PrivateCallback;
		}
		
		void PrivateCallback(T1 arg1, T2 arg2)
		{
			if (cb != null) {
				cb(arg1, arg2);
			}

			Dispose();
		}
	}

	public class CAction<T1, T2, T3> : CActionBase
	{
		public Action<T1, T2, T3> Callback { get; protected set; }

		Action<T1, T2, T3> cb;

		public CAction(Action<T1, T2, T3> callback)
		{
			cb = callback;
		}

		void PrivateCallback(T1 arg1, T2 arg2, T3 arg3)
		{
			if (cb != null) {
				cb(arg1, arg2, arg3);
			}

			Dispose();
		}
	}

	public class CAction<T1, T2, T3, T4> : CActionBase
	{
		public Action<T1, T2, T3, T4> Callback { get; protected set; }

		Action<T1, T2, T3, T4> cb;

		public CAction(Action<T1, T2, T3, T4> callback)
		{
			cb = callback;
		}

		void PrivateCallback(T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
			if (cb != null) {
				cb(arg1, arg2, arg3, arg4);
			}

			Dispose();
		}
	}

	public class CAction<T1, T2, T3, T4, T5> : CActionBase
	{
		public Action<T1, T2, T3, T4, T5> Callback { get; protected set; }

		Action<T1, T2, T3, T4, T5> cb;

		public CAction(Action<T1, T2, T3, T4, T5> callback)
		{
			cb = callback;
		}

		void PrivateCallback(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
			if (cb != null) {
				cb(arg1, arg2, arg3, arg4, arg5);
			}

			Dispose();
		}
	}

	public class CAction<T1, T2, T3, T4, T5, T6> : CActionBase
	{
		public Action<T1, T2, T3, T4, T5, T6> Callback { get; protected set; }

		Action<T1, T2, T3, T4, T5, T6> cb;

		public CAction(Action<T1, T2, T3, T4, T5, T6> callback)
		{
			cb = callback;
		}

		void PrivateCallback(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
			if (cb != null) {
				cb(arg1, arg2, arg3, arg4, arg5, arg6);
			}

			Dispose();
		}
	}

	public class CAction<T1, T2, T3, T4, T5, T6, T7> : CActionBase
	{
		public Action<T1, T2, T3, T4, T5, T6, T7> Callback { get; protected set; }

		Action<T1, T2, T3, T4, T5, T6, T7> cb;

		public CAction(Action<T1, T2, T3, T4, T5, T6, T7> callback)
		{
			cb = callback;
		}

		void PrivateCallback(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
			if (cb != null) {
				cb(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
			}

			Dispose();
		}
	}

	public class CAction<T1, T2, T3, T4, T5, T6, T7, T8> : CActionBase
	{
		public Action<T1, T2, T3, T4, T5, T6, T7, T8> Callback { get; protected set; }

		Action<T1, T2, T3, T4, T5, T6, T7, T8> cb;

		public CAction(Action<T1, T2, T3, T4, T5, T6, T7, T8> callback)
		{
			cb = callback;
		}

		void PrivateCallback(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
			if (cb != null) {
				cb(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
			}

			Dispose();
		}
	}

	public class CAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> : CActionBase
	{
		public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> Callback { get; protected set; }

		Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> cb;

		public CAction(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> callback)
		{
			cb = callback;
		}

		void PrivateCallback(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
			if (cb != null) {
				cb(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
			}

			Dispose();
		}
	}

	public class CAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : CActionBase
	{
		public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Callback { get; protected set; }

		Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> cb;

		public CAction(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> callback)
		{
			cb = callback;
		}

		void PrivateCallback(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
			if (cb != null) {
				cb(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
			}

			Dispose();
		}
	}

	public class CAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : CActionBase
	{
		public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Callback { get; protected set; }

		Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> cb;

		public CAction(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> callback)
		{
			cb = callback;
		}

		void PrivateCallback(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
			if (cb != null) {
				cb(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
			}

			Dispose();
		}
	}

	public class CAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : CActionBase
	{
		public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Callback { get; protected set; }

		Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> cb;

		public CAction(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> callback)
		{
			cb = callback;
		}

		void PrivateCallback(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
			if (cb != null) {
				cb(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
			}

			Dispose();
		}
	}

	public class CAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : CActionBase
	{
		public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Callback { get; protected set; }

		Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> cb;

		public CAction(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> callback)
		{
			cb = callback;
		}

		void PrivateCallback(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
			if (cb != null) {
				cb(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
			}

			Dispose();
		}
	}

	public class CAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : CActionBase
	{
		public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Callback { get; protected set; }

		Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> cb;

		public CAction(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> callback)
		{
			cb = callback;
		}

		void PrivateCallback(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
			if (cb != null) {
				cb(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
			}

			Dispose();
		}
	}

	public class CAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : CActionBase
	{
		public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Callback { get; protected set; }

		Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> cb;

		public CAction(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> callback)
		{
			cb = callback;
		}

		void PrivateCallback(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
		{
			if (cb != null) {
				cb(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
			}

			Dispose();
		}
	}

	public class CAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> : CActionBase
	{
		public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Callback { get; protected set; }

		Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> cb;

		public CAction(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> callback)
		{
			cb = callback;
		}

		void PrivateCallback(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16)
		{
			if (cb != null) {
				cb(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
			}

			Dispose();
		}
	}
}

