using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Options;
using System.Collections.Generic;

namespace Microsoft.Extensions.DependencyInjection
{
	internal class ConfigureRouteOptions : IConfigureOptions<RouteOptions>
	{
		public ConfigureRouteOptions(ICollection<EndpointDataSource> dataSources)
		{
			throw null;
		}

		public void Configure(RouteOptions options)
		{
			throw null;
		}
	}
}
