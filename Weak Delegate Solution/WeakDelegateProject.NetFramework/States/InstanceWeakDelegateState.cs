using System;
using System.Reflection;

namespace It3xl.WeakDelegateProject.States
{
	internal sealed class InstanceWeakDelegateState : DelegateStateBase, IWeakDelegateState
	{
		public InstanceWeakDelegateState(InstanceStrongDelegateState instanceStrongDelegateState)
		{
			WeakTarget = new WeakReference(instanceStrongDelegateState.Target);
			Method = instanceStrongDelegateState.Method;
		}

		public InstanceWeakDelegateState(Delegate singleMethodDelegate)
		{
			CheckDelegateIsSingleOrThrow(singleMethodDelegate);

			WeakTarget = new WeakReference(singleMethodDelegate.Target);
			Method = singleMethodDelegate.Method;
		}

		public Boolean Alive { get { return Target != null; } }
		public MethodInfo Method { get; private set; }

		private WeakReference WeakTarget { get; set; }
		public Object Target
		{
			get
			{
				if (WeakTarget == null)
				{
					return null;
				}

				return WeakTarget.Target;
			}
		}

		public IStrongDelegateState GetStrongDelegateState()
		{
			return new InstanceStrongDelegateState(this);
		}
	}
}