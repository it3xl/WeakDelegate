using System;
using It3xl.WeakDelegateProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WeakDelegateProject.Test
{
	[TestClass]
	public class AddingTest
	{
		[TestMethod]
		public void TestMethod1()
		{
			var up = new WeakAction<Int32>()
				.Add(Scaffold.SomeStaticMethod)
				.Add(Scaffold.Current.SomeInstanceMethod)
				;

			up.Invoke(4);

			var resultCount = Scaffold.GetAndEmptyCounter();
			Assert.IsTrue(2 == resultCount);

			//new Object().
		}
	}
}
