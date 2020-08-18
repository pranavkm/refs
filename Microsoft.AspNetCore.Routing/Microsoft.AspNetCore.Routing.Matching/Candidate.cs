using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing.Patterns;
using System;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.Routing.Matching
{
	internal readonly struct Candidate
	{
		[Flags]
		public enum CandidateFlags
		{
			None = 0x0,
			HasDefaults = 0x1,
			HasCaptures = 0x2,
			HasCatchAll = 0x4,
			HasSlots = 0x7,
			HasComplexSegments = 0x8,
			HasConstraints = 0x10
		}

		public readonly Endpoint Endpoint;

		public readonly CandidateFlags Flags;

		public readonly KeyValuePair<string, object>[] Slots;

		public readonly (string parameterName, int segmentIndex, int slotIndex)[] Captures;

		public readonly (string parameterName, int segmentIndex, int slotIndex) CatchAll;

		public readonly (RoutePatternPathSegment pathSegment, int segmentIndex)[] ComplexSegments;

		public readonly KeyValuePair<string, IRouteConstraint>[] Constraints;

		public readonly int Score;

		public Candidate(Endpoint endpoint)
		{
			throw null;
		}

		public Candidate(Endpoint endpoint, int score, KeyValuePair<string, object>[] slots, (string parameterName, int segmentIndex, int slotIndex)[] captures, in (string parameterName, int segmentIndex, int slotIndex) catchAll, (RoutePatternPathSegment pathSegment, int segmentIndex)[] complexSegments, KeyValuePair<string, IRouteConstraint>[] constraints)
		{
			throw null;
		}
	}
}
