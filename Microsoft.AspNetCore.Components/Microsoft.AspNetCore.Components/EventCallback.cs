using System;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Components
{
	/// <summary>
	/// A bound event handler delegate.
	/// </summary>
	public readonly struct EventCallback : IEventCallback
	{
		/// <summary>
		/// Gets a reference to the <see cref="T:Microsoft.AspNetCore.Components.EventCallbackFactory" />.
		/// </summary>
		public static readonly EventCallbackFactory Factory;

		/// <summary>
		/// Gets an empty <see cref="T:Microsoft.AspNetCore.Components.EventCallback" />.
		/// </summary>
		public static readonly EventCallback Empty;

		internal readonly MulticastDelegate? Delegate;

		internal readonly IHandleEvent? Receiver;

		/// <summary>
		/// Gets a value that indicates whether the delegate associated with this event dispatcher is non-null.
		/// </summary>
		public bool HasDelegate
		{
			get
			{
				throw null;
			}
		}

		internal bool RequiresExplicitReceiver
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates the new <see cref="T:Microsoft.AspNetCore.Components.EventCallback" />.
		/// </summary>
		/// <param name="receiver">The event receiver.</param>
		/// <param name="delegate">The delegate to bind.</param>
		public EventCallback(IHandleEvent? receiver, MulticastDelegate? @delegate)
		{
			throw null;
		}

		/// <summary>
		/// Invokes the delegate associated with this binding and dispatches an event notification to the
		/// appropriate component.
		/// </summary>
		/// <param name="arg">The argument.</param>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task" /> which completes asynchronously once event processing has completed.</returns>
		public Task InvokeAsync(object arg)
		{
			throw null;
		}

		/// <summary>
		/// Invokes the delegate associated with this binding and dispatches an event notification to the
		/// appropriate component.
		/// </summary>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task" /> which completes asynchronously once event processing has completed.</returns>
		public Task InvokeAsync()
		{
			throw null;
		}

		object? IEventCallback.UnpackForRenderTree()
		{
			throw null;
		}
	}
	/// <summary>
	/// A bound event handler delegate.
	/// </summary>
	public readonly struct EventCallback<TValue> : IEventCallback
	{
		/// <summary>
		/// Gets an empty <see cref="T:Microsoft.AspNetCore.Components.EventCallback`1" />.
		/// </summary>
		public static readonly EventCallback<TValue> Empty;

		internal readonly MulticastDelegate? Delegate;

		internal readonly IHandleEvent? Receiver;

		/// <summary>
		/// Gets a value that indicates whether the delegate associated with this event dispatcher is non-null.
		/// </summary>
		public bool HasDelegate
		{
			get
			{
				throw null;
			}
		}

		internal bool RequiresExplicitReceiver
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates the new <see cref="T:Microsoft.AspNetCore.Components.EventCallback`1" />.
		/// </summary>
		/// <param name="receiver">The event receiver.</param>
		/// <param name="delegate">The delegate to bind.</param>
		public EventCallback(IHandleEvent? receiver, MulticastDelegate? @delegate)
		{
			throw null;
		}

		/// <summary>
		/// Invokes the delegate associated with this binding and dispatches an event notification to the
		/// appropriate component.
		/// </summary>
		/// <param name="arg">The argument.</param>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task" /> which completes asynchronously once event processing has completed.</returns>
		public Task InvokeAsync(TValue arg)
		{
			throw null;
		}

		/// <summary>
		/// Invokes the delegate associated with this binding and dispatches an event notification to the
		/// appropriate component.
		/// </summary>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task" /> which completes asynchronously once event processing has completed.</returns>
		public Task InvokeAsync()
		{
			throw null;
		}

		internal EventCallback AsUntyped()
		{
			throw null;
		}

		object? IEventCallback.UnpackForRenderTree()
		{
			throw null;
		}
	}
}
