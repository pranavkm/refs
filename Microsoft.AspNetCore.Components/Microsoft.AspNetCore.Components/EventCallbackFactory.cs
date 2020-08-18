using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Components
{
	/// <summary>
	/// A factory for creating <see cref="T:Microsoft.AspNetCore.Components.EventCallback" /> and <see cref="T:Microsoft.AspNetCore.Components.EventCallback`1" />
	/// instances.
	/// </summary>
	public sealed class EventCallbackFactory
	{
		/// <summary>
		/// Returns the provided <paramref name="callback" />. For internal framework use only.
		/// </summary>
		/// <param name="receiver"></param>
		/// <param name="callback"></param>
		/// <returns></returns>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public EventCallback Create(object receiver, EventCallback callback)
		{
			throw null;
		}

		/// <summary>
		/// Creates an <see cref="T:Microsoft.AspNetCore.Components.EventCallback" /> for the provided <paramref name="receiver" /> and
		/// <paramref name="callback" />.
		/// </summary>
		/// <param name="receiver">The event receiver.</param>
		/// <param name="callback">The event callback.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Components.EventCallback" />.</returns>
		public EventCallback Create(object receiver, Action callback)
		{
			throw null;
		}

		/// <summary>
		/// Creates an <see cref="T:Microsoft.AspNetCore.Components.EventCallback" /> for the provided <paramref name="receiver" /> and
		/// <paramref name="callback" />.
		/// </summary>
		/// <param name="receiver">The event receiver.</param>
		/// <param name="callback">The event callback.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Components.EventCallback" />.</returns>
		public EventCallback Create(object receiver, Action<object> callback)
		{
			throw null;
		}

		/// <summary>
		/// Creates an <see cref="T:Microsoft.AspNetCore.Components.EventCallback" /> for the provided <paramref name="receiver" /> and
		/// <paramref name="callback" />.
		/// </summary>
		/// <param name="receiver">The event receiver.</param>
		/// <param name="callback">The event callback.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Components.EventCallback" />.</returns>
		public EventCallback Create(object receiver, Func<Task> callback)
		{
			throw null;
		}

		/// <summary>
		/// Creates an <see cref="T:Microsoft.AspNetCore.Components.EventCallback" /> for the provided <paramref name="receiver" /> and
		/// <paramref name="callback" />.
		/// </summary>
		/// <param name="receiver">The event receiver.</param>
		/// <param name="callback">The event callback.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Components.EventCallback" />.</returns>
		public EventCallback Create(object receiver, Func<object, Task> callback)
		{
			throw null;
		}

		/// <summary>
		/// Returns the provided <paramref name="callback" />. For internal framework use only.
		/// </summary>
		/// <param name="receiver"></param>
		/// <param name="callback"></param>
		/// <returns></returns>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public EventCallback<TValue> Create<TValue>(object receiver, EventCallback callback)
		{
			throw null;
		}

		/// <summary>
		/// Returns the provided <paramref name="callback" />. For internal framework use only.
		/// </summary>
		/// <param name="receiver"></param>
		/// <param name="callback"></param>
		/// <returns></returns>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public EventCallback<TValue> Create<TValue>(object receiver, EventCallback<TValue> callback)
		{
			throw null;
		}

		/// <summary>
		/// Creates an <see cref="T:Microsoft.AspNetCore.Components.EventCallback" /> for the provided <paramref name="receiver" /> and
		/// <paramref name="callback" />.
		/// </summary>
		/// <param name="receiver">The event receiver.</param>
		/// <param name="callback">The event callback.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Components.EventCallback" />.</returns>
		public EventCallback<TValue> Create<TValue>(object receiver, Action callback)
		{
			throw null;
		}

		/// <summary>
		/// Creates an <see cref="T:Microsoft.AspNetCore.Components.EventCallback" /> for the provided <paramref name="receiver" /> and
		/// <paramref name="callback" />.
		/// </summary>
		/// <param name="receiver">The event receiver.</param>
		/// <param name="callback">The event callback.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Components.EventCallback" />.</returns>
		public EventCallback<TValue> Create<TValue>(object receiver, Action<TValue> callback)
		{
			throw null;
		}

		/// <summary>
		/// Creates an <see cref="T:Microsoft.AspNetCore.Components.EventCallback" /> for the provided <paramref name="receiver" /> and
		/// <paramref name="callback" />.
		/// </summary>
		/// <param name="receiver">The event receiver.</param>
		/// <param name="callback">The event callback.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Components.EventCallback" />.</returns>
		public EventCallback<TValue> Create<TValue>(object receiver, Func<Task> callback)
		{
			throw null;
		}

		/// <summary>
		/// Creates an <see cref="T:Microsoft.AspNetCore.Components.EventCallback" /> for the provided <paramref name="receiver" /> and
		/// <paramref name="callback" />.
		/// </summary>
		/// <param name="receiver">The event receiver.</param>
		/// <param name="callback">The event callback.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Components.EventCallback" />.</returns>
		public EventCallback<TValue> Create<TValue>(object receiver, Func<TValue, Task> callback)
		{
			throw null;
		}

		/// <summary>
		/// Creates an <see cref="T:Microsoft.AspNetCore.Components.EventCallback" /> for the provided <paramref name="receiver" /> and
		/// <paramref name="callback" />. For internal framework use only.
		/// </summary>
		/// <param name="receiver"></param>
		/// <param name="callback"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public EventCallback<TValue> CreateInferred<TValue>(object receiver, Action<TValue> callback, TValue value)
		{
			throw null;
		}

		/// <summary>
		/// Creates an <see cref="T:Microsoft.AspNetCore.Components.EventCallback" /> for the provided <paramref name="receiver" /> and
		/// <paramref name="callback" />. For internal framework use only.
		/// </summary>
		/// <param name="receiver"></param>
		/// <param name="callback"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public EventCallback<TValue> CreateInferred<TValue>(object receiver, Func<TValue, Task> callback, TValue value)
		{
			throw null;
		}

		public EventCallbackFactory()
		{
			throw null;
		}
	}
}
