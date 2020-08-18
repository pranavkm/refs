using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Diagnostics.HealthChecks
{
	/// <summary>
	/// Contains options for the <see cref="T:Microsoft.AspNetCore.Diagnostics.HealthChecks.HealthCheckMiddleware" />.
	/// </summary>
	public class HealthCheckOptions
	{
		/// <summary>
		/// Gets or sets a predicate that is used to filter the set of health checks executed.
		/// </summary>
		/// <remarks>
		/// If <see cref="P:Microsoft.AspNetCore.Diagnostics.HealthChecks.HealthCheckOptions.Predicate" /> is <c>null</c>, the <see cref="T:Microsoft.AspNetCore.Diagnostics.HealthChecks.HealthCheckMiddleware" /> will run all
		/// registered health checks - this is the default behavior. To run a subset of health checks,
		/// provide a function that filters the set of checks.
		/// </remarks>
		public Func<HealthCheckRegistration, bool> Predicate
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
		/// Gets or sets a dictionary mapping the <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.HealthStatus" /> to an HTTP status code applied
		/// to the response. This property can be used to configure the status codes returned for each status.
		/// </summary>
		/// <remarks>
		/// Setting this property to <c>null</c> resets the mapping to its default value which maps
		/// <see cref="F:Microsoft.Extensions.Diagnostics.HealthChecks.HealthStatus.Healthy" /> to 200 (OK), <see cref="F:Microsoft.Extensions.Diagnostics.HealthChecks.HealthStatus.Degraded" /> to 200 (OK) and
		/// <see cref="F:Microsoft.Extensions.Diagnostics.HealthChecks.HealthStatus.Unhealthy" /> to 503 (Service Unavailable).
		/// </remarks>
		/// <exception cref="T:System.InvalidOperationException">Thrown if at least one <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.HealthStatus" /> is missing when setting this property.</exception>
		public IDictionary<HealthStatus, int> ResultStatusCodes
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
		/// Gets or sets a delegate used to write the response.
		/// </summary>
		/// <remarks>
		/// The default value is a delegate that will write a minimal <c>text/plain</c> response with the value
		/// of <see cref="P:Microsoft.Extensions.Diagnostics.HealthChecks.HealthReport.Status" /> as a string.
		/// </remarks>
		public Func<HttpContext, HealthReport, Task> ResponseWriter
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
		/// Gets or sets a value that controls whether responses from the health check middleware can be cached.
		/// </summary>
		/// <remarks>
		/// <para>
		/// The health check middleware does not perform caching of any kind. This setting configures whether
		/// the middleware will apply headers to the HTTP response that instruct clients to avoid caching.
		/// </para>
		/// <para>
		/// If the value is <c>false</c> the health check middleware will set or override the 
		/// <c>Cache-Control</c>, <c>Expires</c>, and <c>Pragma</c> headers to prevent response caching. If the value 
		/// is <c>true</c> the health check middleware will not modify the cache headers of the response.
		/// </para>
		/// </remarks>
		public bool AllowCachingResponses
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

		public HealthCheckOptions()
		{
			throw null;
		}
	}
}
