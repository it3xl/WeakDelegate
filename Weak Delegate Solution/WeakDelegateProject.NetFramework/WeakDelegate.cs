namespace It3xl.WeakDelegateProject
{
	using System;

	/// <summary>
	/// TODO.it3xl.com: To write the comment.
	/// </summary>
    public class WeakDelegate
    {
		public WeakDelegate(Delegate inputDelegate)
		{
			// Посмотреть, какой будет Invocation list у вложенный перевложенных делегатов.

			var inv = inputDelegate.GetInvocationList();
		}
    }
}
