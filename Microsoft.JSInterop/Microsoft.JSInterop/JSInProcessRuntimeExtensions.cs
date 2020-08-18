namespace Microsoft.JSInterop
{
	/// <summary>
	/// Extensions for <see cref="T:Microsoft.JSInterop.IJSInProcessRuntime" />.
	/// </summary>
	public static class JSInProcessRuntimeExtensions
	{
		/// <summary>
		/// Invokes the specified JavaScript function synchronously.
		/// </summary>
		/// <param name="jsRuntime">The <see cref="T:Microsoft.JSInterop.IJSInProcessRuntime" />.</param>
		/// <param name="identifier">An identifier for the function to invoke. For example, the value <c>"someScope.someFunction"</c> will invoke the function <c>window.someScope.someFunction</c>.</param>
		/// <param name="args">JSON-serializable arguments.</param>
		public static void InvokeVoid(this IJSInProcessRuntime jsRuntime, string identifier, params object[] args)
		{
			throw null;
		}
	}
}
