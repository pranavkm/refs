using Microsoft.AspNetCore.HttpOverrides;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
	/// <summary>
	/// Extension methods for using certificate fowarding.
	/// </summary>
	public static class CertificateForwardingServiceExtensions
	{
		/// <summary>
		/// Adds certificate forwarding to the specified <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.
		/// </summary>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.</param>
		/// <param name="configure">An action delegate to configure the provided <see cref="T:Microsoft.AspNetCore.HttpOverrides.CertificateForwardingOptions" />.</param>
		/// <returns>The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> so that additional calls can be chained.</returns>
		public static IServiceCollection AddCertificateForwarding(this IServiceCollection services, Action<CertificateForwardingOptions> configure)
		{
			throw null;
		}
	}
}
