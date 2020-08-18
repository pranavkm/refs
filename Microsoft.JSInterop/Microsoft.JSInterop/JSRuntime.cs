using Microsoft.JSInterop.Infrastructure;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.JSInterop
{
	/// <summary>
	/// Abstract base class for a JavaScript runtime.
	/// </summary>
	public abstract class JSRuntime : IJSRuntime
	{
		/// <summary>
		/// Gets the <see cref="T:System.Text.Json.JsonSerializerOptions" /> used to serialize and deserialize interop payloads.
		/// </summary>
		protected internal JsonSerializerOptions JsonSerializerOptions
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets the default timeout for asynchronous JavaScript calls.
		/// </summary>
		protected TimeSpan? DefaultAsyncTimeout
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Initializes a new instance of <see cref="T:Microsoft.JSInterop.JSRuntime" />.
		/// </summary>
		protected JSRuntime()
		{
			throw null;
		}

		/// <summary>
		/// Invokes the specified JavaScript function asynchronously.
		/// <para>
		/// <see cref="T:Microsoft.JSInterop.JSRuntime" /> will apply timeouts to this operation based on the value configured in <see cref="P:Microsoft.JSInterop.JSRuntime.DefaultAsyncTimeout" />. To dispatch a call with a different, or no timeout,
		/// consider using <see cref="M:Microsoft.JSInterop.JSRuntime.InvokeAsync``1(System.String,System.Threading.CancellationToken,System.Object[])" />.
		/// </para>
		/// </summary>
		/// <typeparam name="TValue">The JSON-serializable return type.</typeparam>
		/// <param name="identifier">An identifier for the function to invoke. For example, the value <c>"someScope.someFunction"</c> will invoke the function <c>window.someScope.someFunction</c>.</param>
		/// <param name="args">JSON-serializable arguments.</param>
		/// <returns>An instance of <typeparamref name="TValue" /> obtained by JSON-deserializing the return value.</returns>
		[AsyncStateMachine(typeof(_003CInvokeAsync_003Ed__13<>))]
		[DebuggerStepThrough]
		public ValueTask<TValue> InvokeAsync<TValue>(string identifier, object[] args)
		{
			throw null;
		}

		/// <summary>
		/// Invokes the specified JavaScript function asynchronously.
		/// </summary>
		/// <typeparam name="TValue">The JSON-serializable return type.</typeparam>
		/// <param name="identifier">An identifier for the function to invoke. For example, the value <c>"someScope.someFunction"</c> will invoke the function <c>window.someScope.someFunction</c>.</param>
		/// <param name="cancellationToken">
		/// A cancellation token to signal the cancellation of the operation. Specifying this parameter will override any default cancellations such as due to timeouts
		/// (<see cref="P:Microsoft.JSInterop.JSRuntime.DefaultAsyncTimeout" />) from being applied.
		/// </param>
		/// <param name="args">JSON-serializable arguments.</param>
		/// <returns>An instance of <typeparamref name="TValue" /> obtained by JSON-deserializing the return value.</returns>
		public ValueTask<TValue> InvokeAsync<TValue>(string identifier, CancellationToken cancellationToken, object[] args)
		{
			throw null;
		}

		/// <summary>
		/// Begins an asynchronous function invocation.
		/// </summary>
		/// <param name="taskId">The identifier for the function invocation, or zero if no async callback is required.</param>
		/// <param name="identifier">The identifier for the function to invoke.</param>
		/// <param name="argsJson">A JSON representation of the arguments.</param>
		protected abstract void BeginInvokeJS(long taskId, string identifier, string? argsJson);

		/// <summary>
		/// Completes an async JS interop call from JavaScript to .NET
		/// </summary>
		/// <param name="invocationInfo">The <see cref="T:Microsoft.JSInterop.Infrastructure.DotNetInvocationInfo" />.</param>
		/// <param name="invocationResult">The <see cref="T:Microsoft.JSInterop.Infrastructure.DotNetInvocationResult" />.</param>
		protected internal abstract void EndInvokeDotNet(DotNetInvocationInfo invocationInfo, in DotNetInvocationResult invocationResult);

		internal void EndInvokeJS(long taskId, bool succeeded, ref Utf8JsonReader jsonReader)
		{
			throw null;
		}

		internal long TrackObjectReference<TValue>(DotNetObjectReference<TValue> dotNetObjectReference) where TValue : class
		{
			throw null;
		}

		internal IDotNetObjectReference GetObjectReference(long dotNetObjectId)
		{
			throw null;
		}

		/// <summary>
		/// Stops tracking the specified .NET object reference.
		/// This may be invoked either by disposing a DotNetObjectRef in .NET code, or via JS interop by calling "dispose" on the corresponding instance in JavaScript code
		/// </summary>
		/// <param name="dotNetObjectId">The ID of the <see cref="T:Microsoft.JSInterop.DotNetObjectReference`1" />.</param>
		internal void ReleaseObjectReference(long dotNetObjectId)
		{
			throw null;
		}
	}
}
