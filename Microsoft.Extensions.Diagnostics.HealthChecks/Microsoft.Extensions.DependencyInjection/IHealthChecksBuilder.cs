using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Microsoft.Extensions.DependencyInjection
{
	/// <summary>
	/// A builder used to register health checks.
	/// </summary>
	public interface IHealthChecksBuilder
	{
		/// <summary>
		/// Gets the <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> into which <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck" /> instances should be registered.
		/// </summary>
		IServiceCollection Services
		{
			get;
		}

		/// <summary>
		/// Adds a <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckRegistration" /> for a health check.
		/// </summary>
		/// <param name="registration">The <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckRegistration" />.</param>
		IHealthChecksBuilder Add(HealthCheckRegistration registration);
	}
}
