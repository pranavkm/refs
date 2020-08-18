using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Routing.Matching
{
	internal sealed class DefaultEndpointSelector : EndpointSelector
	{
		public override Task SelectAsync(HttpContext httpContext, CandidateSet candidateSet)
		{
			throw null;
		}

		internal static void Select(HttpContext httpContext, CandidateState[] candidateState)
		{
			throw null;
		}

		public DefaultEndpointSelector()
		{
			throw null;
		}
	}
}
