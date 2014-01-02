using System;
using System.Reflection;

namespace It3xl.WeakDelegateProject.States
{
	internal sealed class InstanceWeakDelegateState : DelegateStateBase, IWeakDelegateState
	{
		public InstanceWeakDelegateState(InstanceStrongDelegateState instanceStrongDelegateState)
			: base(instanceStrongDelegateState.Method)
		{
			_weakTarget = new WeakReference(instanceStrongDelegateState.Target);
		}

		public InstanceWeakDelegateState(Delegate singleMethodDelegate)
			: base(singleMethodDelegate.Method)
		{
			CheckDelegateIsSingleOrThrow(singleMethodDelegate);

			_weakTarget = new WeakReference(singleMethodDelegate.Target);
		}

		public Boolean Alive { get { return Target != null; } }

		private readonly WeakReference _weakTarget;
		public Object Target
		{
			get
			{
				if (_weakTarget == null)
				{
					return null;
				}

				return _weakTarget.Target;
			}
		}

		public IStrongDelegateState GetStrongDelegateState()
		{
			return new InstanceStrongDelegateState(this);
		}
	}
}