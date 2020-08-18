using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing.Patterns;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Routing.Matching
{
	internal sealed class DfaMatcher : Matcher
	{
		internal static class EventIds
		{
			public static readonly EventId CandidatesNotFound;

			public static readonly EventId CandidatesFound;

			public static readonly EventId CandidateRejectedByComplexSegment;

			public static readonly EventId CandidateRejectedByConstraint;

			public static readonly EventId CandidateNotValid;

			public static readonly EventId CandidateValid;
		}

		private static class Logger
		{
			public static void CandidatesNotFound(ILogger logger, string path)
			{
				throw null;
			}

			public static void CandidatesFound(ILogger logger, string path, Candidate[] candidates)
			{
				throw null;
			}

			public static void CandidateRejectedByComplexSegment(ILogger logger, string path, Endpoint endpoint, RoutePatternPathSegment segment)
			{
				throw null;
			}

			public static void CandidateRejectedByConstraint(ILogger logger, string path, Endpoint endpoint, string constraintName, IRouteConstraint constraint, object value)
			{
				throw null;
			}

			public static void CandidateNotValid(ILogger logger, string path, Endpoint endpoint)
			{
				throw null;
			}

			public static void CandidateValid(ILogger logger, string path, Endpoint endpoint)
			{
				throw null;
			}
		}

		public DfaMatcher(ILogger<DfaMatcher> logger, EndpointSelector selector, DfaState[] states, int maxSegmentCount)
		{
			throw null;
		}

		public sealed override Task MatchAsync(HttpContext httpContext)
		{
			throw null;
		}

		internal (Candidate[] candidates, IEndpointSelectorPolicy[] policies) FindCandidateSet(HttpContext httpContext, string path, ReadOnlySpan<PathSegment> segments)
		{
			throw null;
		}
	}
}
