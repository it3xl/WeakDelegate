using System;

namespace It3xl.WeakDelegateProject
{

	// !!!
	// Auto generated code. To change it use the WeackAction.tt file.
	// !!!

	/// <summary>
	/// Encapsulates a weak delegate of the <see cref="Action"/>.
	/// </summary>
	public sealed class WeakAction : WeakDelegateBase
	{
		public WeakAction(){}
		public WeakAction(Action inputDelegate)
			: base(inputDelegate)
		{
		}

		public WeakAction Add(Action delegatesForAdding)
		{
			base.Add(delegatesForAdding);

			return this;
		}

		public WeakAction Remove(Action delegatesForRemoving)
		{
			base.Add(delegatesForRemoving);

			return this;
		}

		public void Invoke()
		{
			ProcessInvoke(null);
		}

		public void InvokeAsync()
		{
			ProcessInvokeAsync(null);
		}
	}

	/// <summary>
	/// Encapsulates a weak delegate of the <see cref="Action{T1}"/>.
	/// </summary>
	public sealed class WeakAction<T1> : WeakDelegateBase
	{
		public WeakAction(){}
		public WeakAction(Action<T1> inputDelegate)
			: base(inputDelegate)
		{
		}

		public WeakAction<T1> Add(Action<T1> delegatesForAdding)
		{
			base.Add(delegatesForAdding);

			return this;
		}

		public WeakAction<T1> Remove(Action<T1> delegatesForRemoving)
		{
			base.Add(delegatesForRemoving);

			return this;
		}

		public void Invoke(T1 t1)
		{
			ProcessInvoke(new object[] { t1 });
		}

		public void InvokeAsync(T1 t1)
		{
			ProcessInvokeAsync(new object[] { t1 });
		}
	}

	/// <summary>
	/// Encapsulates a weak delegate of the <see cref="Action{T1, T2}"/>.
	/// </summary>
	public sealed class WeakAction<T1, T2> : WeakDelegateBase
	{
		public WeakAction(){}
		public WeakAction(Action<T1, T2> inputDelegate)
			: base(inputDelegate)
		{
		}

		public WeakAction<T1, T2> Add(Action<T1, T2> delegatesForAdding)
		{
			base.Add(delegatesForAdding);

			return this;
		}

		public WeakAction<T1, T2> Remove(Action<T1, T2> delegatesForRemoving)
		{
			base.Remove(delegatesForRemoving);

			return this;
		}

		public void Invoke(T1 t1, T2 t2)
		{
			ProcessInvoke(new object[] { t1, t2 });
		}

		public void InvokeAsync(T1 t1, T2 t2)
		{
			ProcessInvokeAsync(new object[] { t1, t2 });
		}
	}

	/// <summary>
	/// Encapsulates a weak delegate of the <see cref="Action{T1, T2, T3}"/>.
	/// </summary>
	public sealed class WeakAction<T1, T2, T3> : WeakDelegateBase
	{
		public WeakAction(){}
		public WeakAction(Action<T1, T2, T3> inputDelegate)
			: base(inputDelegate)
		{
		}

		public WeakAction<T1, T2, T3> Add(Action<T1, T2, T3> delegatesForAdding)
		{
			base.Add(delegatesForAdding);

			return this;
		}

		public WeakAction<T1, T2, T3> Remove(Action<T1, T2, T3> delegatesForRemoving)
		{
			base.Add(delegatesForRemoving);

			return this;
		}

		public void Invoke(T1 t1, T2 t2, T3 t3)
		{
			ProcessInvoke(new object[] { t1, t2, t3 });
		}

		public void InvokeAsync(T1 t1, T2 t2, T3 t3)
		{
			ProcessInvokeAsync(new object[] { t1, t2, t3 });
		}
	}

