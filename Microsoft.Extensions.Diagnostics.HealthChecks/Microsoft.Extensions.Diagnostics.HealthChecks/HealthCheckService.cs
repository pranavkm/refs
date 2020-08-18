using System;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Extensions.Diagnostics.HealthChecks
{
	/// <summary>
	/// A service which can be used to check the status of <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck" /> instances 
	/// registered in the application.
	/// </summary>
	/// <remarks>
	/// <para>
	/// The default implementation of <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckService" /> is registered in the dependency
	/// injection container as a singleton service by calling 
	/// <see cref="M:Microsoft.Extensions.DependencyInjection.HealthCheckServiceCollectionExtensions.AddHealthChecks(Microsoft.Extensions.DependencyInjection.IServiceCollection)" />.
	/// </para>
	/// <para>
	/// The <see cref="T:Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder" /> returned by 
	/// <see cref="M:Microsoft.Extensions.DependencyInjection.HealthCheckServiceCollectionExtensions.AddHealthChecks(Microsoft.Extensions.DependencyInjection.IServiceCollection)" />
	/// provides a convenience API for registering health checks.
	/// </para>
	/// <para>
	/// <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck" /> implementations can be registered through extension methods provided by
	/// <see cref="T:Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder" />.
	/// </para>
	/// </remarks>
	public abstract class HealthCheckService
	{
		/// <summary>
		/// Runs all the health checks in the application and returns the aggregated status.
		/// </summary>
		/// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> which can be used to cancel the health checks.</param>
		/// <returns>
		/// A <see cref="T:System.Threading.Tasks.Task`1" /> which will complete when all the health checks have been run,
		/// yielding a <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.HealthReport" /> containing the results.
		/// </returns>
		public Task<HealthReport> CheckHealthAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		/// <summary>
		/// Runs the provided health checks and returns the aggregated status
		/// </summary>
		/// <param name="predicate">
		/// A predicate that can be used to include health checks based on user-defined criteria.
		/// </param>
		/// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> which can be used to cancel the health checks.</param>
		/// <returns>
		/// A <see cref="T:System.Threading.Tasks.Task`1" /> which will complete when all the health checks have been run,
		/// yielding a <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.HealthReport" /> containing the results.
		/// </returns>
		public abstract Task<HealthReport> CheckHealthAsync(Func<HealthCheckRegistration, bool>? predicate, CancellationToken cancellationToken = default(CancellationToken));

		protected HealthCheckService()
		{
			throw null;
		}
	}
}
