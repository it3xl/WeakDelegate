using System;

namespace It3xl.WeakDelegateProject.States
{
	internal sealed class InstanceStrongDelegateState : DelegateStateBase, IStrongDelegateState
	{

		public InstanceStrongDelegateState(InstanceWeakDelegateState instanceWeakState)
			: base(instanceWeakState.Method)
		{
			_target = instanceWeakState.Target;
		}

		public InstanceStrongDelegateState(Delegate singleMethodDelegate)
			: base(singleMethodDelegate.Method)
		{
			CheckDelegateIsSingleOrThrow(singleMethodDelegate);

			_target = singleMethodDelegate.Target;
		}

		public Boolean Alive { get { return Target != null; } }

		private readonly Object _target;
		public Object Target
		{
			get { return _target; }
		}

		public IWeakDelegateState GetWeakDelegateState()
		{
			return new InstanceWeakDelegateState(this);
		}

		public void Invoke(Object[] param)
		{
			if(Target == null)
			{
				return;
			}

			Method.Invoke(Target, param);
		}
	}
}