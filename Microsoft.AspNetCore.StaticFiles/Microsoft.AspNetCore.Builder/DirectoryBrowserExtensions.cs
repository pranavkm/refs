namespace Microsoft.AspNetCore.Builder
{
	/// <summary>
	/// Extension methods for the DirectoryBrowserMiddleware
	/// </summary>
	public static class DirectoryBrowserExtensions
	{
		/// <summary>
		/// Enable directory browsing on the current path
		/// </summary>
		/// <param name="app"></param>
		/// <returns></returns>
		public static IApplicationBuilder UseDirectoryBrowser(this IApplicationBuilder app)
		{
			throw null;
		}

		/// <summary>
		/// Enables directory browsing for the given request path
		/// </summary>
		/// <param name="app"></param>
		/// <param name="requestPath">The relative request path.</param>
		/// <returns></returns>
		public static IApplicationBuilder UseDirectoryBrowser(this IApplicationBuilder app, string requestPath)
		{
			throw null;
		}

		/// <summary>
		/// Enable directory browsing with the given options
		/// </summary>
		/// <param name="app"></param>
		/// <param name="options"></param>
		/// <returns></returns>
		public static IApplicationBuilder UseDirectoryBrowser(this IApplicationBuilder app, DirectoryBrowserOptions options)
		{
			throw null;
		}
	}
}
