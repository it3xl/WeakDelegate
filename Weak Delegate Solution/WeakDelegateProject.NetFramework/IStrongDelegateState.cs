using System;
using System.Collections.Generic;
using System.Reflection;

namespace It3xl.WeakDelegateProject
{
	public interface IStrongDelegateState
	{
		Boolean Alive { get; }
		MethodInfo Method { get; }

		IWeakDelegateState GetWeakDelegateState();

		void Invoke(Object[] param);
	}
}