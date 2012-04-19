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

	public class CFunc<T1, T2, T3, T4, T5, T6, T7, T8, T> : CActionBase
	{
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T> Callback { get; protected set; }

		Func<T1, T2, T3, T4, T5, T6, T7, T8, T> func;

		public CFunc(Func<T1, T2, T3, T4, T5, T6, T7, T8, T> callback)
		{
			Callback = OnCallback;
			func = callback;
		}

		public T OnCallback(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
			T ret;
			if (func != null) {
				ret = func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
			} else {
				ret = default(T);
			}
			Dispose();
			return ret;
		}
	}

	public class CFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T> : CActionBase
	{
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T> Callback { get; protected set; }

		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T> func;

		public CFunc(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T> callback)
		{
			Callback = OnCallback;
			func = callback;
		}

		public T OnCallback(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
			T ret;
			if (func != null) {
				ret = func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
			} else {
				ret = default(T);
			}
			Dispose();
			return ret;
		}
	}

	public class CFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T> : CActionBase
	{
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T> Callback { get; protected set; }

		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T> func;

		public CFunc(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T> callback)
		{
			Callback = OnCallback;
			func = callback;
		}

		public T OnCallback(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
			T ret;
			if (func != null) {
				ret = func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
			} else {
				ret = default(T);
			}
			Dispose();
			return ret;
		}
	}

	public class CFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T> : CActionBase
	{
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T> Callback { get; protected set; }

		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T> func;

		public CFunc(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T> callback)
		{
			Callback = OnCallback;
			func = callback;
		}

		public T OnCallback(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
			T ret;
			if (func != null) {
				ret = func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
			} else {
				ret = default(T);
			}
			Dispose();
			return ret;
		}
	}

	public class CFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T> : CActionBase
	{
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T> Callback { get; protected set; }

		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T> func;

		public CFunc(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T> callback)
		{
			Callback = OnCallback;
			func = callback;
		}

		public T OnCallback(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
			T ret;
			if (func != null) {
				ret = func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
			} else {
				ret = default(T);
			}
			Dispose();
			return ret;
		}
	}

	public class CFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T> : CActionBase
	{
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T> Callback { get; protected set; }

		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T> func;

		public CFunc(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T> callback)
		{
			Callback = OnCallback;
			func = callback;
		}

		public T OnCallback(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
			T ret;
			if (func != null) {
				ret = func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
			} else {
				ret = default(T);
			}
			Dispose();
			return ret;
		}
	}

	public class CFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T> : CActionBase
	{
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T> Callback { get; protected set; }

		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T> func;

		public CFunc(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T> callback)
		{
			Callback = OnCallback;
			func = callback;
		}

		public T OnCallback(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
			T ret;
			if (func != null) {
				ret = func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
			} else {
				ret = default(T);
			}
			Dispose();
			return ret;
		}
	}

	public class CFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T> : CActionBase
	{
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T> Callback { get; protected set; }

		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T> func;

		public CFunc(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T> callback)
		{
			Callback = OnCallback;
			func = callback;
		}

		public T OnCallback(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
		{
			T ret;
			if (func != null) {
				ret = func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
			} else {
				ret = default(T);
			}
			Dispose();
			return ret;
		}
	}
}

