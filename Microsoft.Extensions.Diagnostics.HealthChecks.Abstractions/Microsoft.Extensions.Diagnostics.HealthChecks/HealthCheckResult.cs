using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Diagnostics.HealthChecks
{
	/// <summary>
	/// Represents the result of a health check.
	/// </summary>
	public struct HealthCheckResult
	{
		private static readonly IReadOnlyDictionary<string, object> _emptyReadOnlyDictionary;

		/// <summary>
		/// Gets additional key-value pairs describing the health of the component.
		/// </summary>
		public IReadOnlyDictionary<string, object> Data
		{
			[System.Runtime.CompilerServices.NullableContext(1)]
			[CompilerGenerated]
			readonly get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets a human-readable description of the status of the component that was checked.
		/// </summary>
		public string? Description
		{
			[CompilerGenerated]
			readonly get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets an <see cref="P:Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckResult.Exception" /> representing the exception that was thrown when checking for status (if any).
		/// </summary>
		public Exception? Exception
		{
			[CompilerGenerated]
			readonly get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets a value indicating the status of the component that was checked.
		/// </summary>
		public HealthStatus Status
		{
			[CompilerGenerated]
			readonly get
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates a new <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckResult" /> with the specified values for <paramref name="status" />,
		/// <paramref name="exception" />, <paramref name="description" />, and <paramref name="data" />.
		/// </summary>
		/// <param name="status">A value indicating the status of the component that was checked.</param>
		/// <param name="description">A human-readable description of the status of the component that was checked.</param>
		/// <param name="exception">An <see cref="P:Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckResult.Exception" /> representing the exception that was thrown when checking for status (if any).</param>
		/// <param name="data">Additional key-value pairs describing the health of the component.</param>
		public HealthCheckResult(HealthStatus status, string? description = null, Exception? exception = null, IReadOnlyDictionary<string, object>? data = null)
		{
			throw null;
		}

		/// <summary>
		/// Creates a <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckResult" /> representing a healthy component.
		/// </summary>
		/// <param name="description">A human-readable description of the status of the component that was checked. Optional.</param>
		/// <param name="data">Additional key-value pairs describing the health of the component. Optional.</param>
		/// <returns>A <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckResult" /> representing a healthy component.</returns>
		public static HealthCheckResult Healthy(string? description = null, IReadOnlyDictionary<string, object>? data = null)
		{
			throw null;
		}

		/// <summary>
		/// Creates a <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckResult" /> representing a degraded component.
		/// </summary>
		/// <param name="description">A human-readable description of the status of the component that was checked. Optional.</param>
		/// <param name="exception">An <see cref="P:Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckResult.Exception" /> representing the exception that was thrown when checking for status. Optional.</param>
		/// <param name="data">Additional key-value pairs describing the health of the component. Optional.</param>
		/// <returns>A <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckResult" /> representing a degraged component.</returns>
		public static HealthCheckResult Degraded(string? description = null, Exception? exception = null, IReadOnlyDictionary<string, object>? data = null)
		{
			throw null;
		}

		/// <summary>
		/// Creates a <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckResult" /> representing an unhealthy component.
		/// </summary>
		/// <param name="description">A human-readable description of the status of the component that was checked. Optional.</param>
		/// <param name="exception">An <see cref="P:Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckResult.Exception" /> representing the exception that was thrown when checking for status. Optional.</param>
		/// <param name="data">Additional key-value pairs describing the health of the component. Optional.</param>
		/// <returns>A <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckResult" /> representing an unhealthy component.</returns>
		public static HealthCheckResult Unhealthy(string? description = null, Exception? exception = null, IReadOnlyDictionary<string, object>? data = null)
		{
			throw null;
		}
	}
}
