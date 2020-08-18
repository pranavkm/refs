using Microsoft.AspNetCore.Http;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Routing.Matching
{
	/// <summary>
	/// The state associated with a candidate in a <see cref="T:Microsoft.AspNetCore.Routing.Matching.CandidateSet" />.
	/// </summary>
	public struct CandidateState
	{
		/// <summary>
		/// Gets the <see cref="T:Microsoft.AspNetCore.Http.Endpoint" />.
		/// </summary>
		public Endpoint Endpoint
		{
			[CompilerGenerated]
			readonly get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the score of the <see cref="T:Microsoft.AspNetCore.Http.Endpoint" /> within the current
		/// <see cref="T:Microsoft.AspNetCore.Routing.Matching.CandidateSet" />.
		/// </summary>
		/// <remarks>
		/// <para>
		/// Candidates within a set are ordered in priority order and then assigned a
		/// sequential score value based on that ordering. Candiates with the same
		/// score are considered to have equal priority.
		/// </para>
		/// <para>
		/// The score values are used in the <see cref="T:Microsoft.AspNetCore.Routing.Matching.EndpointSelector" /> to determine
		/// whether a set of matching candidates is an ambiguous match.
		/// </para>
		/// </remarks>
		public int Score
		{
			[CompilerGenerated]
			readonly get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets <see cref="T:Microsoft.AspNetCore.Routing.RouteValueDictionary" /> associated with the
		/// <see cref="T:Microsoft.AspNetCore.Http.Endpoint" /> and the current request.
		/// </summary>
		public RouteValueDictionary? Values
		{
			[System.Runtime.CompilerServices.NullableContext(2)]
			[CompilerGenerated]
			readonly get
			{
				throw null;
			}
			[System.Runtime.CompilerServices.NullableContext(2)]
			[CompilerGenerated]
			internal set
			{
				throw null;
			}
		}

		internal CandidateState(Endpoint endpoint, int score)
		{
			throw null;
		}

		internal CandidateState(Endpoint endpoint, RouteValueDictionary? values, int score)
		{
			throw null;
		}
	}
}
