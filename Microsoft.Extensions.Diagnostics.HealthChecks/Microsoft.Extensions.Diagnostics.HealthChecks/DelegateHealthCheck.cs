using System;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Extensions.Diagnostics.HealthChecks
{
	/// <summary>
	/// A simple implementation of <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck" /> which uses a provided delegate to
	/// implement the check.
	/// </summary>
	internal sealed class DelegateHealthCheck : IHealthCheck
	{
		/// <summary>
		/// Create an instance of <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.DelegateHealthCheck" /> from the specified delegate.
		/// </summary>
		/// <param name="check">A delegate which provides the code to execute when the health check is run.</param>
		public DelegateHealthCheck(Func<CancellationToken, Task<HealthCheckResult>> check)
		{
			throw null;
		}

		/// <summary>
		/// Runs the health check, returning the status of the component being checked.
		/// </summary>
		/// <param name="context">A context object associated with the current execution.</param>
		/// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> that can be used to cancel the health check.</param>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task`1" /> that completes when the health check has finished, yielding the status of the component being checked.</returns>
		public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}
	}
}
