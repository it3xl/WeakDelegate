using System;
using System.Reflection;

namespace It3xl.WeakDelegateProject
{
	internal sealed class InstanceStrongDelegateState : IStrongDelegateState
	{
		public InstanceStrongDelegateState(InstanceWeakDelegateState instanceWeakState)
		{
			Target = instanceWeakState.Target;
			Method = instanceWeakState.Method;
		}

		public Boolean Alive { get { return Target != null; } }
		public MethodInfo Method { get; private set; }

		public Object Target { get; private set; }

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