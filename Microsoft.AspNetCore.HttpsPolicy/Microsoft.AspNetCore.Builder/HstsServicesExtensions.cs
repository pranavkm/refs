using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Microsoft.AspNetCore.Builder
{
	/// <summary>
	/// Extension methods for the HSTS middleware.
	/// </summary>
	public static class HstsServicesExtensions
	{
		/// <summary>
		/// Adds HSTS services.
		/// </summary>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> for adding services.</param>
		/// <param name="configureOptions">A delegate to configure the <see cref="T:Microsoft.AspNetCore.HttpsPolicy.HstsOptions" />.</param>
		/// <returns></returns>
		public static IServiceCollection AddHsts(this IServiceCollection services, Action<HstsOptions> configureOptions)
		{
			throw null;
		}
	}
}
