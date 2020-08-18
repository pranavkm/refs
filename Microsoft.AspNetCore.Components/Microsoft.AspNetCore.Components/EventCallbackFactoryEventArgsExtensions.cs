using System;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Components
{
	/// <summary>
	/// Provides extension methods for <see cref="T:Microsoft.AspNetCore.Components.EventCallbackFactory" /> and <see cref="T:System.EventArgs" /> types.
	/// </summary>
	public static class EventCallbackFactoryEventArgsExtensions
	{
		/// <summary>
		/// Creates an <see cref="T:Microsoft.AspNetCore.Components.EventCallback" /> for the provided <paramref name="receiver" /> and
		/// <paramref name="callback" />.
		/// </summary>
		/// <param name="factory">The <see cref="T:Microsoft.AspNetCore.Components.EventCallbackFactory" />.</param>
		/// <param name="receiver">The event receiver.</param>
		/// <param name="callback">The event callback.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Components.EventCallback" />.</returns>
		public static EventCallback<EventArgs> Create(this EventCallbackFactory factory, object receiver, Action<EventArgs> callback)
		{
			throw null;
		}

		/// <summary>
		/// Creates an <see cref="T:Microsoft.AspNetCore.Components.EventCallback" /> for the provided <paramref name="receiver" /> and
		/// <paramref name="callback" />.
		/// </summary>
		/// <param name="factory">The <see cref="T:Microsoft.AspNetCore.Components.EventCallbackFactory" />.</param>
		/// <param name="receiver">The event receiver.</param>
		/// <param name="callback">The event callback.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Components.EventCallback" />.</returns>
		public static EventCallback<EventArgs> Create(this EventCallbackFactory factory, object receiver, Func<EventArgs, Task> callback)
		{
			throw null;
		}

		/// <summary>
		/// Creates an <see cref="T:Microsoft.AspNetCore.Components.EventCallback" /> for the provided <paramref name="receiver" /> and
		/// <paramref name="callback" />.
		/// </summary>
		/// <param name="factory">The <see cref="T:Microsoft.AspNetCore.Components.EventCallbackFactory" />.</param>
		/// <param name="receiver">The event receiver.</param>
		/// <param name="callback">The event callback.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Components.EventCallback" />.</returns>
		public static EventCallback<ChangeEventArgs> Create(this EventCallbackFactory factory, object receiver, Action<ChangeEventArgs> callback)
		{
			throw null;
		}

		/// <summary>
		/// Creates an <see cref="T:Microsoft.AspNetCore.Components.EventCallback" /> for the provided <paramref name="receiver" /> and
		/// <paramref name="callback" />.
		/// </summary>
		/// <param name="factory">The <see cref="T:Microsoft.AspNetCore.Components.EventCallbackFactory" />.</param>
		/// <param name="receiver">The event receiver.</param>
		/// <param name="callback">The event callback.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Components.EventCallback" />.</returns>
		public static EventCallback<ChangeEventArgs> Create(this EventCallbackFactory factory, object receiver, Func<ChangeEventArgs, Task> callback)
		{
			throw null;
		}
	}
}
