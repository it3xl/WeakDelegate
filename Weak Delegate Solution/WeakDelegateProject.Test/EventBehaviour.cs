using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WeakDelegateProject.Test
{
	[TestClass]
	public class EventBehaviour
	{
		private static Int32 _staticValue;

		[TestMethod]
		public void WeakEventWorks()
		{
			_staticValue = 0;
			var myObject = new MyClassWithWeakEvent();

			myObject.MyWeakEvent += MyWeakEventHandler;
			myObject.OnMyWeakEvent(new Object(), new EventArgs());

			myObject.MyWeakEvent -= MyWeakEventHandler;
			myObject.OnMyWeakEvent(new Object(), new EventArgs());

			Assert.AreEqual(1, _staticValue);
		}

		private static void MyWeakEventHandler(Object sender, EventArgs args)
		{
			_staticValue++;
		}

	}
}
