using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.JSInterop
{
	/// <summary>
	/// Extensions for <see cref="T:Microsoft.JSInterop.IJSRuntime" />.
	/// </summary>
	public static class JSRuntimeExtensions
	{
		/// <summary>
		/// Invokes the specified JavaScript function asynchronously.
		/// </summary>
		/// <param name="jsRuntime">The <see cref="T:Microsoft.JSInterop.IJSRuntime" />.</param>
		/// <param name="identifier">An identifier for the function to invoke. For example, the value <c>"someScope.someFunction"</c> will invoke the function <c>window.someScope.someFunction</c>.</param>
		/// <param name="args">JSON-serializable arguments.</param>
		/// <returns>A <see cref="T:System.Threading.Tasks.ValueTask" /> that represents the asynchronous invocation operation.</returns>
		[AsyncStateMachine(typeof(_003CInvokeVoidAsync_003Ed__0))]
		[DebuggerStepThrough]
		public static ValueTask InvokeVoidAsync(this IJSRuntime jsRuntime, string identifier, params object[] args)
		{
			throw null;
		}

		/// <summary>
		/// Invokes the specified JavaScript function asynchronously.
		/// <para>
		/// <see cref="T:Microsoft.JSInterop.JSRuntime" /> will apply timeouts to this operation based on the value configured in <see cref="P:Microsoft.JSInterop.JSRuntime.DefaultAsyncTimeout" />. To dispatch a call with a different timeout, or no timeout,
		/// consider using <see cref="M:Microsoft.JSInterop.IJSRuntime.InvokeAsync``1(System.String,System.Threading.CancellationToken,System.Object[])" />.
		/// </para>
		/// </summary>
		/// <param name="jsRuntime">The <see cref="T:Microsoft.JSInterop.IJSRuntime" />.</param>
		/// <typeparam name="TValue">The JSON-serializable return type.</typeparam>
		/// <param name="identifier">An identifier for the function to invoke. For example, the value <c>"someScope.someFunction"</c> will invoke the function <c>window.someScope.someFunction</c>.</param>
		/// <param name="args">JSON-serializable arguments.</param>
		/// <returns>An instance of <typeparamref name="TValue" /> obtained by JSON-deserializing the return value.</returns>
		public static ValueTask<TValue> InvokeAsync<TValue>(this IJSRuntime jsRuntime, string identifier, params object[] args)
		{
			throw null;
		}

		/// <summary>
		/// Invokes the specified JavaScript function asynchronously.
		/// </summary>
		/// <typeparam name="TValue">The JSON-serializable return type.</typeparam>
		/// <param name="jsRuntime">The <see cref="T:Microsoft.JSInterop.IJSRuntime" />.</param>
		/// <param name="identifier">An identifier for the function to invoke. For example, the value <c>"someScope.someFunction"</c> will invoke the function <c>window.someScope.someFunction</c>.</param>
		/// <param name="cancellationToken">
		/// A cancellation token to signal the cancellation of the operation. Specifying this parameter will override any default cancellations such as due to timeouts
		/// (<see cref="P:Microsoft.JSInterop.JSRuntime.DefaultAsyncTimeout" />) from being applied.
		/// </param>
		/// <param name="args">JSON-serializable arguments.</param>
		/// <returns>An instance of <typeparamref name="TValue" /> obtained by JSON-deserializing the return value.</returns>
		public static ValueTask<TValue> InvokeAsync<TValue>(this IJSRuntime jsRuntime, string identifier, CancellationToken cancellationToken, params object[] args)
		{
			throw null;
		}

		/// <summary>
		/// Invokes the specified JavaScript function asynchronously.
		/// </summary>
		/// <param name="jsRuntime">The <see cref="T:Microsoft.JSInterop.IJSRuntime" />.</param>
		/// <param name="identifier">An identifier for the function to invoke. For example, the value <c>"someScope.someFunction"</c> will invoke the function <c>window.someScope.someFunction</c>.</param>
		/// <param name="cancellationToken">
		/// A cancellation token to signal the cancellation of the operation. Specifying this parameter will override any default cancellations such as due to timeouts
		/// (<see cref="P:Microsoft.JSInterop.JSRuntime.DefaultAsyncTimeout" />) from being applied.
		/// </param>
		/// <param name="args">JSON-serializable arguments.</param>
		/// <returns>A <see cref="T:System.Threading.Tasks.ValueTask" /> that represents the asynchronous invocation operation.</returns>
		[AsyncStateMachine(typeof(_003CInvokeVoidAsync_003Ed__3))]
		[DebuggerStepThrough]
		public static ValueTask InvokeVoidAsync(this IJSRuntime jsRuntime, string identifier, CancellationToken cancellationToken, params object[] args)
		{
			throw null;
		}

		/// <summary>
		/// Invokes the specified JavaScript function asynchronously.
		/// </summary>
		/// <param name="jsRuntime">The <see cref="T:Microsoft.JSInterop.IJSRuntime" />.</param>
		/// <param name="identifier">An identifier for the function to invoke. For example, the value <c>"someScope.someFunction"</c> will invoke the function <c>window.someScope.someFunction</c>.</param>
		/// <param name="timeout">The duration after which to cancel the async operation. Overrides default timeouts (<see cref="P:Microsoft.JSInterop.JSRuntime.DefaultAsyncTimeout" />).</param>
		/// <param name="args">JSON-serializable arguments.</param>
		/// <returns>A <see cref="T:System.Threading.Tasks.ValueTask" /> that represents the asynchronous invocation operation.</returns>
		[AsyncStateMachine(typeof(_003CInvokeAsync_003Ed__4<>))]
		[DebuggerStepThrough]
		public static ValueTask<TValue> InvokeAsync<TValue>(this IJSRuntime jsRuntime, string identifier, TimeSpan timeout, params object[] args)
		{
			throw null;
		}

		/// <summary>
		/// Invokes the specified JavaScript function asynchronously.
		/// </summary>
		/// <param name="jsRuntime">The <see cref="T:Microsoft.JSInterop.IJSRuntime" />.</param>
		/// <param name="identifier">An identifier for the function to invoke. For example, the value <c>"someScope.someFunction"</c> will invoke the function <c>window.someScope.someFunction</c>.</param>
		/// <param name="timeout">The duration after which to cancel the async operation. Overrides default timeouts (<see cref="P:Microsoft.JSInterop.JSRuntime.DefaultAsyncTimeout" />).</param>
		/// <param name="args">JSON-serializable arguments.</param>
		/// <returns>A <see cref="T:System.Threading.Tasks.ValueTask" /> that represents the asynchronous invocation operation.</returns>
		[AsyncStateMachine(typeof(_003CInvokeVoidAsync_003Ed__5))]
		[DebuggerStepThrough]
		public static ValueTask InvokeVoidAsync(this IJSRuntime jsRuntime, string identifier, TimeSpan timeout, params object[] args)
		{
			throw null;
		}
	}
}
