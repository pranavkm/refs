namespace Microsoft.AspNetCore.Builder
{
	/// <summary>
	/// Extension methods for adding the <see cref="T:Microsoft.AspNetCore.Session.SessionMiddleware" /> to an application.
	/// </summary>
	public static class SessionMiddlewareExtensions
	{
		/// <summary>
		/// Adds the <see cref="T:Microsoft.AspNetCore.Session.SessionMiddleware" /> to automatically enable session state for the application.
		/// </summary>
		/// <param name="app">The <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" />.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" />.</returns>
		public static IApplicationBuilder UseSession(this IApplicationBuilder app)
		{
			throw null;
		}

		/// <summary>
		/// Adds the <see cref="T:Microsoft.AspNetCore.Session.SessionMiddleware" /> to automatically enable session state for the application.
		/// </summary>
		/// <param name="app">The <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" />.</param>
		/// <param name="options">The <see cref="T:Microsoft.AspNetCore.Builder.SessionOptions" />.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" />.</returns>
		public static IApplicationBuilder UseSession(this IApplicationBuilder app, SessionOptions options)
		{
			throw null;
		}
	}
}
