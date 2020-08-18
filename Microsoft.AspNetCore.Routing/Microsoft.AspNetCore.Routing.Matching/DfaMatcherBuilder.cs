using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Routing.Matching
{
	internal class DfaMatcherBuilder : MatcherBuilder
	{
		internal EndpointComparer Comparer
		{
			get
			{
				throw null;
			}
		}

		internal bool UseCorrectCatchAllBehavior
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

		public DfaMatcherBuilder(ILoggerFactory loggerFactory, ParameterPolicyFactory parameterPolicyFactory, EndpointSelector selector, IEnumerable<MatcherPolicy> policies)
		{
			throw null;
		}

		public override void AddEndpoint(RouteEndpoint endpoint)
		{
			throw null;
		}

		public DfaNode BuildDfaTree(bool includeLabel = false)
		{
			throw null;
		}

		public override Matcher Build()
		{
			throw null;
		}

		internal Candidate[] CreateCandidates(IReadOnlyList<Endpoint> endpoints)
		{
			throw null;
		}

		internal Candidate CreateCandidate(Endpoint endpoint, int score)
		{
			throw null;
		}
	}
}
