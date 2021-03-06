using System;

namespace It3xl.WeakDelegateProject.States
{
	internal sealed class StaticDelegateState : DelegateStateBase, IWeakDelegateState, IStrongDelegateState
	{
		public StaticDelegateState(Delegate singleMethodDelegate)
			: base(singleMethodDelegate.Method)
		{
			CheckDelegateIsSingleOrThrow(singleMethodDelegate);
		}

		public Boolean Alive { get { return true; } }

		public object Target { get { return null; } }

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