	/// <summary>
	/// Encapsulates a weak delegate of the <see cref="Action{T1, T2, T3, T4}"/>.
	/// </summary>
	public sealed class WeakAction<T1, T2, T3, T4> : WeakDelegateBase
	{
		public WeakAction(){}
		public WeakAction(Action<T1, T2, T3, T4> inputDelegate)
			: base(inputDelegate)
		{
		}

		public WeakAction<T1, T2, T3, T4> Add(Action<T1, T2, T3, T4> delegatesForAdding)
		{
			base.Add(delegatesForAdding);

			return this;
		}

		public WeakAction<T1, T2, T3, T4> Remove(Action<T1, T2, T3, T4> delegatesForRemoving)
		{
			base.Add(delegatesForRemoving);

			return this;
		}

		public void Invoke(T1 t1, T2 t2, T3 t3, T4 t4)
		{
			ProcessInvoke(new object[] { t1, t2, t3, t4 });
		}

		public void InvokeAsync(T1 t1, T2 t2, T3 t3, T4 t4)
		{
			ProcessInvokeAsync(new object[] { t1, t2, t3, t4 });
		}
	}

	/// <summary>
	/// Encapsulates a weak delegate of the <see cref="Action{T1, T2, T3, T4, T5}"/>.
	/// </summary>
	public sealed class WeakAction<T1, T2, T3, T4, T5> : WeakDelegateBase
	{
		public WeakAction(){}
		public WeakAction(Action<T1, T2, T3, T4, T5> inputDelegate)
			: base(inputDelegate)
		{
		}

		public WeakAction<T1, T2, T3, T4, T5> Add(Action<T1, T2, T3, T4, T5> delegatesForAdding)
		{
			base.Add(delegatesForAdding);

			return this;
		}

		public WeakAction<T1, T2, T3, T4, T5> Remove(Action<T1, T2, T3, T4, T5> delegatesForRemoving)
		{
			base.Add(delegatesForRemoving);

			return this;
		}

		public void Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
		{
			ProcessInvoke(new object[] { t1, t2, t3, t4, t5 });
		}

		public void InvokeAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
		{
			ProcessInvokeAsync(new object[] { t1, t2, t3, t4, t5 });
		}
	}

	/// <summary>
	/// Encapsulates a weak delegate of the <see cref="Action{T1, T2, T3, T4, T5, T6}"/>.
	/// </summary>
	public sealed class WeakAction<T1, T2, T3, T4, T5, T6> : WeakDelegateBase
	{
		public WeakAction(){}
		public WeakAction(Action<T1, T2, T3, T4, T5, T6> inputDelegate)
			: base(inputDelegate)
		{
		}

		public WeakAction<T1, T2, T3, T4, T5, T6> Add(Action<T1, T2, T3, T4, T5, T6> delegatesForAdding)
		{
			base.Add(delegatesForAdding);

			return this;
		}

		public WeakAction<T1, T2, T3, T4, T5, T6> Remove(Action<T1, T2, T3, T4, T5, T6> delegatesForRemoving)
		{
			base.Add(delegatesForRemoving);

			return this;
		}

		public void Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
		{
			ProcessInvoke(new object[] { t1, t2, t3, t4, t5, t6 });
		}

		public void InvokeAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
		{
			ProcessInvokeAsync(new object[] { t1, t2, t3, t4, t5, t6 });
		}
	}

	/// <summary>
	/// Encapsulates a weak delegate of the <see cref="Action{T1, T2, T3, T4, T5, T6, T7}"/>.
	/// </summary>
	public sealed class WeakAction<T1, T2, T3, T4, T5, T6, T7> : WeakDelegateBase
	{
		public WeakAction(){}
		public WeakAction(Action<T1, T2, T3, T4, T5, T6, T7> inputDelegate)
			: base(inputDelegate)
		{
		}

		public WeakAction<T1, T2, T3, T4, T5, T6, T7> Add(Action<T1, T2, T3, T4, T5, T6, T7> delegatesForAdding)
		{
			base.Add(delegatesForAdding);

			return this;
		}

