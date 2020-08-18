namespace Microsoft.AspNetCore.Builder
{
	/// <summary>
	/// Extension methods for the DefaultFilesMiddleware
	/// </summary>
	public static class DefaultFilesExtensions
	{
		/// <summary>
		/// Enables default file mapping on the current path
		/// </summary>
		/// <param name="app"></param>
		/// <returns></returns>
		public static IApplicationBuilder UseDefaultFiles(this IApplicationBuilder app)
		{
			throw null;
		}

		/// <summary>
		/// Enables default file mapping for the given request path
		/// </summary>
		/// <param name="app"></param>
		/// <param name="requestPath">The relative request path.</param>
		/// <returns></returns>
		public static IApplicationBuilder UseDefaultFiles(this IApplicationBuilder app, string requestPath)
		{
			throw null;
		}

		/// <summary>
		/// Enables default file mapping with the given options
		/// </summary>
		/// <param name="app"></param>
		/// <param name="options"></param>
		/// <returns></returns>
		public static IApplicationBuilder UseDefaultFiles(this IApplicationBuilder app, DefaultFilesOptions options)
		{
			throw null;
		}
	}
}
