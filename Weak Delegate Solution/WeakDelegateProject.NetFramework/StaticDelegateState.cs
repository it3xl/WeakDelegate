using System;
using System.Reflection;

namespace It3xl.WeakDelegateProject
{
	internal sealed class StaticDelegateState : IWeakDelegateState, IStrongDelegateState
	{
		public StaticDelegateState(Delegate @delegate)
		{
			Method = @delegate.Method;
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