using System.Reflection;

namespace It3xl.WeakDelegateProject.States
{
	public interface IWeakDelegateState
	{
		IStrongDelegateState GetStrongDelegateState();
	}
}