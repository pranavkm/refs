using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Diagnostics.HealthChecks
{
	/// <summary>
	/// Options for the default service that executes <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheckPublisher" /> instances.
	/// </summary>
	public sealed class HealthCheckPublisherOptions
	{
		/// <summary>
		/// Gets or sets the initial delay applied after the application starts before executing 
		/// <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheckPublisher" /> instances. The delay is applied once at startup, and does
		/// not apply to subsequent iterations. The default value is 5 seconds.
		/// </summary>
		public TimeSpan Delay
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets the period of <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheckPublisher" /> execution. The default value is
		/// 30 seconds.
		/// </summary>
		/// <remarks>
		/// The <see cref="P:Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckPublisherOptions.Period" /> cannot be set to a value lower than 1 second.
		/// </remarks>
		public TimeSpan Period
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets a predicate that is used to filter the set of health checks executed.
		/// </summary>
		/// <remarks>
		/// If <see cref="P:Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckPublisherOptions.Predicate" /> is <c>null</c>, the health check publisher service will run all
		/// registered health checks - this is the default behavior. To run a subset of health checks,
		/// provide a function that filters the set of checks. The predicate will be evaluated each period.
		/// </remarks>
		public Func<HealthCheckRegistration, bool>? Predicate
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets the timeout for executing the health checks an all <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheckPublisher" /> 
		/// instances. Use <see cref="F:System.Threading.Timeout.InfiniteTimeSpan" /> to execute with no timeout.
		/// The default value is 30 seconds.
		/// </summary>
		public TimeSpan Timeout
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public HealthCheckPublisherOptions()
		{
			throw null;
		}
	}
}
