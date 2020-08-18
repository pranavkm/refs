namespace Microsoft.AspNetCore.Builder
{
	/// <summary>
	/// <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" /> extension methods to add and configure <see cref="T:Microsoft.AspNetCore.WebSockets.WebSocketMiddleware" />.
	/// </summary>
	public static class WebSocketMiddlewareExtensions
	{
		/// <summary>
		/// Adds the <see cref="T:Microsoft.AspNetCore.WebSockets.WebSocketMiddleware" /> to the request pipeline.
		/// </summary>
		/// <param name="app">
		/// The <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" /> to configure.
		/// </param>
		/// <returns>
		/// The <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" />.
		/// </returns>
		public static IApplicationBuilder UseWebSockets(this IApplicationBuilder app)
		{
			throw null;
		}

		/// <summary>
		/// Adds the <see cref="T:Microsoft.AspNetCore.WebSockets.WebSocketMiddleware" /> to the request pipeline.
		/// </summary>
		/// <param name="app">
		/// The <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" /> to configure.
		/// </param>
		/// <param name="options">
		/// The <see cref="T:Microsoft.AspNetCore.Builder.WebSocketOptions" /> to be used for the <see cref="T:Microsoft.AspNetCore.WebSockets.WebSocketMiddleware" />.
		/// </param>
		/// <returns>
		/// The <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" />.
		/// </returns>
		public static IApplicationBuilder UseWebSockets(this IApplicationBuilder app, WebSocketOptions options)
		{
			throw null;
		}
	}
}
