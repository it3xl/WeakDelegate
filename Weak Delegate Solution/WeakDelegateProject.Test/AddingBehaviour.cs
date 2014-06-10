using System;
using System.Diagnostics;
using It3xl.WeakDelegateProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WeakDelegateProject.Test
{
	[TestClass]
	public class AddingBehaviour
	{
		[TestMethod]
		public void AddingWorks()
		{
			Debug.WriteLine(1);

			var scaffold = new Scaffold();
			var up = new WeakAction<Int32, Scaffold>()
				.Add(Scaffold.SomeStaticMethod)
				.Add(scaffold.SomeInstanceMethod)
				;

			Debug.WriteLine(2);

			up.Invoke(4, scaffold);

			Debug.WriteLine(3);

			var resultCount = scaffold.GetAndEmptyCounter();
			
			Debug.WriteLine(resultCount);
			Assert.AreEqual(2, resultCount);

			//new Object().
		}
	}
}
