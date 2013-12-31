using System;

namespace It3xl.WeakDelegateProject.States
{
	public abstract class DelegateStateBase
	{
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