		public WeakAction<T1, T2, T3, T4, T5, T6, T7> Remove(Action<T1, T2, T3, T4, T5, T6, T7> delegatesForRemoving)
		{
			base.Add(delegatesForRemoving);

			return this;
		}

		public void Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
		{
			ProcessInvoke(new object[] { t1, t2, t3, t4, t5, t6, t7 });
		}

		public void InvokeAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
		{
			ProcessInvokeAsync(new object[] { t1, t2, t3, t4, t5, t6, t7 });
		}
	}

	/// <summary>
	/// Encapsulates a weak delegate of the <see cref="Action{T1, T2, T3, T4, T5, T6, T7, T8}"/>.
	/// </summary>
	public sealed class WeakAction<T1, T2, T3, T4, T5, T6, T7, T8> : WeakDelegateBase
	{
		public WeakAction(){}
		public WeakAction(Action<T1, T2, T3, T4, T5, T6, T7, T8> inputDelegate)
			: base(inputDelegate)
		{
		}

		public WeakAction<T1, T2, T3, T4, T5, T6, T7, T8> Add(Action<T1, T2, T3, T4, T5, T6, T7, T8> delegatesForAdding)
		{
			base.Add(delegatesForAdding);

			return this;
		}

		public WeakAction<T1, T2, T3, T4, T5, T6, T7, T8> Remove(Action<T1, T2, T3, T4, T5, T6, T7, T8> delegatesForRemoving)
		{
			base.Add(delegatesForRemoving);

			return this;
		}

		public void Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
		{
			ProcessInvoke(new object[] { t1, t2, t3, t4, t5, t6, t7, t8 });
		}

		public void InvokeAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
		{
			ProcessInvokeAsync(new object[] { t1, t2, t3, t4, t5, t6, t7, t8 });
		}
	}

	/// <summary>
	/// Encapsulates a weak delegate of the <see cref="Action{T1, T2, T3, T4, T5, T6, T7, T8, T9}"/>.
	/// </summary>
	public sealed class WeakAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> : WeakDelegateBase
	{
		public WeakAction(){}
		public WeakAction(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> inputDelegate)
			: base(inputDelegate)
		{
		}

		public WeakAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> Add(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> delegatesForAdding)
		{
			base.Add(delegatesForAdding);

			return this;
		}

		public WeakAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> Remove(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> delegatesForRemoving)
		{
			base.Add(delegatesForRemoving);

			return this;
		}

		public void Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9)
		{
			ProcessInvoke(new object[] { t1, t2, t3, t4, t5, t6, t7, t8, t9 });
		}

