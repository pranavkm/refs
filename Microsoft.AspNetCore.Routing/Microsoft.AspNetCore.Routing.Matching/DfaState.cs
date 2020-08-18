using System.Diagnostics;

namespace Microsoft.AspNetCore.Routing.Matching
{
	[DebuggerDisplay("{DebuggerToString(),nq}")]
	internal readonly struct DfaState
	{
		public readonly Candidate[] Candidates;

		public readonly IEndpointSelectorPolicy[] Policies;

		public readonly JumpTable PathTransitions;

		public readonly PolicyJumpTable PolicyTransitions;

		public DfaState(Candidate[] candidates, IEndpointSelectorPolicy[] policies, JumpTable pathTransitions, PolicyJumpTable policyTransitions)
		{
			throw null;
		}

		public string DebuggerToString()
		{
			throw null;
		}
	}
}
