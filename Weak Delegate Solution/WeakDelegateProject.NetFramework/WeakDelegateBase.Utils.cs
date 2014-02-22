using System;
using System.Collections.Generic;
using System.Linq;
using It3xl.WeakDelegateProject.States;

namespace It3xl.WeakDelegateProject
{
	public abstract partial class WeakDelegateBase
	{
		private static List<IWeakDelegateState> GetWeak(Delegate inputDelegates)
		{
			var weakItems = inputDelegates.GetInvocationList()
				.Select(el =>
				{
					if (el.Method.IsStatic)
					{
						return (IWeakDelegateState)new StaticDelegateState(el);
					}
					return new InstanceWeakDelegateState(el);
				})
				.ToList();

			return weakItems;
		}

		private static List<IStrongDelegateState> GetStrong(Delegate inputDelegates)
		{
			var strongItems = inputDelegates.GetInvocationList()
				.Select(el =>
				{
					if (el.Method.IsStatic)
					{
						return (IStrongDelegateState)new StaticDelegateState(el);
					}
					return new InstanceStrongDelegateState(el);
				})
				.ToList();

			return strongItems;
		}

		private static void RefreshAliveItems(ref List<IWeakDelegateState> weakItems, out List<IStrongDelegateState> currentAliveItems)
		{
			currentAliveItems = GetAliveStrongItems(weakItems);
			weakItems = currentAliveItems
				.Select(el => el.GetWeakDelegateState())
				.ToList();
		}

		private static List<IStrongDelegateState> GetAliveStrongItems(List<IWeakDelegateState> weakItems)
		{
			if (weakItems == null)
			{
				return new List<IStrongDelegateState>();
			}

			var aliveItems = weakItems
				.Select(el => el.GetStrongDelegateState())
				.Where(el => el.Alive)
				.ToList();

			return aliveItems;
		}
	}

}
