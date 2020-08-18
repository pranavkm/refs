using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Microsoft.AspNetCore.Hosting
{
	internal class ConventionBasedStartup : IStartup
	{
		public ConventionBasedStartup(StartupMethods methods)
		{
			throw null;
		}

		public void Configure(IApplicationBuilder app)
		{
			throw null;
		}

		public IServiceProvider ConfigureServices(IServiceCollection services)
		{
			throw null;
		}
	}
}
