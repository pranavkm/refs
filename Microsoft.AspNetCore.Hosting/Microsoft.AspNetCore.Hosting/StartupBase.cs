using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Microsoft.AspNetCore.Hosting
{
	public abstract class StartupBase : IStartup
	{
		public abstract void Configure(IApplicationBuilder app);

		IServiceProvider IStartup.ConfigureServices(IServiceCollection services)
		{
			throw null;
		}

		public virtual void ConfigureServices(IServiceCollection services)
		{
			throw null;
		}

		public virtual IServiceProvider CreateServiceProvider(IServiceCollection services)
		{
			throw null;
		}

		protected StartupBase()
		{
			throw null;
		}
	}
	public abstract class StartupBase<TBuilder> : StartupBase
	{
		public StartupBase(IServiceProviderFactory<TBuilder> factory)
		{
			throw null;
		}

		public override IServiceProvider CreateServiceProvider(IServiceCollection services)
		{
			throw null;
		}

		public virtual void ConfigureContainer(TBuilder builder)
		{
			throw null;
		}
	}
}
