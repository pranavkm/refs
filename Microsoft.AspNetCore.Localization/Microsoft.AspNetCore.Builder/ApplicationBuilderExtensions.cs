using System;

namespace Microsoft.AspNetCore.Builder
{
	/// <summary>
	/// Extension methods for adding the <see cref="T:Microsoft.AspNetCore.Localization.RequestLocalizationMiddleware" /> to an application.
	/// </summary>
	public static class ApplicationBuilderExtensions
	{
		/// <summary>
		/// Adds the <see cref="T:Microsoft.AspNetCore.Localization.RequestLocalizationMiddleware" /> to automatically set culture information for
		/// requests based on information provided by the client.
		/// </summary>
		/// <param name="app">The <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" />.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" />.</returns>
		public static IApplicationBuilder UseRequestLocalization(this IApplicationBuilder app)
		{
			throw null;
		}

		/// <summary>
		/// Adds the <see cref="T:Microsoft.AspNetCore.Localization.RequestLocalizationMiddleware" /> to automatically set culture information for
		/// requests based on information provided by the client.
		/// </summary>
		/// <param name="app">The <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" />.</param>
		/// <param name="options">The <see cref="T:Microsoft.AspNetCore.Builder.RequestLocalizationOptions" /> to configure the middleware with.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" />.</returns>
		public static IApplicationBuilder UseRequestLocalization(this IApplicationBuilder app, RequestLocalizationOptions options)
		{
			throw null;
		}

		/// <summary>
		/// Adds the <see cref="T:Microsoft.AspNetCore.Localization.RequestLocalizationMiddleware" /> to automatically set culture information for
		/// requests based on information provided by the client. 
		/// </summary>
		/// <param name="app">The <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" />.</param>
		/// <param name="optionsAction"></param>
		/// <remarks>
		/// This will going to instantiate a new <see cref="T:Microsoft.AspNetCore.Builder.RequestLocalizationOptions" /> that doesn't come from the services.
		/// </remarks>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" />.</returns>
		public static IApplicationBuilder UseRequestLocalization(this IApplicationBuilder app, Action<RequestLocalizationOptions> optionsAction)
		{
			throw null;
		}

		/// <summary>
		/// Adds the <see cref="T:Microsoft.AspNetCore.Localization.RequestLocalizationMiddleware" /> to automatically set culture information for
		/// requests based on information provided by the client. 
		/// </summary>
		/// <param name="app">The <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" />.</param>
		/// <param name="cultures">The culture names to be added by the application, which is represents both supported cultures and UI cultures.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" />.</returns>
		/// <remarks>
		/// Note that the first culture is the default culture name.
		/// </remarks>
		public static IApplicationBuilder UseRequestLocalization(this IApplicationBuilder app, params string[] cultures)
		{
			throw null;
		}
	}
}
