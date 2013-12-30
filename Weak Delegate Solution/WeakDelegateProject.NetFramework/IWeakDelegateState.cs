using System;
using System.Reflection;

namespace It3xl.WeakDelegateProject
{
	public interface IWeakDelegateState
	{
		MethodInfo Method { get; }

		IStrongDelegateState GetStrongDelegateState();
	}
}