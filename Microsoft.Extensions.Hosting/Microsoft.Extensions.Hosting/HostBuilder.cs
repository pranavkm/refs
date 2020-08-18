using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace Microsoft.Extensions.Hosting
{
	/// <summary>
	/// A program initialization utility.
	/// </summary>
	public class HostBuilder : IHostBuilder
	{
		/// <summary>
		/// A central location for sharing state between components during the host building process.
		/// </summary>
		public IDictionary<object, object> Properties
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Run the given actions to initialize the host. This can only be called once.
		/// </summary>
		/// <returns>An initialized <see cref="T:Microsoft.Extensions.Hosting.IHost" /></returns>
		public IHost Build()
		{
			throw null;
		}

		/// <summary>
		/// Sets up the configuration for the remainder of the build process and application. This can be called multiple times and
		/// the results will be additive. The results will be available at <see cref="P:Microsoft.Extensions.Hosting.HostBuilderContext.Configuration" /> for
		/// subsequent operations, as well as in <see cref="P:Microsoft.Extensions.Hosting.IHost.Services" />.
		/// </summary>
		/// <param name="configureDelegate">The delegate for configuring the <see cref="T:Microsoft.Extensions.Configuration.IConfigurationBuilder" /> that will be used
		/// to construct the <see cref="T:Microsoft.Extensions.Configuration.IConfiguration" /> for the host.</param>
		/// <returns>The same instance of the <see cref="T:Microsoft.Extensions.Hosting.IHostBuilder" /> for chaining.</returns>
		public IHostBuilder ConfigureAppConfiguration(Action<HostBuilderContext, IConfigurationBuilder> configureDelegate)
		{
			throw null;
		}

		/// <summary>
		/// Enables configuring the instantiated dependency container. This can be called multiple times and
		/// the results will be additive.
		/// </summary>
		/// <typeparam name="TContainerBuilder">The type of the builder to create.</typeparam>
		/// <param name="configureDelegate">The delegate for configuring the <see cref="T:Microsoft.Extensions.Configuration.IConfigurationBuilder" /> that will be used
		/// to construct the <see cref="T:Microsoft.Extensions.Configuration.IConfiguration" /> for the host.</param>
		/// <returns>The same instance of the <see cref="T:Microsoft.Extensions.Hosting.IHostBuilder" /> for chaining.</returns>
		public IHostBuilder ConfigureContainer<TContainerBuilder>(Action<HostBuilderContext, TContainerBuilder> configureDelegate)
		{
			throw null;
		}

		/// <summary>
		/// Set up the configuration for the builder itself. This will be used to initialize the <see cref="T:Microsoft.Extensions.Hosting.IHostEnvironment" />
		/// for use later in the build process. This can be called multiple times and the results will be additive.
		/// </summary>
		/// <param name="configureDelegate">The delegate for configuring the <see cref="T:Microsoft.Extensions.Configuration.IConfigurationBuilder" /> that will be used
		/// to construct the <see cref="T:Microsoft.Extensions.Configuration.IConfiguration" /> for the host.</param>
		/// <returns>The same instance of the <see cref="T:Microsoft.Extensions.Hosting.IHostBuilder" /> for chaining.</returns>
		public IHostBuilder ConfigureHostConfiguration(Action<IConfigurationBuilder> configureDelegate)
		{
			throw null;
		}

		/// <summary>
		/// Adds services to the container. This can be called multiple times and the results will be additive.
		/// </summary>
		/// <param name="configureDelegate">The delegate for configuring the <see cref="T:Microsoft.Extensions.Configuration.IConfigurationBuilder" /> that will be used
		/// to construct the <see cref="T:Microsoft.Extensions.Configuration.IConfiguration" /> for the host.</param>
		/// <returns>The same instance of the <see cref="T:Microsoft.Extensions.Hosting.IHostBuilder" /> for chaining.</returns>
		public IHostBuilder ConfigureServices(Action<HostBuilderContext, IServiceCollection> configureDelegate)
		{
			throw null;
		}

		/// <summary>
		/// Overrides the factory used to create the service provider.
		/// </summary>
		/// <typeparam name="TContainerBuilder">The type of the builder to create.</typeparam>
		/// <param name="factory">A factory used for creating service providers.</param>
		/// <returns>The same instance of the <see cref="T:Microsoft.Extensions.Hosting.IHostBuilder" /> for chaining.</returns>
		public IHostBuilder UseServiceProviderFactory<TContainerBuilder>(IServiceProviderFactory<TContainerBuilder> factory)
		{
			throw null;
		}

		/// <summary>
		/// Overrides the factory used to create the service provider.
		/// </summary>
		/// <param name="factory">A factory used for creating service providers.</param>
		/// <typeparam name="TContainerBuilder">The type of the builder to create.</typeparam>
		/// <returns>The same instance of the <see cref="T:Microsoft.Extensions.Hosting.IHostBuilder" /> for chaining.</returns>
		public IHostBuilder UseServiceProviderFactory<TContainerBuilder>(Func<HostBuilderContext, IServiceProviderFactory<TContainerBuilder>> factory)
		{
			throw null;
		}
	}
}
