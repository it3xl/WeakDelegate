using System;
using System.Reflection;

namespace It3xl.WeakDelegateProject
{
	internal sealed class InstanceWeakDelegateState : IWeakDelegateState
	{
		public InstanceWeakDelegateState(InstanceStrongDelegateState instanceStrongDelegateState)
		{
			WeakTarget = new WeakReference(instanceStrongDelegateState.Target);
			Method = instanceStrongDelegateState.Method;
		}

		public InstanceWeakDelegateState(Delegate @delegate)
		{
			WeakTarget = new WeakReference(@delegate.Target);
			Method = @delegate.Method;
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