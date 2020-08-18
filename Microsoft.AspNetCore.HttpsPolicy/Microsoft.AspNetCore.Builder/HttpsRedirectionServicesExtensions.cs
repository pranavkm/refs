using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Microsoft.AspNetCore.Builder
{
	/// <summary>
	/// Extension methods for the HttpsRedirection middleware.
	/// </summary>
	public static class HttpsRedirectionServicesExtensions
	{
		/// <summary>
		/// Adds HTTPS redirection services.
		/// </summary>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> for adding services.</param>
		/// <param name="configureOptions">A delegate to configure the <see cref="T:Microsoft.AspNetCore.HttpsPolicy.HttpsRedirectionOptions" />.</param>
		/// <returns></returns>
		public static IServiceCollection AddHttpsRedirection(this IServiceCollection services, Action<HttpsRedirectionOptions> configureOptions)
		{
			throw null;
		}
	}
}
