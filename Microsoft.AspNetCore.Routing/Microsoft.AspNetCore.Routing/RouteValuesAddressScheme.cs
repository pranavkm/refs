using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing.Tree;
using System;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.Routing
{
	internal sealed class RouteValuesAddressScheme : IEndpointAddressScheme<RouteValuesAddress>, IDisposable
	{
		internal class StateEntry
		{
			public readonly List<OutboundMatch> AllMatches;

			public readonly LinkGenerationDecisionTree AllMatchesLinkGenerationTree;

			public readonly Dictionary<string, List<OutboundMatchResult>> NamedMatches;

			public StateEntry(List<OutboundMatch> allMatches, LinkGenerationDecisionTree allMatchesLinkGenerationTree, Dictionary<string, List<OutboundMatchResult>> namedMatches)
			{
				throw null;
			}
		}

		internal StateEntry State
		{
			get
			{
				throw null;
			}
		}

		public RouteValuesAddressScheme(EndpointDataSource dataSource)
		{
			throw null;
		}

		public IEnumerable<Endpoint> FindEndpoints(RouteValuesAddress address)
		{
			throw null;
		}

		public void Dispose()
		{
			throw null;
		}
	}
}