		public void InvokeAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9)
		{
			ProcessInvokeAsync(new object[] { t1, t2, t3, t4, t5, t6, t7, t8, t9 });
		}
	}

	/// <summary>
	/// Encapsulates a weak delegate of the <see cref="Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/>.
	/// </summary>
	public sealed class WeakAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : WeakDelegateBase
	{
		public WeakAction(){}
		public WeakAction(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> inputDelegate)
			: base(inputDelegate)
		{
		}

		public WeakAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Add(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegatesForAdding)
		{
			base.Add(delegatesForAdding);

			return this;
		}

		public WeakAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Remove(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegatesForRemoving)
		{
			base.Add(delegatesForRemoving);

			return this;
		}

		public void Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10)
		{
			ProcessInvoke(new object[] { t1, t2, t3, t4, t5, t6, t7, t8, t9, t10 });
		}

		public void InvokeAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10)
		{
			ProcessInvokeAsync(new object[] { t1, t2, t3, t4, t5, t6, t7, t8, t9, t10 });
		}
	}

	/// <summary>
	/// Encapsulates a weak delegate of the <see cref="Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/>.
	/// </summary>
	public sealed class WeakAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : WeakDelegateBase
	{
		public WeakAction(){}
		public WeakAction(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> inputDelegate)
			: base(inputDelegate)
		{
		}

		public WeakAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Add(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegatesForAdding)
		{
			base.Add(delegatesForAdding);

			return this;
		}

		public WeakAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Remove(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegatesForRemoving)
		{
			base.Add(delegatesForRemoving);

			return this;
		}

		public void Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11)
		{
			ProcessInvoke(new object[] { t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11 });
		}

		public void InvokeAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11)
		{
			ProcessInvokeAsync(new object[] { t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11 });
		}
	}

	/// <summary>
	/// Encapsulates a weak delegate of the <see cref="Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/>.
	/// </summary>
	public sealed class WeakAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : WeakDelegateBase
	{
		public WeakAction(){}
		public WeakAction(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> inputDelegate)
			: base(inputDelegate)
		{
		}

		public WeakAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Add(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegatesForAdding)
		{
			base.Add(delegatesForAdding);

			return this;
		}

		public WeakAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Remove(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegatesForRemoving)
		{
			base.Add(delegatesForRemoving);

			return this;
		}

		public void Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
		{
			ProcessInvoke(new object[] { t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12 });
		}

		public void InvokeAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
		{
			ProcessInvokeAsync(new object[] { t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12 });
		}
	}

	/// <summary>
	/// Encapsulates a weak delegate of the <see cref="Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/>.
	/// </summary>
	public sealed class WeakAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : WeakDelegateBase
	{
		public WeakAction(){}
		public WeakAction(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> inputDelegate)
			: base(inputDelegate)
		{
		}

		public WeakAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Add(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegatesForAdding)
		{
			base.Add(delegatesForAdding);

			return this;
		}

		public WeakAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Remove(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegatesForRemoving)
		{
			base.Add(delegatesForRemoving);

			return this;
		}

		public void Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
		{
			ProcessInvoke(new object[] { t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13 });
		}

		public void InvokeAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
		{
			ProcessInvokeAsync(new object[] { t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13 });
		}
	}

	/// <summary>
	/// Encapsulates a weak delegate of the <see cref="Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/>.
	/// </summary>
	public sealed class WeakAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : WeakDelegateBase
	{
		public WeakAction(){}
		public WeakAction(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> inputDelegate)
			: base(inputDelegate)
		{
		}

		public WeakAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Add(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegatesForAdding)
		{
			base.Add(delegatesForAdding);

			return this;
		}

		public WeakAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Remove(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegatesForRemoving)
		{
			base.Add(delegatesForRemoving);

			return this;
		}

		public void Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
		{
			ProcessInvoke(new object[] { t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14 });
		}

		public void InvokeAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
		{
			ProcessInvokeAsync(new object[] { t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14 });
		}
	}

	/// <summary>
	/// Encapsulates a weak delegate of the <see cref="Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/>.
	/// </summary>
	public sealed class WeakAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : WeakDelegateBase
	{
		public WeakAction(){}
		public WeakAction(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> inputDelegate)
			: base(inputDelegate)
		{
		}

		public WeakAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Add(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegatesForAdding)
		{
			base.Add(delegatesForAdding);

			return this;
		}

		public WeakAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Remove(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegatesForRemoving)
		{
			base.Add(delegatesForRemoving);

			return this;
		}

		public void Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
		{
			ProcessInvoke(new object[] { t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15 });
		}

		public void InvokeAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
		{
			ProcessInvokeAsync(new object[] { t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15 });
		}
	}

	/// <summary>
	/// Encapsulates a weak delegate of the <see cref="Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"/>.
	/// </summary>
	public sealed class WeakAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> : WeakDelegateBase
	{
		public WeakAction(){}
		public WeakAction(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> inputDelegate)
			: base(inputDelegate)
		{
		}

		public WeakAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Add(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> delegatesForAdding)
		{
			base.Add(delegatesForAdding);

			return this;
		}

		public WeakAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Remove(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> delegatesForRemoving)
		{
			base.Add(delegatesForRemoving);

			return this;
		}

		public void Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16)
		{
			ProcessInvoke(new object[] { t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16 });
		}

		public void InvokeAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16)
		{
			ProcessInvokeAsync(new object[] { t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16 });
		}
	}


}
