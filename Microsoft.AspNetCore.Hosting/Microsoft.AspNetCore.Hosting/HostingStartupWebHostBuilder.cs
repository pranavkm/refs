using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.AspNetCore.Hosting
{
	internal class HostingStartupWebHostBuilder : IWebHostBuilder, ISupportsStartup, ISupportsUseDefaultServiceProvider
	{
		public HostingStartupWebHostBuilder(GenericWebHostBuilder builder)
		{
			throw null;
		}

		public IWebHost Build()
		{
			throw null;
		}

		public IWebHostBuilder ConfigureAppConfiguration(Action<WebHostBuilderContext, IConfigurationBuilder> configureDelegate)
		{
			throw null;
		}

		public IWebHostBuilder ConfigureServices(Action<IServiceCollection> configureServices)
		{
			throw null;
		}

		public IWebHostBuilder ConfigureServices(Action<WebHostBuilderContext, IServiceCollection> configureServices)
		{
			throw null;
		}

		public string GetSetting(string key)
		{
			throw null;
		}

		public IWebHostBuilder UseSetting(string key, string value)
		{
			throw null;
		}

		public void ConfigureServices(WebHostBuilderContext context, IServiceCollection services)
		{
			throw null;
		}

		public void ConfigureAppConfiguration(WebHostBuilderContext context, IConfigurationBuilder builder)
		{
			throw null;
		}

		public IWebHostBuilder UseDefaultServiceProvider(Action<WebHostBuilderContext, ServiceProviderOptions> configure)
		{
			throw null;
		}

		public IWebHostBuilder Configure(Action<WebHostBuilderContext, IApplicationBuilder> configure)
		{
			throw null;
		}

		public IWebHostBuilder UseStartup([DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)11)] Type startupType)
		{
			throw null;
		}

		public IWebHostBuilder UseStartup<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods)] TStartup>(Func<WebHostBuilderContext, TStartup> startupFactory)
		{
			throw null;
		}
	}
}
