using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Extensions.Hosting
{
	public static class HostingHostBuilderExtensions
	{
		/// <summary>
		/// Sets up the configuration for the remainder of the build process and application. This can be called multiple times and
		/// the results will be additive. The results will be available at <see cref="P:Microsoft.Extensions.Hosting.HostBuilderContext.Configuration" /> for
		/// subsequent operations, as well as in <see cref="P:Microsoft.Extensions.Hosting.IHost.Services" />.
		/// </summary>
		/// <param name="hostBuilder">The <see cref="T:Microsoft.Extensions.Hosting.IHostBuilder" /> to configure.</param>
		/// <param name="configureDelegate">The delegate for configuring the <see cref="T:Microsoft.Extensions.Configuration.IConfigurationBuilder" /> that will be used
		/// to construct the <see cref="T:Microsoft.Extensions.Configuration.IConfiguration" /> for the host.</param>
		/// <returns>The same instance of the <see cref="T:Microsoft.Extensions.Hosting.IHostBuilder" /> for chaining.</returns>
		public static IHostBuilder ConfigureAppConfiguration(this IHostBuilder hostBuilder, Action<IConfigurationBuilder> configureDelegate)
		{
			throw null;
		}

		/// <summary>
		/// Enables configuring the instantiated dependency container. This can be called multiple times and
		/// the results will be additive.
		/// </summary>
		/// <typeparam name="TContainerBuilder"></typeparam>
		/// <param name="hostBuilder">The <see cref="T:Microsoft.Extensions.Hosting.IHostBuilder" /> to configure.</param>
		/// <param name="configureDelegate">The delegate for configuring the <typeparamref name="TContainerBuilder" />.</param>
		/// <returns>The same instance of the <see cref="T:Microsoft.Extensions.Hosting.IHostBuilder" /> for chaining.</returns>
		public static IHostBuilder ConfigureContainer<TContainerBuilder>(this IHostBuilder hostBuilder, Action<TContainerBuilder> configureDelegate)
		{
			throw null;
		}

		/// <summary>
		/// Adds a delegate for configuring the provided <see cref="T:Microsoft.Extensions.Logging.ILoggingBuilder" />. This may be called multiple times.
		/// </summary>
		/// <param name="hostBuilder">The <see cref="T:Microsoft.Extensions.Hosting.IHostBuilder" /> to configure.</param>
		/// <param name="configureLogging">The delegate that configures the <see cref="T:Microsoft.Extensions.Logging.ILoggingBuilder" />.</param>
		/// <returns>The same instance of the <see cref="T:Microsoft.Extensions.Hosting.IHostBuilder" /> for chaining.</returns>
		public static IHostBuilder ConfigureLogging(this IHostBuilder hostBuilder, Action<HostBuilderContext, ILoggingBuilder> configureLogging)
		{
			throw null;
		}

		/// <summary>
		/// Adds a delegate for configuring the provided <see cref="T:Microsoft.Extensions.Logging.ILoggingBuilder" />. This may be called multiple times.
		/// </summary>
		/// <param name="hostBuilder">The <see cref="T:Microsoft.Extensions.Hosting.IHostBuilder" /> to configure.</param>
		/// <param name="configureLogging">The delegate that configures the <see cref="T:Microsoft.Extensions.Logging.ILoggingBuilder" />.</param>
		/// <returns>The same instance of the <see cref="T:Microsoft.Extensions.Hosting.IHostBuilder" /> for chaining.</returns>
		public static IHostBuilder ConfigureLogging(this IHostBuilder hostBuilder, Action<ILoggingBuilder> configureLogging)
		{
			throw null;
		}

		/// <summary>
		/// Adds services to the container. This can be called multiple times and the results will be additive.
		/// </summary>
		/// <param name="hostBuilder">The <see cref="T:Microsoft.Extensions.Hosting.IHostBuilder" /> to configure.</param>
		/// <param name="configureDelegate">The delegate for configuring the <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.</param>
		/// <returns>The same instance of the <see cref="T:Microsoft.Extensions.Hosting.IHostBuilder" /> for chaining.</returns>
		public static IHostBuilder ConfigureServices(this IHostBuilder hostBuilder, Action<IServiceCollection> configureDelegate)
		{
			throw null;
		}

		/// <summary>
		/// Enables console support, builds and starts the host, and waits for Ctrl+C or SIGTERM to shut down.
		/// </summary>
		/// <param name="hostBuilder">The <see cref="T:Microsoft.Extensions.Hosting.IHostBuilder" /> to configure.</param>
		/// <param name="configureOptions">The delegate for configuring the <see cref="T:Microsoft.Extensions.Hosting.Internal.ConsoleLifetime" />.</param>
		/// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> that can be used to cancel the console.</param>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task" /> that only completes when the token is triggered or shutdown is triggered.</returns>
		public static Task RunConsoleAsync(this IHostBuilder hostBuilder, Action<ConsoleLifetimeOptions> configureOptions, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		/// <summary>
		/// Enables console support, builds and starts the host, and waits for Ctrl+C or SIGTERM to shut down.
		/// </summary>
		/// <param name="hostBuilder">The <see cref="T:Microsoft.Extensions.Hosting.IHostBuilder" /> to configure.</param>
		/// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> that can be used to cancel the console.</param>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task" /> that only completes when the token is triggered or shutdown is triggered.</returns>
		public static Task RunConsoleAsync(this IHostBuilder hostBuilder, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		/// <summary>
		/// Listens for Ctrl+C or SIGTERM and calls <see cref="M:Microsoft.Extensions.Hosting.IHostApplicationLifetime.StopApplication" /> to start the shutdown process.
		/// This will unblock extensions like RunAsync and WaitForShutdownAsync.
		/// </summary>
		/// <param name="hostBuilder">The <see cref="T:Microsoft.Extensions.Hosting.IHostBuilder" /> to configure.</param>
		/// <returns>The same instance of the <see cref="T:Microsoft.Extensions.Hosting.IHostBuilder" /> for chaining.</returns>
		public static IHostBuilder UseConsoleLifetime(this IHostBuilder hostBuilder)
		{
			throw null;
		}

		/// <summary>
		/// Listens for Ctrl+C or SIGTERM and calls <see cref="M:Microsoft.Extensions.Hosting.IHostApplicationLifetime.StopApplication" /> to start the shutdown process.
		/// This will unblock extensions like RunAsync and WaitForShutdownAsync.
		/// </summary>
		/// <param name="hostBuilder">The <see cref="T:Microsoft.Extensions.Hosting.IHostBuilder" /> to configure.</param>
		/// <param name="configureOptions">The delegate for configuring the <see cref="T:Microsoft.Extensions.Hosting.Internal.ConsoleLifetime" />.</param>
		/// <returns>The same instance of the <see cref="T:Microsoft.Extensions.Hosting.IHostBuilder" /> for chaining.</returns>
		public static IHostBuilder UseConsoleLifetime(this IHostBuilder hostBuilder, Action<ConsoleLifetimeOptions> configureOptions)
		{
			throw null;
		}

		/// <summary>
		/// Specify the content root directory to be used by the host.
		/// </summary>
		/// <param name="hostBuilder">The <see cref="T:Microsoft.Extensions.Hosting.IHostBuilder" /> to configure.</param>
		/// <param name="contentRoot">Path to root directory of the application.</param>
		/// <returns>The <see cref="T:Microsoft.Extensions.Hosting.IHostBuilder" />.</returns>
		public static IHostBuilder UseContentRoot(this IHostBuilder hostBuilder, string contentRoot)
		{
			throw null;
		}

		/// <summary>
		/// Specify the <see cref="T:System.IServiceProvider" /> to be the default one.
		/// </summary>
		/// <param name="hostBuilder">The <see cref="T:Microsoft.Extensions.Hosting.IHostBuilder" /> to configure.</param>
		/// <param name="configure"></param>
		/// <returns>The <see cref="T:Microsoft.Extensions.Hosting.IHostBuilder" />.</returns>
		public static IHostBuilder UseDefaultServiceProvider(this IHostBuilder hostBuilder, Action<ServiceProviderOptions> configure)
		{
			throw null;
		}

		/// <summary>
		/// Specify the <see cref="T:System.IServiceProvider" /> to be the default one.
		/// </summary>
		/// <param name="hostBuilder">The <see cref="T:Microsoft.Extensions.Hosting.IHostBuilder" /> to configure.</param>
		/// <param name="configure">The delegate that configures the <see cref="T:System.IServiceProvider" />.</param>
		/// <returns>The <see cref="T:Microsoft.Extensions.Hosting.IHostBuilder" />.</returns>
		public static IHostBuilder UseDefaultServiceProvider(this IHostBuilder hostBuilder, Action<HostBuilderContext, ServiceProviderOptions> configure)
		{
			throw null;
		}

		/// <summary>
		/// Specify the environment to be used by the host.
		/// </summary>
		/// <param name="hostBuilder">The <see cref="T:Microsoft.Extensions.Hosting.IHostBuilder" /> to configure.</param>
		/// <param name="environment">The environment to host the application in.</param>
		/// <returns>The <see cref="T:Microsoft.Extensions.Hosting.IHostBuilder" />.</returns>
		public static IHostBuilder UseEnvironment(this IHostBuilder hostBuilder, string environment)
		{
			throw null;
		}
	}
}
