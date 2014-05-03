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

	}
}
