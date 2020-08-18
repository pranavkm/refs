using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing.Patterns;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Routing
{
	public sealed class RouteEndpointBuilder : EndpointBuilder
	{
		public RoutePattern RoutePattern
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public int Order
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public RouteEndpointBuilder(RequestDelegate requestDelegate, RoutePattern routePattern, int order)
		{
			throw null;
		}

		public override Endpoint Build()
		{
			throw null;
		}
	}
}
