using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Microsoft.AspNetCore.Hosting
{
	/// <summary>
	/// A builder for <see cref="T:Microsoft.AspNetCore.Hosting.IWebHost" />
	/// </summary>
	public class WebHostBuilder : IWebHostBuilder
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.Hosting.WebHostBuilder" /> class.
		/// </summary>
		public WebHostBuilder()
		{
			throw null;
		}

		/// <summary>
		/// Get the setting value from the configuration.
		/// </summary>
		/// <param name="key">The key of the setting to look up.</param>
		/// <returns>The value the setting currently contains.</returns>
		public string GetSetting(string key)
		{
			throw null;
		}

		/// <summary>
		/// Add or replace a setting in the configuration.
		/// </summary>
		/// <param name="key">The key of the setting to add or replace.</param>
		/// <param name="value">The value of the setting to add or replace.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" />.</returns>
		public IWebHostBuilder UseSetting(string key, string? value)
		{
			throw null;
		}

		/// <summary>
		/// Adds a delegate for configuring additional services for the host or web application. This may be called
		/// multiple times.
		/// </summary>
		/// <param name="configureServices">A delegate for configuring the <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" />.</returns>
		public IWebHostBuilder ConfigureServices(Action<IServiceCollection> configureServices)
		{
			throw null;
		}

		/// <summary>
		/// Adds a delegate for configuring additional services for the host or web application. This may be called
		/// multiple times.
		/// </summary>
		/// <param name="configureServices">A delegate for configuring the <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" />.</returns>
		public IWebHostBuilder ConfigureServices(Action<WebHostBuilderContext, IServiceCollection> configureServices)
		{
			throw null;
		}

		/// <summary>
		/// Adds a delegate for configuring the <see cref="T:Microsoft.Extensions.Configuration.IConfigurationBuilder" /> that will construct an <see cref="T:Microsoft.Extensions.Configuration.IConfiguration" />.
		/// </summary>
		/// <param name="configureDelegate">The delegate for configuring the <see cref="T:Microsoft.Extensions.Configuration.IConfigurationBuilder" /> that will be used to construct an <see cref="T:Microsoft.Extensions.Configuration.IConfiguration" />.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" />.</returns>
		/// <remarks>
		/// The <see cref="T:Microsoft.Extensions.Configuration.IConfiguration" /> and <see cref="T:Microsoft.Extensions.Logging.ILoggerFactory" /> on the <see cref="T:Microsoft.AspNetCore.Hosting.WebHostBuilderContext" /> are uninitialized at this stage.
		/// The <see cref="T:Microsoft.Extensions.Configuration.IConfigurationBuilder" /> is pre-populated with the settings of the <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" />.
		/// </remarks>
		public IWebHostBuilder ConfigureAppConfiguration(Action<WebHostBuilderContext, IConfigurationBuilder> configureDelegate)
		{
			throw null;
		}

		/// <summary>
		/// Builds the required services and an <see cref="T:Microsoft.AspNetCore.Hosting.IWebHost" /> which hosts a web application.
		/// </summary>
		public IWebHost Build()
		{
			throw null;
		}
	}
}
