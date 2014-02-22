using System;

namespace WeakDelegateProject.Test
{
	public class Scaffold
	{
		private static readonly Object Locker = new Object();

		public static readonly Scaffold Current = new Scaffold();
		private static int _counter;

		public static Int32 Counter
		{
			get { return _counter; }
		}

		public static void IncreaseCounter()
		{
			lock (Locker)
			{
				_counter++;
			}
		}

		public static void EmptyCounter()
		{
			lock (Locker)
			{
				_counter = 0;
			}
		}

		public static Int32 GetAndEmptyCounter()
		{
			var counter = Counter;
			EmptyCounter();

			return counter;
		}

		public static void SomeStaticMethod()
		{
			IncreaseCounter();
		}
		public static void SomeStaticMethod(Int32 i)
		{
			IncreaseCounter();
		}
		public static void SomeStaticMethod(String s)
		{
			IncreaseCounter();
		}

		public void SomeInstanceMethod()
		{
			IncreaseCounter();
		}
		public void SomeInstanceMethod(Int32 i)
		{
			IncreaseCounter();
		}
		public void SomeInstanceMethod(String s)
		{
			IncreaseCounter();
		}

	}
}
