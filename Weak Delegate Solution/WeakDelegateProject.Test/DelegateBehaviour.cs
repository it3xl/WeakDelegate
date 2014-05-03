using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WeakDelegateProject.Test
{
	[TestClass]
	public class DelegateBehaviour
	{
		[TestMethod]
		public void MulticastDelegateHasFlatNature()
		{
			Action instanceDelegate = MulticastDelegateHasFlatNature;

			Action a = instanceDelegate;
			Action b = Scaffold.SomeStaticMethod;
			Action c = instanceDelegate;
			Action d = Scaffold.SomeStaticMethod;

			var u = instanceDelegate + a;
			Assert.AreEqual(2, u.GetInvocationList().Length);

			var y = b + c;
			Assert.AreEqual(2, y.GetInvocationList().Length);

			var x = u + y + d;
			var il = x.GetInvocationList();
			Assert.AreEqual(5, il.Length);

			foreach (var @delegate in il)
			{
				Assert.AreEqual(1, @delegate.GetInvocationList().Length);
			}
		}


		[TestMethod]
		public void AddingRemovingForSameInstanceMethods()
		{
			Action myInstanceDelegate = AddingRemovingForSameInstanceMethods;
			myInstanceDelegate += AddingRemovingForSameInstanceMethods;
			myInstanceDelegate += AddingRemovingForSameInstanceMethods;

			Assert.AreEqual(3, myInstanceDelegate.GetInvocationList().Length);

			myInstanceDelegate -= AddingRemovingForSameInstanceMethods;
			myInstanceDelegate -= AddingRemovingForSameInstanceMethods;

			Assert.AreEqual(1, myInstanceDelegate.GetInvocationList().Length);

			myInstanceDelegate -= AddingRemovingForSameInstanceMethods;

			Assert.AreEqual(null, myInstanceDelegate);

			myInstanceDelegate -= AddingRemovingForSameInstanceMethods;

			Assert.AreEqual(null, myInstanceDelegate);

			myInstanceDelegate -= AddingRemovingForSameInstanceMethods;
			myInstanceDelegate -= AddingRemovingForSameInstanceMethods;
			myInstanceDelegate -= AddingRemovingForSameInstanceMethods;
			myInstanceDelegate -= AddingRemovingForSameInstanceMethods;
			myInstanceDelegate -= AddingRemovingForSameInstanceMethods;

			Assert.AreEqual(null, myInstanceDelegate);

		}

		[TestMethod]
		public void AddingRemovingForSameStaticMethods()
		{
			Action myInstanceDelegate = Scaffold.SomeStaticMethod;
			myInstanceDelegate += Scaffold.SomeStaticMethod;
			myInstanceDelegate += Scaffold.SomeStaticMethod;

			Assert.AreEqual(3, myInstanceDelegate.GetInvocationList().Length);

			myInstanceDelegate -= Scaffold.SomeStaticMethod;
			myInstanceDelegate -= Scaffold.SomeStaticMethod;

			Assert.AreEqual(1, myInstanceDelegate.GetInvocationList().Length);

			myInstanceDelegate -= Scaffold.SomeStaticMethod;

			Assert.AreEqual(null, myInstanceDelegate);

			myInstanceDelegate -= Scaffold.SomeStaticMethod;

			Assert.AreEqual(null, myInstanceDelegate);

			myInstanceDelegate -= Scaffold.SomeStaticMethod;
			myInstanceDelegate -= Scaffold.SomeStaticMethod;
			myInstanceDelegate -= Scaffold.SomeStaticMethod;
			myInstanceDelegate -= Scaffold.SomeStaticMethod;
			myInstanceDelegate -= Scaffold.SomeStaticMethod;

			Assert.AreEqual(null, myInstanceDelegate);

		}





	}
}
