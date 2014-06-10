using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using It3xl.WeakDelegateProject.States;

namespace It3xl.WeakDelegateProject
{
	// TODO.it3xl.com: Write comments everywhere.
	
	public partial class WeakDelegate
	{
		private List<IWeakDelegateState> _weakItems;

		public WeakDelegate(){}

		public WeakDelegate(Delegate inputDelegates)
		{
			var weakItems = GetWeakFlatten(inputDelegates);

			_weakItems = weakItems;
		}

		protected void Add(Delegate addingDelegate)
		{
			var adding = GetStrongSingle(addingDelegate);
			var currentItems = GetAliveStrongItems(_weakItems);

			currentItems.Add(adding);

			ReplaceWeakItems(currentItems);
		}

		protected void Remove(Delegate removingDelegate)
		{
			var removing = GetStrongSingle(removingDelegate);
			var currentItems = GetAliveStrongItems(_weakItems);

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

				// We will repeat the Delegate behaviour.
				// We will remove only the first occurrence.
				break;
			}

			ReplaceWeakItems(currentItems);
		}

		private void ReplaceWeakItems(IEnumerable<IStrongDelegateState> currentItems)
		{
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
