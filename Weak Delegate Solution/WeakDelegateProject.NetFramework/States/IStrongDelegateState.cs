using System;

namespace It3xl.WeakDelegateProject.States
{
	public interface IStrongDelegateState
	{
		Boolean Alive { get; }

		IWeakDelegateState GetWeakDelegateState();

		void Invoke(Object[] param);
	}
}