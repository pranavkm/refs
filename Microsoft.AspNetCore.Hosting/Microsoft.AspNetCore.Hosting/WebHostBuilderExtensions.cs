using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.AspNetCore.Hosting
{
	public static class WebHostBuilderExtensions
	{
		/// <summary>
		/// Specify the startup method to be used to configure the web application.
		/// </summary>
		/// <param name="hostBuilder">The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" /> to configure.</param>
		/// <param name="configureApp">The delegate that configures the <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" />.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" />.</returns>
		public static IWebHostBuilder Configure(this IWebHostBuilder hostBuilder, Action<IApplicationBuilder> configureApp)
		{
			throw null;
		}

		/// <summary>
		/// Specify the startup method to be used to configure the web application.
		/// </summary>
		/// <param name="hostBuilder">The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" /> to configure.</param>
		/// <param name="configureApp">The delegate that configures the <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" />.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" />.</returns>
		public static IWebHostBuilder Configure(this IWebHostBuilder hostBuilder, Action<WebHostBuilderContext, IApplicationBuilder> configureApp)
		{
			throw null;
		}

		/// <summary>
		/// Specify a factory that creates the startup instance to be used by the web host.
		/// </summary>
		/// <param name="hostBuilder">The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" /> to configure.</param>
		/// <param name="startupFactory">A delegate that specifies a factory for the startup class.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" />.</returns>
		/// <remarks>When using the il linker, all public methods of <typeparamref name="TStartup" /> are preserved. This should match the Startup type directly (and not a base type).</remarks>
		public static IWebHostBuilder UseStartup<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods)] TStartup>(this IWebHostBuilder hostBuilder, Func<WebHostBuilderContext, TStartup> startupFactory) where TStartup : class
		{
			throw null;
		}

		/// <summary>
		/// Specify the startup type to be used by the web host.
		/// </summary>
		/// <param name="hostBuilder">The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" /> to configure.</param>
		/// <param name="startupType">The <see cref="T:System.Type" /> to be used.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" />.</returns>
		public static IWebHostBuilder UseStartup(this IWebHostBuilder hostBuilder, [DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)11)] Type startupType)
		{
			throw null;
		}

		/// <summary>
		/// Specify the startup type to be used by the web host.
		/// </summary>
		/// <param name="hostBuilder">The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" /> to configure.</param>
		/// <typeparam name="TStartup">The type containing the startup methods for the application.</typeparam>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" />.</returns>
		public static IWebHostBuilder UseStartup<[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)11)] TStartup>(this IWebHostBuilder hostBuilder) where TStartup : class
		{
			throw null;
		}

		/// <summary>
		/// Configures the default service provider
		/// </summary>
		/// <param name="hostBuilder">The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" /> to configure.</param>
		/// <param name="configure">A callback used to configure the <see cref="T:Microsoft.Extensions.DependencyInjection.ServiceProviderOptions" /> for the default <see cref="T:System.IServiceProvider" />.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" />.</returns>
		public static IWebHostBuilder UseDefaultServiceProvider(this IWebHostBuilder hostBuilder, Action<ServiceProviderOptions> configure)
		{
			throw null;
		}

		/// <summary>
		/// Configures the default service provider
		/// </summary>
		/// <param name="hostBuilder">The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" /> to configure.</param>
		/// <param name="configure">A callback used to configure the <see cref="T:Microsoft.Extensions.DependencyInjection.ServiceProviderOptions" /> for the default <see cref="T:System.IServiceProvider" />.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" />.</returns>
		public static IWebHostBuilder UseDefaultServiceProvider(this IWebHostBuilder hostBuilder, Action<WebHostBuilderContext, ServiceProviderOptions> configure)
		{
			throw null;
		}

		/// <summary>
		/// Adds a delegate for configuring the <see cref="T:Microsoft.Extensions.Configuration.IConfigurationBuilder" /> that will construct an <see cref="T:Microsoft.Extensions.Configuration.IConfiguration" />.
		/// </summary>
		/// <param name="hostBuilder">The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" /> to configure.</param>
		/// <param name="configureDelegate">The delegate for configuring the <see cref="T:Microsoft.Extensions.Configuration.IConfigurationBuilder" /> that will be used to construct an <see cref="T:Microsoft.Extensions.Configuration.IConfiguration" />.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" />.</returns>
		/// <remarks>
		/// The <see cref="T:Microsoft.Extensions.Configuration.IConfiguration" /> and <see cref="T:Microsoft.Extensions.Logging.ILoggerFactory" /> on the <see cref="T:Microsoft.AspNetCore.Hosting.WebHostBuilderContext" /> are uninitialized at this stage.
		/// The <see cref="T:Microsoft.Extensions.Configuration.IConfigurationBuilder" /> is pre-populated with the settings of the <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" />.
		/// </remarks>
		public static IWebHostBuilder ConfigureAppConfiguration(this IWebHostBuilder hostBuilder, Action<IConfigurationBuilder> configureDelegate)
		{
			throw null;
		}

		/// <summary>
		/// Adds a delegate for configuring the provided <see cref="T:Microsoft.Extensions.Logging.ILoggingBuilder" />. This may be called multiple times.
		/// </summary>
		/// <param name="hostBuilder">The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" /> to configure.</param>
		/// <param name="configureLogging">The delegate that configures the <see cref="T:Microsoft.Extensions.Logging.ILoggingBuilder" />.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" />.</returns>
		public static IWebHostBuilder ConfigureLogging(this IWebHostBuilder hostBuilder, Action<ILoggingBuilder> configureLogging)
		{
			throw null;
		}

		/// <summary>
		/// Adds a delegate for configuring the provided <see cref="T:Microsoft.Extensions.Logging.LoggerFactory" />. This may be called multiple times.
		/// </summary>
		/// <param name="hostBuilder">The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" /> to configure.</param>
		/// <param name="configureLogging">The delegate that configures the <see cref="T:Microsoft.Extensions.Logging.LoggerFactory" />.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" />.</returns>
		public static IWebHostBuilder ConfigureLogging(this IWebHostBuilder hostBuilder, Action<WebHostBuilderContext, ILoggingBuilder> configureLogging)
		{
			throw null;
		}

		/// <summary>
		/// Configures the <see cref="P:Microsoft.AspNetCore.Hosting.IWebHostEnvironment.WebRootFileProvider" /> to use static web assets
		/// defined by referenced projects and packages.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" />.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" />.</returns>
		public static IWebHostBuilder UseStaticWebAssets(this IWebHostBuilder builder)
		{
			throw null;
		}
	}
}
