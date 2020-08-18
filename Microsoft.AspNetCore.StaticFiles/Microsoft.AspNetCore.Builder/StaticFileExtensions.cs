namespace Microsoft.AspNetCore.Builder
{
	/// <summary>
	/// Extension methods for the StaticFileMiddleware
	/// </summary>
	public static class StaticFileExtensions
	{
		/// <summary>
		/// Enables static file serving for the current request path
		/// </summary>
		/// <param name="app"></param>
		/// <returns></returns>
		public static IApplicationBuilder UseStaticFiles(this IApplicationBuilder app)
		{
			throw null;
		}

		/// <summary>
		/// Enables static file serving for the given request path
		/// </summary>
		/// <param name="app"></param>
		/// <param name="requestPath">The relative request path.</param>
		/// <returns></returns>
		public static IApplicationBuilder UseStaticFiles(this IApplicationBuilder app, string requestPath)
		{
			throw null;
		}

		/// <summary>
		/// Enables static file serving with the given options
		/// </summary>
		/// <param name="app"></param>
		/// <param name="options"></param>
		/// <returns></returns>
		public static IApplicationBuilder UseStaticFiles(this IApplicationBuilder app, StaticFileOptions options)
		{
			throw null;
		}
	}
}
