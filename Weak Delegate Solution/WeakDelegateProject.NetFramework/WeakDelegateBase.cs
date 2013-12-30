namespace It3xl.WeakDelegateProject
{
	// TODO.it3xl.com: Write comments everywhere.
	
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public abstract class WeakDelegateBase
	{
		private List<IWeakDelegateState> _weakItems;

		protected WeakDelegateBase(){}

		protected WeakDelegateBase(Delegate inputDelegate)
		{
			var weakItem = inputDelegate.GetInvocationList()
				.Select(el =>
					{
						if(el.Method.IsStatic)
						{
							return (IWeakDelegateState)new StaticDelegateState(el);
						}
						return new InstanceWeakDelegateState(el);
					})
				.ToList();

			_weakItems = weakItem;
		}

		protected void Add(Delegate @delegate)
		{
			// TODO.it3xl.com: 
		}

		protected void Remove(Delegate @delegate)
		{
			// TODO.it3xl.com: 
		}

		protected void ProcessInvoke(Object[] param)
		{
			List<IStrongDelegateState> aliveItems;
			RefreshAliveItems(ref _weakItems, out aliveItems);

			aliveItems.ForEach(el => el.Invoke(param));
		}

		protected void ProcessInvokeAsync(Object[] param)
		{
			// TODO.it3xl.com: Do the Asynchrony and a Task's support.
			throw new NotImplementedException();
		}

		private static void RefreshAliveItems(ref List<IWeakDelegateState> weakItems, out List<IStrongDelegateState> aliveItems)
		{
			if (weakItems == null)
			{
				weakItems = new List<IWeakDelegateState>();
			}

			aliveItems = weakItems
				.Select(el => el.GetStrongDelegateState())
				.Where(el => el.Alive)
				.ToList();
			weakItems = aliveItems
				.Select(el => el.GetWeakDelegateState())
				.ToList();
		}
    }

}
