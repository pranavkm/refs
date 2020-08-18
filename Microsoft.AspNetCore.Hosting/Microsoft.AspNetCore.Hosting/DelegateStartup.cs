using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Microsoft.AspNetCore.Hosting
{
	public class DelegateStartup : StartupBase<IServiceCollection>
	{
		public DelegateStartup(IServiceProviderFactory<IServiceCollection> factory, Action<IApplicationBuilder> configureApp)
		{
			throw null;
		}

		public override void Configure(IApplicationBuilder app)
		{
			throw null;
		}
	}
}
