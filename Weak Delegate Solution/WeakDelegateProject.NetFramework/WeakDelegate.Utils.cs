using System;
using System.Collections.Generic;
using System.Linq;
using It3xl.WeakDelegateProject.States;

namespace It3xl.WeakDelegateProject
{
	public partial class WeakDelegate
	{
		private static List<IWeakDelegateState> GetWeakFlatten(Delegate inputDelegates)
		{
			var weakItems = inputDelegates.GetInvocationList()
				.Select(GetWeakSingle)
				.ToList();

			return weakItems;
		}

		private static IWeakDelegateState GetWeakSingle(Delegate el)
		{
			if (el.Method.IsStatic)
			{
				return new StaticDelegateState(el);
			}
			return new InstanceWeakDelegateState(el);
		}

		// ReSharper disable UnusedMember.Local
		private static List<IStrongDelegateState> GetStrongFlatten(Delegate inputDelegates)
		// ReSharper restore UnusedMember.Local
		{
			var strongItems = inputDelegates.GetInvocationList()
				.Select(GetStrongSingle)
				.ToList();

			return strongItems;
		}

		private static IStrongDelegateState GetStrongSingle(Delegate el)
		{
			if (el.Method.IsStatic)
			{
				return new StaticDelegateState(el);
			}
			return new InstanceStrongDelegateState(el);
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
