namespace WeakDelegateProject.Test
{
	using System;
	using It3xl.WeakDelegateProject;
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	[TestClass]
	public class CommonBehaviours
	{

		/// <summary>
		/// Static methods' support.
		/// </summary>
		[TestMethod]
		public void StaticMethodsAreSupported()
		{
			Action<Scaffold> staticMethod = Scaffold.SomeStaticMethod;

			var scaffold = new Scaffold();
			var result = new WeakAction<Scaffold>(staticMethod);
			result.Invoke(scaffold);

			Assert.AreEqual(1, scaffold.InvokeCount);
		}

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
	}
}
