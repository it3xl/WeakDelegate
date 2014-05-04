using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
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
			// It's excessive Delegate's hierarchy support.
			var removingItems = GetStrong(removingDelegates);


			var currentItems = GetAliveStrongItems(_weakItems);

			// We will repeat the Delegate behaviour.
			foreach (var removing in removingItems)
			{
				foreach (var hosted in currentItems.ToArray())
				{
					if(removing.Target != hosted.Target)
					{
						continue;
					}
					if(removing.Method != hosted.Method)
					{
						continue;
					}

					currentItems.Remove(hosted);

					// We will remove only the first occurrence.
					break;
				}
			}

			_weakItems = currentItems
				.Select(el => el.GetWeakDelegateState())
				.ToList();
		}

		private void InvokeRaw(Object[] param, Action<SendOrPostCallback, Object> invoker)
		{
			List<IStrongDelegateState> currentAliveItems;
			RefreshAliveItems(ref _weakItems, out currentAliveItems);

			currentAliveItems.ForEach(el => invoker(p => el.Invoke((Object[])p), param));
		}

		protected void ProcessInvoke(Object[] param)
		{
			InvokeRaw(param, (p, state) => p(state));
		}

		protected void ProcessInvokeAsync(Object[] param)
		{
			var syncContext = SynchronizationContext.Current ?? new SynchronizationContext();
			InvokeRaw(param, syncContext.Post);
		}

    }

}
