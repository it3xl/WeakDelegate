using System;
using It3xl.WeakDelegateProject;

namespace WeakDelegateProject.Test
{
	/// <summary>
	/// The class is example of implementation of the Weak Event.
	/// http://weakevent.codeplex.com/
	/// </summary>
	public class MyClassWithWeakEvent
	{
		/// <summary>
		/// The underlying instance of the Weak Delegate. See http://weakdelegate.codeplex.com/
		/// </summary>
		private readonly WeakAction<object, EventArgs> _myWeakDelegate = new WeakAction<Object, EventArgs>();

		/// <summary>
		/// Some weak event.<para/>
		/// Any weak event is created by the Custom Event Accessors http://msdn.microsoft.com/en-us/library/bb882534.aspx
		/// plus Weak Delegate http://weakdelegate.codeplex.com/
		/// </summary>
		public event Action<Object, EventArgs> MyWeakEvent
		{
			add
			{
				_myWeakDelegate.Add(value);
			}
			remove
			{
				_myWeakDelegate.Remove(value);
			}
		}

		/// <summary>
		/// Invocator of the <see cref="MyWeakEvent"/>.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		public void OnMyWeakEvent(Object sender, EventArgs args)
		{
			_myWeakDelegate.Invoke(sender, args);
		}

	}
}