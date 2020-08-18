using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http.Features;
using System;

namespace Microsoft.AspNetCore.Hosting.Builder
{
	public class ApplicationBuilderFactory : IApplicationBuilderFactory
	{
		public ApplicationBuilderFactory(IServiceProvider serviceProvider)
		{
			throw null;
		}

		public IApplicationBuilder CreateBuilder(IFeatureCollection serverFeatures)
		{
			throw null;
		}
	}
}
