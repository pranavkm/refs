using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Routing;

namespace Microsoft.AspNetCore.Builder
{
	/// <summary>
	/// Provides extension methods for <see cref="T:Microsoft.AspNetCore.Routing.IEndpointRouteBuilder" /> to add health checks.
	/// </summary>
	public static class HealthCheckEndpointRouteBuilderExtensions
	{
		/// <summary>
		/// Adds a health checks endpoint to the <see cref="T:Microsoft.AspNetCore.Routing.IEndpointRouteBuilder" /> with the specified template.
		/// </summary>
		/// <param name="endpoints">The <see cref="T:Microsoft.AspNetCore.Routing.IEndpointRouteBuilder" /> to add the health checks endpoint to.</param>
		/// <param name="pattern">The URL pattern of the health checks endpoint.</param>
		/// <returns>A convention routes for the health checks endpoint.</returns>
		public static IEndpointConventionBuilder MapHealthChecks(this IEndpointRouteBuilder endpoints, string pattern)
		{
			throw null;
		}

		/// <summary>
		/// Adds a health checks endpoint to the <see cref="T:Microsoft.AspNetCore.Routing.IEndpointRouteBuilder" /> with the specified template and options.
		/// </summary>
		/// <param name="endpoints">The <see cref="T:Microsoft.AspNetCore.Routing.IEndpointRouteBuilder" /> to add the health checks endpoint to.</param>
		/// <param name="pattern">The URL pattern of the health checks endpoint.</param>
		/// <param name="options">A <see cref="T:Microsoft.AspNetCore.Diagnostics.HealthChecks.HealthCheckOptions" /> used to configure the health checks.</param>
		/// <returns>A convention routes for the health checks endpoint.</returns>
		public static IEndpointConventionBuilder MapHealthChecks(this IEndpointRouteBuilder endpoints, string pattern, HealthCheckOptions options)
		{
			throw null;
		}
	}
}
