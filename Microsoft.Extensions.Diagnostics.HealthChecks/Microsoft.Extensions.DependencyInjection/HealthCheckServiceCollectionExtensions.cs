namespace Microsoft.Extensions.DependencyInjection
{
	/// <summary>
	/// Provides extension methods for registering <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckService" /> in an <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.
	/// </summary>
	public static class HealthCheckServiceCollectionExtensions
	{
		/// <summary>
		/// Adds the <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckService" /> to the container, using the provided delegate to register
		/// health checks.
		/// </summary>
		/// <remarks>
		/// This operation is idempotent - multiple invocations will still only result in a single
		/// <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckService" /> instance in the <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />. It can be invoked
		/// multiple times in order to get access to the <see cref="T:Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder" /> in multiple places.
		/// </remarks>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> to add the <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckService" /> to.</param>
		/// <returns>An instance of <see cref="T:Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder" /> from which health checks can be registered.</returns>
		public static IHealthChecksBuilder AddHealthChecks(this IServiceCollection services)
		{
			throw null;
		}
	}
}
