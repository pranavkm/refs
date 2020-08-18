using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Routing.Matching
{
	/// <summary>
	/// Represents a set of <see cref="T:Microsoft.AspNetCore.Http.Endpoint" /> candidates that have been matched
	/// by the routing system. Used by implementations of <see cref="T:Microsoft.AspNetCore.Routing.Matching.EndpointSelector" />
	/// and <see cref="T:Microsoft.AspNetCore.Routing.Matching.IEndpointSelectorPolicy" />.
	/// </summary>
	public sealed class CandidateSet
	{
		internal CandidateState[] Candidates;

		/// <summary>
		/// Gets the count of candidates in the set.
		/// </summary>
		public int Count
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the <see cref="T:Microsoft.AspNetCore.Routing.Matching.CandidateState" /> associated with the candidate <see cref="T:Microsoft.AspNetCore.Http.Endpoint" />
		/// at <paramref name="index" />.
		/// </summary>
		/// <param name="index">The candidate index.</param>
		/// <returns>
		/// A reference to the <see cref="T:Microsoft.AspNetCore.Routing.Matching.CandidateState" />. The result is returned by reference.
		/// </returns>
		public ref CandidateState this[int index]
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// <para>
		/// Initializes a new instances of the <see cref="T:Microsoft.AspNetCore.Routing.Matching.CandidateSet" /> class with the provided <paramref name="endpoints" />,
		/// <paramref name="values" />, and <paramref name="scores" />.
		/// </para>
		/// <para>
		/// The constructor is provided to enable unit tests of implementations of <see cref="T:Microsoft.AspNetCore.Routing.Matching.EndpointSelector" />
		/// and <see cref="T:Microsoft.AspNetCore.Routing.Matching.IEndpointSelectorPolicy" />.
		/// </para>
		/// </summary>
		/// <param name="endpoints">The list of endpoints, sorted in descending priority order.</param>
		/// <param name="values">The list of <see cref="T:Microsoft.AspNetCore.Routing.RouteValueDictionary" /> instances.</param>
		/// <param name="scores">The list of endpoint scores. <see cref="P:Microsoft.AspNetCore.Routing.Matching.CandidateState.Score" />.</param>
		public CandidateSet(Endpoint[] endpoints, RouteValueDictionary[] values, int[] scores)
		{
			throw null;
		}

		internal CandidateSet(Candidate[] candidates)
		{
			throw null;
		}

		internal CandidateSet(CandidateState[] candidates)
		{
			throw null;
		}

		/// <summary>
		/// Gets a value which indicates where the <see cref="T:Microsoft.AspNetCore.Http.Endpoint" /> is considered
		/// a valid candiate for the current request.
		/// </summary>
		/// <param name="index">The candidate index.</param>
		/// <returns>
		/// <c>true</c> if the candidate at position <paramref name="index" /> is considered valid
		/// for the current request, otherwise <c>false</c>.
		/// </returns>
		public bool IsValidCandidate(int index)
		{
			throw null;
		}

		internal static bool IsValidCandidate(ref CandidateState candidate)
		{
			throw null;
		}

		/// <summary>
		/// Sets the validitity of the candidate at the provided index.
		/// </summary>
		/// <param name="index">The candidate index.</param>
		/// <param name="value">
		/// The value to set. If <c>true</c> the candidate is considered valid for the current request.
		/// </param>
		public void SetValidity(int index, bool value)
		{
			throw null;
		}

		internal static void SetValidity(ref CandidateState candidate, bool value)
		{
			throw null;
		}

		/// <summary>
		/// Replaces the <see cref="T:Microsoft.AspNetCore.Http.Endpoint" /> at the provided <paramref name="index" /> with the
		/// provided <paramref name="endpoint" />.
		/// </summary>
		/// <param name="index">The candidate index.</param>
		/// <param name="endpoint">
		/// The <see cref="T:Microsoft.AspNetCore.Http.Endpoint" /> to replace the original <see cref="T:Microsoft.AspNetCore.Http.Endpoint" /> at
		/// the <paramref name="index" />. If <paramref name="endpoint" /> is <c>null</c>. the candidate will be marked
		/// as invalid.
		/// </param>
		/// <param name="values">
		/// The <see cref="T:Microsoft.AspNetCore.Routing.RouteValueDictionary" /> to replace the original <see cref="T:Microsoft.AspNetCore.Routing.RouteValueDictionary" /> at
		/// the <paramref name="index" />.
		/// </param>
		public void ReplaceEndpoint(int index, Endpoint? endpoint, RouteValueDictionary? values)
		{
			throw null;
		}

		/// <summary>
		/// Replaces the <see cref="T:Microsoft.AspNetCore.Http.Endpoint" /> at the provided <paramref name="index" /> with the
		/// provided <paramref name="endpoints" />.
		/// </summary>
		/// <param name="index">The candidate index.</param>
		/// <param name="endpoints">
		/// The list of endpoints <see cref="T:Microsoft.AspNetCore.Http.Endpoint" /> to replace the original <see cref="T:Microsoft.AspNetCore.Http.Endpoint" /> at
		/// the <paramref name="index" />. If <paramref name="endpoints" /> is empty, the candidate will be marked
		/// as invalid.
		/// </param>
		/// <param name="comparer">
		/// The endpoint comparer used to order the endpoints. Can be retrieved from the service provider as
		/// type <see cref="T:Microsoft.AspNetCore.Routing.Matching.EndpointMetadataComparer" />.
		/// </param>
		/// <remarks>
		/// <para>
		/// This method supports replacing a dynamic endpoint with a collection of endpoints, and relying on
		/// <see cref="T:Microsoft.AspNetCore.Routing.Matching.IEndpointSelectorPolicy" /> implementations to disambiguate further.
		/// </para>
		/// <para>
		/// The endpoint being replace should have a unique score value. The score is the combination of route
		/// patter precedence, order, and policy metadata evaluation. A dynamic endpoint will not function
		/// correctly if other endpoints exist with the same score.
		/// </para>
		/// </remarks>
		public void ExpandEndpoint(int index, IReadOnlyList<Endpoint> endpoints, IComparer<Endpoint> comparer)
		{
			throw null;
		}
	}
}
