using System;
using System.Reflection;

namespace It3xl.WeakDelegateProject.States
{
	public abstract class DelegateStateBase
	{
		private readonly MethodInfo _method;
		public MethodInfo Method
		{
			get { return _method; }
		}

		protected DelegateStateBase(MethodInfo method)
		{
			if(method == null)
			{
				throw new ArgumentNullException("method");
			}

			_method = method;
		}

		protected static void CheckDelegateIsSingleOrThrow(Delegate singleMethodDelegate)
		{
			var innerDelegatesCount = singleMethodDelegate.GetInvocationList().Length;
			var isMultiCastDelegate = 1 < innerDelegatesCount;
			if (isMultiCastDelegate)
			{
				throw new ArgumentException("The input delegate must point out to one method only.", "singleMethodDelegate");
			}
		}
	}
}
