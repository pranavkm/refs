using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.Routing.Matching
{
	public interface INodeBuilderPolicy
	{
		bool AppliesToEndpoints(IReadOnlyList<Endpoint> endpoints);

		IReadOnlyList<PolicyNodeEdge> GetEdges(IReadOnlyList<Endpoint> endpoints);

		PolicyJumpTable BuildJumpTable(int exitDestination, IReadOnlyList<PolicyJumpTableEdge> edges);
	}
}
