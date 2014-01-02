using System;
using System.Collections.Generic;
using System.Linq;
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
			var addingItems = GetStrong(addingDelegates);
			var currentItems = GetAliveStrongItems(_weakItems);

			_weakItems = currentItems
				.Union(addingItems)
				.Select(el => el.GetWeakDelegateState())
				.ToList();
		}

		protected void Remove(Delegate removingDelegates)
		{
			var removingItems = GetStrong(removingDelegates);
			var currentItems = GetAliveStrongItems(_weakItems);

			removingItems.ForEach(el => currentItems.Remove(el));

			_weakItems = currentItems
				.Select(el => el.GetWeakDelegateState())
				.ToList();
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
