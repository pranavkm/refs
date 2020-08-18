using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Collections.Generic;

namespace Microsoft.Extensions.DependencyInjection
{
	/// <summary>
	/// Provides basic extension methods for registering <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck" /> instances in an <see cref="T:Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder" />.
	/// </summary>
	public static class HealthChecksBuilderAddCheckExtensions
	{
		/// <summary>
		/// Adds a new health check with the specified name and implementation.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder" />.</param>
		/// <param name="name">The name of the health check.</param>
		/// <param name="instance">An <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck" /> instance.</param>
		/// <param name="failureStatus">
		/// The <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.HealthStatus" /> that should be reported when the health check reports a failure. If the provided value
		/// is <c>null</c>, then <see cref="F:Microsoft.Extensions.Diagnostics.HealthChecks.HealthStatus.Unhealthy" /> will be reported.
		/// </param>
		/// <param name="tags">A list of tags that can be used to filter health checks.</param>
		/// <returns>The <see cref="T:Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder" />.</returns>
		public static IHealthChecksBuilder AddCheck(this IHealthChecksBuilder builder, string name, IHealthCheck instance, HealthStatus? failureStatus, IEnumerable<string> tags)
		{
			throw null;
		}

		/// <summary>
		/// Adds a new health check with the specified name and implementation.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder" />.</param>
		/// <param name="name">The name of the health check.</param>
		/// <param name="instance">An <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck" /> instance.</param>
		/// <param name="failureStatus">
		/// The <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.HealthStatus" /> that should be reported when the health check reports a failure. If the provided value
		/// is <c>null</c>, then <see cref="F:Microsoft.Extensions.Diagnostics.HealthChecks.HealthStatus.Unhealthy" /> will be reported.
		/// </param>
		/// <param name="tags">A list of tags that can be used to filter health checks.</param>
		/// <param name="timeout">An optional <see cref="T:System.TimeSpan" /> representing the timeout of the check.</param>
		/// <returns>The <see cref="T:Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder" />.</returns>
		public static IHealthChecksBuilder AddCheck(this IHealthChecksBuilder builder, string name, IHealthCheck instance, HealthStatus? failureStatus = null, IEnumerable<string>? tags = null, TimeSpan? timeout = null)
		{
			throw null;
		}

		/// <summary>
		/// Adds a new health check with the specified name and implementation.
		/// </summary>
		/// <typeparam name="T">The health check implementation type.</typeparam>
		/// <param name="builder">The <see cref="T:Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder" />.</param>
		/// <param name="name">The name of the health check.</param>
		/// <param name="failureStatus">
		/// The <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.HealthStatus" /> that should be reported when the health check reports a failure. If the provided value
		/// is <c>null</c>, then <see cref="F:Microsoft.Extensions.Diagnostics.HealthChecks.HealthStatus.Unhealthy" /> will be reported.
		/// </param>
		/// <param name="tags">A list of tags that can be used to filter health checks.</param>
		/// <returns>The <see cref="T:Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder" />.</returns>
		/// <remarks>
		/// This method will use <see cref="M:Microsoft.Extensions.DependencyInjection.ActivatorUtilities.GetServiceOrCreateInstance``1(System.IServiceProvider)" /> to create the health check
		/// instance when needed. If a service of type <typeparamref name="T" /> is registered in the dependency injection container
		/// with any lifetime it will be used. Otherwise an instance of type <typeparamref name="T" /> will be constructed with
		/// access to services from the dependency injection container.
		/// </remarks>
		public static IHealthChecksBuilder AddCheck<T>(this IHealthChecksBuilder builder, string name, HealthStatus? failureStatus, IEnumerable<string> tags) where T : class, IHealthCheck
		{
			throw null;
		}

		/// <summary>
		/// Adds a new health check with the specified name and implementation.
		/// </summary>
		/// <typeparam name="T">The health check implementation type.</typeparam>
		/// <param name="builder">The <see cref="T:Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder" />.</param>
		/// <param name="name">The name of the health check.</param>
		/// <param name="failureStatus">
		/// The <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.HealthStatus" /> that should be reported when the health check reports a failure. If the provided value
		/// is <c>null</c>, then <see cref="F:Microsoft.Extensions.Diagnostics.HealthChecks.HealthStatus.Unhealthy" /> will be reported.
		/// </param>
		/// <param name="tags">A list of tags that can be used to filter health checks.</param>
		/// <param name="timeout">An optional <see cref="T:System.TimeSpan" /> representing the timeout of the check.</param>
		/// <returns>The <see cref="T:Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder" />.</returns>
		/// <remarks>
		/// This method will use <see cref="M:Microsoft.Extensions.DependencyInjection.ActivatorUtilities.GetServiceOrCreateInstance``1(System.IServiceProvider)" /> to create the health check
		/// instance when needed. If a service of type <typeparamref name="T" /> is registered in the dependency injection container
		/// with any lifetime it will be used. Otherwise an instance of type <typeparamref name="T" /> will be constructed with
		/// access to services from the dependency injection container.
		/// </remarks>
		public static IHealthChecksBuilder AddCheck<T>(this IHealthChecksBuilder builder, string name, HealthStatus? failureStatus = null, IEnumerable<string>? tags = null, TimeSpan? timeout = null) where T : class, IHealthCheck
		{
			throw null;
		}

