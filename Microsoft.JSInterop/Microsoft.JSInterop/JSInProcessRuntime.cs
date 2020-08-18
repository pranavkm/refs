using System.Diagnostics.CodeAnalysis;

namespace Microsoft.JSInterop
{
	/// <summary>
	/// Abstract base class for an in-process JavaScript runtime.
	/// </summary>
	public abstract class JSInProcessRuntime : JSRuntime, IJSInProcessRuntime, IJSRuntime
	{
		/// <summary>
		/// Invokes the specified JavaScript function synchronously.
		/// </summary>
		/// <typeparam name="TValue">The JSON-serializable return type.</typeparam>
		/// <param name="identifier">An identifier for the function to invoke. For example, the value <c>"someScope.someFunction"</c> will invoke the function <c>window.someScope.someFunction</c>.</param>
		/// <param name="args">JSON-serializable arguments.</param>
		/// <returns>An instance of <typeparamref name="TValue" /> obtained by JSON-deserializing the return value.</returns>
		[return: MaybeNull]
		public TValue Invoke<TValue>(string identifier, params object[] args)
		{
			throw null;
		}

		/// <summary>
		/// Performs a synchronous function invocation.
		/// </summary>
		/// <param name="identifier">The identifier for the function to invoke.</param>
		/// <param name="argsJson">A JSON representation of the arguments.</param>
		/// <returns>A JSON representation of the result.</returns>
		protected abstract string? InvokeJS(string identifier, string? argsJson);

		protected JSInProcessRuntime()
		{
			throw null;
		}
	}
}
