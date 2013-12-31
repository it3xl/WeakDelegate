namespace WeakDelegateProject.Test
{
	using System;
	using System.Linq;
	using It3xl.WeakDelegateProject;
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	[TestClass]
	public class UnitTest1
	{

		/// <summary>
		/// Static methods' support.
		/// </summary>
		[TestMethod]
		public void StaticMethodSupport()
		{
			Action staticMethod = Scaffold.SomeStaticMethod;

			var result = new WeakAction(staticMethod);
			result.Invoke();
		}


		// TODO.it3xl.com: Add the Add and Remove support.


		[TestMethod]
		public void FlatNatureOfMulticastDelegate()
		{
			Action a = FlatNatureOfMulticastDelegate;
			Action b = FlatNatureOfMulticastDelegate;
			Action c = FlatNatureOfMulticastDelegate;
			Action d = FlatNatureOfMulticastDelegate;

			var u = FlatNatureOfMulticastDelegate + a;
			Assert.IsTrue(u.GetInvocationList().Length == 2);

			var y = b + c;
			Assert.IsTrue(y.GetInvocationList().Length == 2);

			var x = u + y + d;
			var il = x.GetInvocationList();
			Assert.IsTrue(il.Length == 5);

			foreach (var @delegate in il)
			{
				Assert.IsTrue(@delegate.GetInvocationList().Length == 1);
			}
		}
	}
}