		/// <summary>
		/// Adds a new type activated health check with the specified name and implementation.
		/// </summary>
		/// <typeparam name="T">The health check implementation type.</typeparam>
		/// <param name="builder">The <see cref="T:Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder" />.</param>
		/// <param name="name">The name of the health check.</param>
		/// <param name="args">Additional arguments to provide to the constructor.</param>
		/// <returns>The <see cref="T:Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder" />.</returns>
		/// <remarks>
		/// This method will use <see cref="M:Microsoft.Extensions.DependencyInjection.ActivatorUtilities.CreateInstance``1(System.IServiceProvider,System.Object[])" /> to create the health check
		/// instance when needed. Additional arguments can be provided to the constructor via <paramref name="args" />.
		/// </remarks>
		public static IHealthChecksBuilder AddTypeActivatedCheck<T>(this IHealthChecksBuilder builder, string name, params object[] args) where T : class, IHealthCheck
		{
			throw null;
		}

		/// <summary>
		/// Adds a new type activated health check with the specified name and implementation.
		/// </summary>
		/// <typeparam name="T">The health check implementation type.</typeparam>
		/// <param name="builder">The <see cref="T:Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder" />.</param>
		/// <param name="name">The name of the health check.</param>
		/// <param name="failureStatus">
		/// The <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.HealthStatus" /> that should be reported when the health check reports a failure. If the provided value
		/// is <c>null</c>, then <see cref="F:Microsoft.Extensions.Diagnostics.HealthChecks.HealthStatus.Unhealthy" /> will be reported.
		/// </param>
		/// <param name="args">Additional arguments to provide to the constructor.</param>
		/// <returns>The <see cref="T:Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder" />.</returns>
		/// <remarks>
		/// This method will use <see cref="M:Microsoft.Extensions.DependencyInjection.ActivatorUtilities.CreateInstance``1(System.IServiceProvider,System.Object[])" /> to create the health check
		/// instance when needed. Additional arguments can be provided to the constructor via <paramref name="args" />.
		/// </remarks>
		public static IHealthChecksBuilder AddTypeActivatedCheck<T>(this IHealthChecksBuilder builder, string name, HealthStatus? failureStatus, params object[] args) where T : class, IHealthCheck
		{
			throw null;
		}

		/// <summary>
		/// Adds a new type activated health check with the specified name and implementation.
		/// </summary>
		/// <typeparam name="T">The health check implementation type.</typeparam>
		/// <param name="builder">The <see cref="T:Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder" />.</param>
		/// <param name="name">The name of the health check.</param>
		/// <param name="failureStatus">
		/// The <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.HealthStatus" /> that should be reported when the health check reports a failure. If the provided value
		/// is <c>null</c>, then <see cref="F:Microsoft.Extensions.Diagnostics.HealthChecks.HealthStatus.Unhealthy" /> will be reported.
		/// </param>
		/// <param name="tags">A list of tags that can be used to filter health checks.</param>
		/// <param name="args">Additional arguments to provide to the constructor.</param>
		/// <returns>The <see cref="T:Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder" />.</returns>
		/// <remarks>
		/// This method will use <see cref="M:Microsoft.Extensions.DependencyInjection.ActivatorUtilities.CreateInstance``1(System.IServiceProvider,System.Object[])" /> to create the health check
		/// instance when needed. Additional arguments can be provided to the constructor via <paramref name="args" />.
		/// </remarks>
		public static IHealthChecksBuilder AddTypeActivatedCheck<T>(this IHealthChecksBuilder builder, string name, HealthStatus? failureStatus, IEnumerable<string>? tags, params object[] args) where T : class, IHealthCheck
		{
			throw null;
		}

		/// <summary>
		/// Adds a new type activated health check with the specified name and implementation.
		/// </summary>
		/// <typeparam name="T">The health check implementation type.</typeparam>
		/// <param name="builder">The <see cref="T:Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder" />.</param>
		/// <param name="name">The name of the health check.</param>
		/// <param name="failureStatus">
		/// The <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.HealthStatus" /> that should be reported when the health check reports a failure. If the provided value
		/// is <c>null</c>, then <see cref="F:Microsoft.Extensions.Diagnostics.HealthChecks.HealthStatus.Unhealthy" /> will be reported.
		/// </param>
		/// <param name="tags">A list of tags that can be used to filter health checks.</param>
		/// <param name="args">Additional arguments to provide to the constructor.</param>
		/// <param name="timeout">A <see cref="T:System.TimeSpan" /> representing the timeout of the check.</param>
		/// <returns>The <see cref="T:Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder" />.</returns>
		/// <remarks>
		/// This method will use <see cref="M:Microsoft.Extensions.DependencyInjection.ActivatorUtilities.CreateInstance``1(System.IServiceProvider,System.Object[])" /> to create the health check
		/// instance when needed. Additional arguments can be provided to the constructor via <paramref name="args" />.
		/// </remarks>
		public static IHealthChecksBuilder AddTypeActivatedCheck<T>(this IHealthChecksBuilder builder, string name, HealthStatus? failureStatus, IEnumerable<string> tags, TimeSpan timeout, params object[] args) where T : class, IHealthCheck
		{
			throw null;
		}
	}
}
