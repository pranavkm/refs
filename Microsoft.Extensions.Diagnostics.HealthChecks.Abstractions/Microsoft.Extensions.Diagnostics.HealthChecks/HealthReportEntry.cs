using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Diagnostics.HealthChecks
{
	/// <summary>
	/// Represents an entry in a <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.HealthReport" />. Corresponds to the result of a single <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck" />.
	/// </summary>
	public struct HealthReportEntry
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
		/// Gets the health check execution duration.
		/// </summary>
		public TimeSpan Duration
		{
			[CompilerGenerated]
			readonly get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets an <see cref="T:System.Exception" /> representing the exception that was thrown when checking for status (if any).
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
		/// Gets the health status of the component that was checked.
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
		/// Gets the tags associated with the health check.
		/// </summary>
		public IEnumerable<string> Tags
		{
			[System.Runtime.CompilerServices.NullableContext(1)]
			[CompilerGenerated]
			readonly get
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates a new <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.HealthReportEntry" /> with the specified values for <paramref name="status" />, <paramref name="exception" />,
		/// <paramref name="description" />, and <paramref name="data" />.
		/// </summary>
		/// <param name="status">A value indicating the health status of the component that was checked.</param>
		/// <param name="description">A human-readable description of the status of the component that was checked.</param>
		/// <param name="duration">A value indicating the health execution duration.</param>
		/// <param name="exception">An <see cref="P:Microsoft.Extensions.Diagnostics.HealthChecks.HealthReportEntry.Exception" /> representing the exception that was thrown when checking for status (if any).</param>
		/// <param name="data">Additional key-value pairs describing the health of the component.</param>
		public HealthReportEntry(HealthStatus status, string? description, TimeSpan duration, Exception? exception, IReadOnlyDictionary<string, object>? data)
		{
			throw null;
		}

		/// <summary>
		/// Creates a new <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.HealthReportEntry" /> with the specified values for <paramref name="status" />, <paramref name="exception" />,
		/// <paramref name="description" />, and <paramref name="data" />.
		/// </summary>
		/// <param name="status">A value indicating the health status of the component that was checked.</param>
		/// <param name="description">A human-readable description of the status of the component that was checked.</param>
		/// <param name="duration">A value indicating the health execution duration.</param>
		/// <param name="exception">An <see cref="P:Microsoft.Extensions.Diagnostics.HealthChecks.HealthReportEntry.Exception" /> representing the exception that was thrown when checking for status (if any).</param>
		/// <param name="data">Additional key-value pairs describing the health of the component.</param>
		/// <param name="tags">Tags associated with the health check that generated the report entry.</param>
		public HealthReportEntry(HealthStatus status, string? description, TimeSpan duration, Exception? exception, IReadOnlyDictionary<string, object>? data, IEnumerable<string>? tags = null)
		{
			throw null;
		}
	}
}
