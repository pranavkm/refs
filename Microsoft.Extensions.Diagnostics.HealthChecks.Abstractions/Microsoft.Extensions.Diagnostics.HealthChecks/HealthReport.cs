using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Diagnostics.HealthChecks
{
	/// <summary>
	/// Represents the result of executing a group of <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck" /> instances.
	/// </summary>
	public sealed class HealthReport
	{
		/// <summary>
		/// A <see cref="T:System.Collections.Generic.IReadOnlyDictionary`2" /> containing the results from each health check.
		/// </summary>
		/// <remarks>
		/// The keys in this dictionary map the name of each executed health check to a <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.HealthReportEntry" /> for the
		/// result data returned from the corresponding health check.
		/// </remarks>
		public IReadOnlyDictionary<string, HealthReportEntry> Entries
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets a <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.HealthStatus" /> representing the aggregate status of all the health checks. The value of <see cref="P:Microsoft.Extensions.Diagnostics.HealthChecks.HealthReport.Status" />
		/// will be the most severe status reported by a health check. If no checks were executed, the value is always <see cref="F:Microsoft.Extensions.Diagnostics.HealthChecks.HealthStatus.Healthy" />.
		/// </summary>
		public HealthStatus Status
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the time the health check service took to execute.
		/// </summary>
		public TimeSpan TotalDuration
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Create a new <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.HealthReport" /> from the specified results.
		/// </summary>
		/// <param name="entries">A <see cref="T:System.Collections.Generic.IReadOnlyDictionary`2" /> containing the results from each health check.</param>
		/// <param name="totalDuration">A value indicating the time the health check service took to execute.</param>
		public HealthReport(IReadOnlyDictionary<string, HealthReportEntry> entries, TimeSpan totalDuration)
		{
			throw null;
		}

		/// <summary>
		/// Create a new <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.HealthReport" /> from the specified results.
		/// </summary>
		/// <param name="entries">A <see cref="T:System.Collections.Generic.IReadOnlyDictionary`2" /> containing the results from each health check.</param>
		/// <param name="status">A <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.HealthStatus" /> representing the aggregate status of all the health checks.</param>
		/// <param name="totalDuration">A value indicating the time the health check service took to execute.</param>
		public HealthReport(IReadOnlyDictionary<string, HealthReportEntry> entries, HealthStatus status, TimeSpan totalDuration)
		{
			throw null;
		}
	}
}
