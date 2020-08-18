using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Extensions.Diagnostics.HealthChecks
{
	/// <summary>
	/// Represents a health check, which can be used to check the status of a component in the application, such as a backend service, database or some internal
	/// state.
	/// </summary>
	public interface IHealthCheck
	{
		/// <summary>
		/// Runs the health check, returning the status of the component being checked.
		/// </summary>
		/// <param name="context">A context object associated with the current execution.</param>
		/// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> that can be used to cancel the health check.</param>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task`1" /> that completes when the health check has finished, yielding the status of the component being checked.</returns>
		Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default(CancellationToken));
	}
}
