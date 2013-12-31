using System;
using System.Reflection;

namespace It3xl.WeakDelegateProject.States
{
	internal sealed class StaticDelegateState : DelegateStateBase, IWeakDelegateState, IStrongDelegateState
	{
		public StaticDelegateState(Delegate singleMethodDelegate)
		{
			CheckDelegateIsSingleOrThrow(singleMethodDelegate);

			Method = singleMethodDelegate.Method;
		}

		public Boolean Alive{get { return true; }}
		public MethodInfo Method { get; set; }

		public IStrongDelegateState GetStrongDelegateState()
		{
			return this;
		}

		public IWeakDelegateState GetWeakDelegateState()
		{
			return this;
		}

		public void Invoke(Object[] param)
		{
			Method.Invoke(null, param);
		}
	}
}