using System;
namespace Mono.Interop
{
	public class CFunc<T> : CActionBase
	{
		public Func<T> Callback { get; protected set; }

		Func<T> func;

		public CFunc(Func<T> callback)
		{
			Callback = OnCallback;
			func = callback;
		}

		public T OnCallback()
		{
			T ret;
			if (func != null) {
				ret = func();
			} else {
				ret = default(T);
			}
			Dispose();
			return ret;
		}
	}

	public class CFunc<T1, T> : CActionBase
	{
		public Func<T1, T> Callback { get; protected set; }

		Func<T1, T> func;

		public CFunc(Func<T1, T> callback)
		{
			Callback = OnCallback;
			func = callback;
		}

		public T OnCallback(T1 arg1)
		{
			T ret;
			if (func != null) {
				ret = func(arg1);
			} else {
				ret = default(T);
			}
			Dispose();
			return ret;
		}
	}

	public class CFunc<T1, T2, T> : CActionBase
	{
		public Func<T1, T2, T> Callback { get; protected set; }

		Func<T1, T2, T> func;

		public CFunc(Func<T1, T2, T> callback)
		{
			Callback = OnCallback;
			func = callback;
		}

		public T OnCallback(T1 arg1, T2 arg2)
		{
			T ret;
			if (func != null) {
				ret = func(arg1, arg2);
			} else {
				ret = default(T);
			}
			Dispose();
			return ret;
		}
	}

	public class CFunc<T1, T2, T3, T> : CActionBase
	{
		public Func<T1, T2, T3, T> Callback { get; protected set; }

		Func<T1, T2, T3, T> func;

		public CFunc(Func<T1, T2, T3, T> callback)
		{
			Callback = OnCallback;
			func = callback;
		}

		public T OnCallback(T1 arg1, T2 arg2, T3 arg3)
		{
			T ret;
			if (func != null) {
				ret = func(arg1, arg2, arg3);
			} else {
				ret = default(T);
			}
			Dispose();
			return ret;
		}
	}

	public class CFunc<T1, T2, T3, T4, T> : CActionBase
	{
		public Func<T1, T2, T3, T4, T> Callback { get; protected set; }

		Func<T1, T2, T3, T4, T> func;

		public CFunc(Func<T1, T2, T3, T4, T> callback)
		{
			Callback = OnCallback;
			func = callback;
		}

		public T OnCallback(T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
			T ret;
			if (func != null) {
				ret = func(arg1, arg2, arg3, arg4);
			} else {
				ret = default(T);
			}
			Dispose();
			return ret;
		}
	}

	public class CFunc<T1, T2, T3, T4, T5, T> : CActionBase
	{
		public Func<T1, T2, T3, T4, T5, T> Callback { get; protected set; }

		Func<T1, T2, T3, T4, T5, T> func;

		public CFunc(Func<T1, T2, T3, T4, T5, T> callback)
		{
			Callback = OnCallback;
			func = callback;
		}

		public T OnCallback(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
			T ret;
			if (func != null) {
				ret = func(arg1, arg2, arg3, arg4, arg5);
			} else {
				ret = default(T);
			}
			Dispose();
			return ret;
		}
	}

	public class CFunc<T1, T2, T3, T4, T5, T6, T> : CActionBase
	{
		public Func<T1, T2, T3, T4, T5, T6, T> Callback { get; protected set; }

		Func<T1, T2, T3, T4, T5, T6, T> func;

		public CFunc(Func<T1, T2, T3, T4, T5, T6, T> callback)
		{
			Callback = OnCallback;
			func = callback;
		}

		public T OnCallback(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
			T ret;
			if (func != null) {
				ret = func(arg1, arg2, arg3, arg4, arg5, arg6);
			} else {
				ret = default(T);
			}
			Dispose();
			return ret;
		}
	}

	public class CFunc<T1, T2, T3, T4, T5, T6, T7, T> : CActionBase
	{
		public Func<T1, T2, T3, T4, T5, T6, T7, T> Callback { get; protected set; }

		Func<T1, T2, T3, T4, T5, T6, T7, T> func;

		public CFunc(Func<T1, T2, T3, T4, T5, T6, T7, T> callback)
		{
			Callback = OnCallback;
			func = callback;
		}

		public T OnCallback(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
			T ret;
			if (func != null) {
				ret = func(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
			} else {
				ret = default(T);
			}
			Dispose();
			return ret;
		}
	}
}

