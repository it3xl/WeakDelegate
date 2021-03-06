using System;
using System.Reflection;

namespace It3xl.WeakDelegateProject.States
{
	public interface IStrongDelegateState
	{
		Boolean Alive { get; }

		MethodInfo Method { get; }

		IWeakDelegateState GetWeakDelegateState();

		Object Target { get; }

		void Invoke(Object[] param);
	}
}