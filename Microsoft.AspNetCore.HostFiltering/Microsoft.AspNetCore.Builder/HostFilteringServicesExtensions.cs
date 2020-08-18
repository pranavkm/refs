using Microsoft.AspNetCore.HostFiltering;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Microsoft.AspNetCore.Builder
{
	/// <summary>
	/// Extension methods for the host filtering middleware.
	/// </summary>
	public static class HostFilteringServicesExtensions
	{
		/// <summary>
		/// Adds services and options for the host filtering middleware.
		/// </summary>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> for adding services.</param>
		/// <param name="configureOptions">A delegate to configure the <see cref="T:Microsoft.AspNetCore.HostFiltering.HostFilteringOptions" />.</param>
		/// <returns></returns>
		public static IServiceCollection AddHostFiltering(this IServiceCollection services, Action<HostFilteringOptions> configureOptions)
		{
			throw null;
		}
	}
}
