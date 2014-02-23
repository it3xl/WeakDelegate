using System;

namespace WeakDelegateProject.Test
{
	public class Scaffold
	{
		private readonly Object _locker = new Object();

		public Int32 InvokeCount { get; set; }

		public static void IncreaseCounter(Scaffold scaffold)
		{
			lock (scaffold._locker)
			{
				scaffold.InvokeCount++;
			}
		}

		public void EmptyCounter()
		{
			lock (_locker)
			{
				InvokeCount = 0;
			}
		}

		public Int32 GetAndEmptyCounter()
		{
			var counter = InvokeCount;
			EmptyCounter();

			return counter;
		}


		public static void SomeStaticMethod()
		{
			throw new NotImplementedException("This method is not for a invoking.");
		}
		public static void SomeStaticMethod(Scaffold scaffold)
		{
			IncreaseCounter(scaffold);
		}
		public static void SomeStaticMethod(Int32 i, Scaffold scaffold)
		{
			IncreaseCounter(scaffold);
		}
		public static void SomeStaticMethod(String s, Scaffold scaffold)
		{
			IncreaseCounter(scaffold);
		}

		public void SomeInstanceMethod()
		{
			throw new NotImplementedException("This method is not for a invoking.");
		}
		public void SomeInstanceMethod(Scaffold scaffold)
		{
			IncreaseCounter(scaffold);
		}
		public void SomeInstanceMethod(Int32 i, Scaffold scaffold)
		{
			IncreaseCounter(scaffold);
		}
		public void SomeInstanceMethod(String s, Scaffold scaffold)
		{
			IncreaseCounter(scaffold);
		}

	}
}
