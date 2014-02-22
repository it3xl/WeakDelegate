using System;
using System.Reflection;

namespace It3xl.WeakDelegateProject.States
{
	/// <summary>
	/// The common type for all states of a delegate.
	/// </summary>
	public abstract class DelegateStateBase
	{
		private readonly MethodInfo _method;
		public MethodInfo Method
		{
			get { return _method; }
		}

		/// <summary>
		/// The constructor.
		/// </summary>
		/// <param name="method"></param>
		protected DelegateStateBase(MethodInfo method)
		{
			if(method == null)
			{
				throw new ArgumentNullException("method");
			}

			_method = method;
		}

		/// <summary>
		/// Ensures the strong principle: "One delegate one Delegate State".
		/// </summary>
		/// <param name="singleMethodDelegate"></param>
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
