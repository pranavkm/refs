namespace Microsoft.AspNetCore.Builder
{
	/// <summary>
	/// Extension methods that combine all of the static file middleware components:
	/// Default files, directory browsing, send file, and static files
	/// </summary>
	public static class FileServerExtensions
	{
		/// <summary>
		/// Enable all static file middleware (except directory browsing) for the current request path in the current directory.
		/// </summary>
		/// <param name="app"></param>
		/// <returns></returns>
		public static IApplicationBuilder UseFileServer(this IApplicationBuilder app)
		{
			throw null;
		}

		/// <summary>
		/// Enable all static file middleware on for the current request path in the current directory.
		/// </summary>
		/// <param name="app"></param>
		/// <param name="enableDirectoryBrowsing">Should directory browsing be enabled?</param>
		/// <returns></returns>
		public static IApplicationBuilder UseFileServer(this IApplicationBuilder app, bool enableDirectoryBrowsing)
		{
			throw null;
		}

		/// <summary>
		/// Enables all static file middleware (except directory browsing) for the given request path from the directory of the same name
		/// </summary>
		/// <param name="app"></param>
		/// <param name="requestPath">The relative request path.</param>
		/// <returns></returns>
		public static IApplicationBuilder UseFileServer(this IApplicationBuilder app, string requestPath)
		{
			throw null;
		}

		/// <summary>
		/// Enable all static file middleware with the given options
		/// </summary>
		/// <param name="app"></param>
		/// <param name="options"></param>
		/// <returns></returns>
		public static IApplicationBuilder UseFileServer(this IApplicationBuilder app, FileServerOptions options)
		{
			throw null;
		}
	}
}
