using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.Routing
{
	internal class ModelEndpointDataSource : EndpointDataSource
	{
		public override IReadOnlyList<Endpoint> Endpoints
		{
			get
			{
				throw null;
			}
		}

		internal IEnumerable<EndpointBuilder> EndpointBuilders
		{
			get
			{
				throw null;
			}
		}

		public ModelEndpointDataSource()
		{
			throw null;
		}

		public IEndpointConventionBuilder AddEndpointBuilder(EndpointBuilder endpointBuilder)
		{
			throw null;
		}

		public override IChangeToken GetChangeToken()
		{
			throw null;
		}
	}
}
