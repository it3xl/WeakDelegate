using System;
using System.Collections.Generic;
using It3xl.WeakDelegateProject.States;

namespace It3xl.WeakDelegateProject
{
	// TODO.it3xl.com: Write comments everywhere.
	
	public abstract partial class WeakDelegateBase
	{
		private List<IWeakDelegateState> _weakItems;

		protected WeakDelegateBase(){}

		protected WeakDelegateBase(Delegate inputDelegates)
		{
			var weakItems = GetWeak(inputDelegates);

			_weakItems = weakItems;
		}

		protected void Add(Delegate addingDelegates)
		{
			var newItems = GetStrong(addingDelegates);
			var currentItems = GetAliveStrongItems(_weakItems);



		}

		protected void Remove(Delegate removingDelegates)
		{
			// TODO.it3xl.com: 
		}

		protected void ProcessInvoke(Object[] param)
		{
			List<IStrongDelegateState> currentAliveItems;
			RefreshAliveItems(ref _weakItems, out currentAliveItems);

			currentAliveItems.ForEach(el => el.Invoke(param));
		}

		protected void ProcessInvokeAsync(Object[] param)
		{
			// TODO.it3xl.com: Do the Asynchrony and a Task's support.
			throw new NotImplementedException();
		}

    }

}
