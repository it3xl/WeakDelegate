using System;
using It3xl.WeakDelegateProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WeakDelegateProject.Test
{
	[TestClass]
	public class AddRemoveBehaviour
	{
		private static Int32 _staticValue;
		private Int32 _inctanceValue;

		[TestMethod]
		public void AddingRemovingForStaticMethod()
		{
			_staticValue = 0;
			var myWeakDelegate = new WeakAction<Object, EventArgs>();

			myWeakDelegate.Add(MyWeakStaticEventHandler);
			myWeakDelegate.Invoke(null, null);

			myWeakDelegate.Remove(MyWeakStaticEventHandler);
			myWeakDelegate.Invoke(null, null);

			Assert.AreEqual(1, _staticValue);


			_staticValue = 0;
			myWeakDelegate = new WeakAction<Object, EventArgs>();

			myWeakDelegate.Add(MyWeakStaticEventHandler);
			myWeakDelegate.Add(MyWeakStaticEventHandler);
			myWeakDelegate.Remove(MyWeakStaticEventHandler);
			myWeakDelegate.Invoke(null, null);

			Assert.AreEqual(1, _staticValue);


			_staticValue = 0;
			myWeakDelegate = new WeakAction<Object, EventArgs>();

			myWeakDelegate.Add(MyWeakStaticEventHandler);
			myWeakDelegate.Add(MyWeakStaticEventHandler);
			myWeakDelegate.Remove(MyWeakStaticEventHandler);
			myWeakDelegate.Remove(MyWeakStaticEventHandler);
			myWeakDelegate.Remove(MyWeakStaticEventHandler);
			myWeakDelegate.Invoke(null, null);

			Assert.AreEqual(0, _staticValue);
		}

		private void MyWeakStaticEventHandler(Object sender, EventArgs args)
		{
			_staticValue++;
		}

		[TestMethod]
		public void AddingRemovingForInstanceMethod()
		{
			_inctanceValue = 0;
			var myWeakDelegate = new WeakAction<Object, EventArgs>();

			myWeakDelegate.Add(MyWeakEventHandler);
			myWeakDelegate.Invoke(null, null);

			myWeakDelegate.Remove(MyWeakEventHandler);
			myWeakDelegate.Invoke(null, null);

			Assert.AreEqual(1, _inctanceValue);


			_inctanceValue = 0;
			myWeakDelegate = new WeakAction<Object, EventArgs>();

			myWeakDelegate.Add(MyWeakEventHandler);
			myWeakDelegate.Add(MyWeakEventHandler);
			myWeakDelegate.Remove(MyWeakEventHandler);
			myWeakDelegate.Invoke(null, null);

			Assert.AreEqual(1, _inctanceValue);


			_inctanceValue = 0;
			myWeakDelegate = new WeakAction<Object, EventArgs>();

			myWeakDelegate.Add(MyWeakEventHandler);
			myWeakDelegate.Add(MyWeakEventHandler);
			myWeakDelegate.Remove(MyWeakEventHandler);
			myWeakDelegate.Remove(MyWeakEventHandler);
			myWeakDelegate.Remove(MyWeakEventHandler);
			myWeakDelegate.Invoke(null, null);

			Assert.AreEqual(0, _inctanceValue);
		}

		private void MyWeakEventHandler(Object sender, EventArgs args)
		{
			_inctanceValue++;
		}


	}
}

