using System.Reflection;

namespace It3xl.WeakDelegateProject.States
{
	public interface IWeakDelegateState
	{
		MethodInfo Method { get; }

		IStrongDelegateState GetStrongDelegateState();
	}
}