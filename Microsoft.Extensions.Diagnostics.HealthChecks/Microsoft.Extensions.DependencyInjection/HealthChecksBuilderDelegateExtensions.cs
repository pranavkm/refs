using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependencyInjection
{
	/// <summary>
	/// Provides extension methods for registering delegates with the <see cref="T:Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder" />.
	/// </summary>
	public static class HealthChecksBuilderDelegateExtensions
	{
		/// <summary>
		/// Adds a new health check with the specified name and implementation.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder" />.</param>
		/// <param name="name">The name of the health check.</param>
		/// <param name="tags">A list of tags that can be used to filter health checks.</param>
		/// <param name="check">A delegate that provides the health check implementation.</param>
		/// <returns>The <see cref="T:Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder" />.</returns>
		public static IHealthChecksBuilder AddCheck(this IHealthChecksBuilder builder, string name, Func<HealthCheckResult> check, IEnumerable<string> tags)
		{
			throw null;
		}

		/// <summary>
		/// Adds a new health check with the specified name and implementation.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder" />.</param>
		/// <param name="name">The name of the health check.</param>
		/// <param name="tags">A list of tags that can be used to filter health checks.</param>
		/// <param name="check">A delegate that provides the health check implementation.</param>
		/// <param name="timeout">An optional <see cref="T:System.TimeSpan" /> representing the timeout of the check.</param>
		/// <returns>The <see cref="T:Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder" />.</returns>
		public static IHealthChecksBuilder AddCheck(this IHealthChecksBuilder builder, string name, Func<HealthCheckResult> check, IEnumerable<string>? tags = null, TimeSpan? timeout = null)
		{
			throw null;
		}

		/// <summary>
		/// Adds a new health check with the specified name and implementation.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder" />.</param>
		/// <param name="name">The name of the health check.</param>
		/// <param name="tags">A list of tags that can be used to filter health checks.</param>
		/// <param name="check">A delegate that provides the health check implementation.</param>
		/// <returns>The <see cref="T:Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder" />.</returns>
		public static IHealthChecksBuilder AddCheck(this IHealthChecksBuilder builder, string name, Func<CancellationToken, HealthCheckResult> check, IEnumerable<string>? tags)
		{
			throw null;
		}

		/// <summary>
		/// Adds a new health check with the specified name and implementation.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder" />.</param>
		/// <param name="name">The name of the health check.</param>
		/// <param name="tags">A list of tags that can be used to filter health checks.</param>
		/// <param name="check">A delegate that provides the health check implementation.</param>
		/// <param name="timeout">An optional <see cref="T:System.TimeSpan" /> representing the timeout of the check.</param>
		/// <returns>The <see cref="T:Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder" />.</returns>
		public static IHealthChecksBuilder AddCheck(this IHealthChecksBuilder builder, string name, Func<CancellationToken, HealthCheckResult> check, IEnumerable<string>? tags = null, TimeSpan? timeout = null)
		{
			throw null;
		}

		/// <summary>
		/// Adds a new health check with the specified name and implementation.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder" />.</param>
		/// <param name="name">The name of the health check.</param>
		/// <param name="tags">A list of tags that can be used to filter health checks.</param>
		/// <param name="check">A delegate that provides the health check implementation.</param>
		/// <returns>The <see cref="T:Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder" />.</returns>
		public static IHealthChecksBuilder AddAsyncCheck(this IHealthChecksBuilder builder, string name, Func<Task<HealthCheckResult>> check, IEnumerable<string> tags)
		{
			throw null;
		}

		/// <summary>
		/// Adds a new health check with the specified name and implementation.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder" />.</param>
		/// <param name="name">The name of the health check.</param>
		/// <param name="tags">A list of tags that can be used to filter health checks.</param>
		/// <param name="check">A delegate that provides the health check implementation.</param>
		/// <param name="timeout">An optional <see cref="T:System.TimeSpan" /> representing the timeout of the check.</param>
		/// <returns>The <see cref="T:Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder" />.</returns>
		public static IHealthChecksBuilder AddAsyncCheck(this IHealthChecksBuilder builder, string name, Func<Task<HealthCheckResult>> check, IEnumerable<string>? tags = null, TimeSpan? timeout = null)
		{
			throw null;
		}

		/// <summary>
		/// Adds a new health check with the specified name and implementation.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder" />.</param>
		/// <param name="name">The name of the health check.</param>
		/// <param name="tags">A list of tags that can be used to filter health checks.</param>
		/// <param name="check">A delegate that provides the health check implementation.</param>
		/// <returns>The <see cref="T:Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder" />.</returns>
		public static IHealthChecksBuilder AddAsyncCheck(this IHealthChecksBuilder builder, string name, Func<CancellationToken, Task<HealthCheckResult>> check, IEnumerable<string> tags)
		{
			throw null;
		}

		/// <summary>
		/// Adds a new health check with the specified name and implementation.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder" />.</param>
		/// <param name="name">The name of the health check.</param>
		/// <param name="tags">A list of tags that can be used to filter health checks.</param>
		/// <param name="check">A delegate that provides the health check implementation.</param>
		/// <param name="timeout">An optional <see cref="T:System.TimeSpan" /> representing the timeout of the check.</param>
		/// <returns>The <see cref="T:Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder" />.</returns>
		public static IHealthChecksBuilder AddAsyncCheck(this IHealthChecksBuilder builder, string name, Func<CancellationToken, Task<HealthCheckResult>> check, IEnumerable<string>? tags = null, TimeSpan? timeout = null)
		{
			throw null;
		}
	}
}
