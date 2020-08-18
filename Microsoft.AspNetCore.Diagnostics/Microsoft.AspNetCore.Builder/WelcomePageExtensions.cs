using Microsoft.AspNetCore.Http;

namespace Microsoft.AspNetCore.Builder
{
	/// <summary>
	/// IApplicationBuilder extensions for the WelcomePageMiddleware.
	/// </summary>
	public static class WelcomePageExtensions
	{
		/// <summary>
		/// Adds the WelcomePageMiddleware to the pipeline with the given options.
		/// </summary>
		/// <param name="app"></param>
		/// <param name="options"></param>
		/// <returns></returns>
		public static IApplicationBuilder UseWelcomePage(this IApplicationBuilder app, WelcomePageOptions options)
		{
			throw null;
		}

		/// <summary>
		/// Adds the WelcomePageMiddleware to the pipeline with the given path.
		/// </summary>
		/// <param name="app"></param>
		/// <param name="path"></param>
		/// <returns></returns>
		public static IApplicationBuilder UseWelcomePage(this IApplicationBuilder app, PathString path)
		{
			throw null;
		}

		/// <summary>
		/// Adds the WelcomePageMiddleware to the pipeline with the given path.
		/// </summary>
		/// <param name="app"></param>
		/// <param name="path"></param>
		/// <returns></returns>
		public static IApplicationBuilder UseWelcomePage(this IApplicationBuilder app, string path)
		{
			throw null;
		}

		/// <summary>
		/// Adds the WelcomePageMiddleware to the pipeline.
		/// </summary>
		/// <param name="app"></param>
		/// <returns></returns>
		public static IApplicationBuilder UseWelcomePage(this IApplicationBuilder app)
		{
			throw null;
		}
	}
}
