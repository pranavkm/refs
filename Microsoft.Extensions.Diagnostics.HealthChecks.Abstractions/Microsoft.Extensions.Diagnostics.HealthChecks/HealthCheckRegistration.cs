using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Diagnostics.HealthChecks
{
	/// <summary>
	/// Represent the registration information associated with an <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck" /> implementation.
	/// </summary>
	/// <remarks>
	/// <para>
	/// The health check registration is provided as a separate object so that application developers can customize
	/// how health check implementations are configured.
	/// </para>
	/// <para>
	/// The registration is provided to an <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck" /> implementation during execution through
	/// <see cref="P:Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckContext.Registration" />. This allows a health check implementation to access named
	/// options or perform other operations based on the registered name.
	/// </para>
	/// </remarks>
	public sealed class HealthCheckRegistration
	{
		/// <summary>
		/// Gets or sets a delegate used to create the <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck" /> instance.
		/// </summary>
		public Func<IServiceProvider, IHealthCheck> Factory
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
		/// Gets or sets the <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.HealthStatus" /> that should be reported upon failure of the health check.
		/// </summary>
		public HealthStatus FailureStatus
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
		/// Gets or sets the timeout used for the test.
		/// </summary>
		public TimeSpan Timeout
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
		/// Gets or sets the health check name.
		/// </summary>
		public string Name
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
		/// Gets a list of tags that can be used for filtering health checks.
		/// </summary>
		public ISet<string> Tags
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates a new <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckRegistration" /> for an existing <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck" /> instance.
		/// </summary>
		/// <param name="name">The health check name.</param>
		/// <param name="instance">The <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck" /> instance.</param>
		/// <param name="failureStatus">
		/// The <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.HealthStatus" /> that should be reported upon failure of the health check. If the provided value
		/// is <c>null</c>, then <see cref="F:Microsoft.Extensions.Diagnostics.HealthChecks.HealthStatus.Unhealthy" /> will be reported.
		/// </param>
		/// <param name="tags">A list of tags that can be used for filtering health checks.</param>
		public HealthCheckRegistration(string name, IHealthCheck instance, HealthStatus? failureStatus, IEnumerable<string>? tags)
		{
			throw null;
		}

		/// <summary>
		/// Creates a new <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckRegistration" /> for an existing <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck" /> instance.
		/// </summary>
		/// <param name="name">The health check name.</param>
		/// <param name="instance">The <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck" /> instance.</param>
		/// <param name="failureStatus">
		/// The <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.HealthStatus" /> that should be reported upon failure of the health check. If the provided value
		/// is <c>null</c>, then <see cref="F:Microsoft.Extensions.Diagnostics.HealthChecks.HealthStatus.Unhealthy" /> will be reported.
		/// </param>
		/// <param name="tags">A list of tags that can be used for filtering health checks.</param>
		/// <param name="timeout">An optional <see cref="T:System.TimeSpan" /> representing the timeout of the check.</param>
		public HealthCheckRegistration(string name, IHealthCheck instance, HealthStatus? failureStatus, IEnumerable<string>? tags, TimeSpan? timeout)
		{
			throw null;
		}

		/// <summary>
		/// Creates a new <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckRegistration" /> for an existing <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck" /> instance.
		/// </summary>
		/// <param name="name">The health check name.</param>
		/// <param name="factory">A delegate used to create the <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck" /> instance.</param>
		/// <param name="failureStatus">
		/// The <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.HealthStatus" /> that should be reported when the health check reports a failure. If the provided value
		/// is <c>null</c>, then <see cref="F:Microsoft.Extensions.Diagnostics.HealthChecks.HealthStatus.Unhealthy" /> will be reported.
		/// </param>
		/// <param name="tags">A list of tags that can be used for filtering health checks.</param>
		public HealthCheckRegistration(string name, Func<IServiceProvider, IHealthCheck> factory, HealthStatus? failureStatus, IEnumerable<string>? tags)
		{
			throw null;
		}

		/// <summary>
		/// Creates a new <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckRegistration" /> for an existing <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck" /> instance.
		/// </summary>
		/// <param name="name">The health check name.</param>
		/// <param name="factory">A delegate used to create the <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck" /> instance.</param>
		/// <param name="failureStatus">
		/// The <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.HealthStatus" /> that should be reported when the health check reports a failure. If the provided value
		/// is <c>null</c>, then <see cref="F:Microsoft.Extensions.Diagnostics.HealthChecks.HealthStatus.Unhealthy" /> will be reported.
		/// </param>
		/// <param name="tags">A list of tags that can be used for filtering health checks.</param>
		/// <param name="timeout">An optional <see cref="T:System.TimeSpan" /> representing the timeout of the check.</param>
		public HealthCheckRegistration(string name, Func<IServiceProvider, IHealthCheck> factory, HealthStatus? failureStatus, IEnumerable<string>? tags, TimeSpan? timeout)
		{
			throw null;
		}
	}
}
