using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Components
{
	/// <summary>
	/// Wraps a callback delegate associated with an event.
	/// </summary>
	public readonly struct EventCallbackWorkItem
	{
		/// <summary>
		/// An empty <see cref="T:Microsoft.AspNetCore.Components.EventCallbackWorkItem" />.
		/// </summary>
		public static readonly EventCallbackWorkItem Empty;

		private readonly MulticastDelegate? _delegate;

		/// <summary>
		/// Creates a new <see cref="T:Microsoft.AspNetCore.Components.EventCallbackWorkItem" /> with the provided <paramref name="delegate" />.
		/// </summary>
		/// <param name="delegate">The callback delegate.</param>
		[System.Runtime.CompilerServices.NullableContext(2)]
		public EventCallbackWorkItem(MulticastDelegate? @delegate)
		{
			throw null;
		}

		/// <summary>
		/// Invokes the delegate associated with this <see cref="T:Microsoft.AspNetCore.Components.EventCallbackWorkItem" />.
		/// </summary>
		/// <param name="arg">The argument to provide to the delegate. May be <c>null</c>.</param>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task" /> then will complete asynchronously once the delegate has completed.</returns>
		public Task InvokeAsync(object? arg)
		{
			throw null;
		}

		internal static Task InvokeAsync<T>(MulticastDelegate? @delegate, T arg)
		{
			throw null;
		}
	}
}
