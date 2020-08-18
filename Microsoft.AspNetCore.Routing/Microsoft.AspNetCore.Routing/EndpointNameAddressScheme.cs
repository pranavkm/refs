using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.Routing
{
	internal sealed class EndpointNameAddressScheme : IEndpointAddressScheme<string>, IDisposable
	{
		internal Dictionary<string, Endpoint[]> Entries
		{
			get
			{
				throw null;
			}
		}

		public EndpointNameAddressScheme(EndpointDataSource dataSource)
		{
			throw null;
		}

		public IEnumerable<Endpoint> FindEndpoints(string address)
		{
			throw null;
		}

		public void Dispose()
		{
			throw null;
		}
	}
}
