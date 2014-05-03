using System;
using It3xl.WeakDelegateProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WeakDelegateProject.Test
{
	[TestClass]
	public class AddRemoveBehaviour
	{
		private static Int32 _value = 0;

		[TestMethod]
		public void AddRemoveWorks()
		{
			var myWeakDelegate = new WeakAction<Object, EventArgs>();
			myWeakDelegate.Add(MyWeakEventHandler);
			myWeakDelegate.Invoke(null, null);
			myWeakDelegate.Remove(MyWeakEventHandler);
			myWeakDelegate.Invoke(null, null);

			Assert.AreEqual(1, _value);




			// Проверить добавление двух, удаление одного и чтоб сработал только один.
			// Проверить идентичность повдедения делегату:
			//   Добавление одного и того же дважды.
			//   Удаление трех одного и того же после этого.


		}

		private static void MyWeakEventHandler(Object sender, EventArgs args)
		{
			_value++;
		}


	}
}

