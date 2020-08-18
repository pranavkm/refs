using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Routing.Matching
{
	/// <summary>
	/// An <see cref="T:Microsoft.AspNetCore.Routing.MatcherPolicy" /> that implements filtering and selection by
	/// the HTTP method of a request.
	/// </summary>
	public sealed class HttpMethodMatcherPolicy : MatcherPolicy, IEndpointComparerPolicy, INodeBuilderPolicy, IEndpointSelectorPolicy
	{
		private class HttpMethodPolicyJumpTable : PolicyJumpTable
		{
			public HttpMethodPolicyJumpTable(int exitDestination, Dictionary<string, int>? destinations, int corsPreflightExitDestination, Dictionary<string, int>? corsPreflightDestinations)
			{
				throw null;
			}

			public override int GetDestination(HttpContext httpContext)
			{
				throw null;
			}
		}

		private class HttpMethodMetadataEndpointComparer : EndpointMetadataComparer<IHttpMethodMetadata>
		{
			protected override int CompareMetadata(IHttpMethodMetadata? x, IHttpMethodMetadata? y)
			{
				throw null;
			}

			public HttpMethodMetadataEndpointComparer()
			{
				throw null;
			}
		}

		internal readonly struct EdgeKey : IEquatable<EdgeKey>, IComparable<EdgeKey>, IComparable
		{
			public readonly bool IsCorsPreflightRequest;

			public readonly string HttpMethod;

			[System.Runtime.CompilerServices.NullableContext(1)]
			public EdgeKey(string httpMethod, bool isCorsPreflightRequest)
			{
				throw null;
			}

			public int CompareTo(EdgeKey other)
			{
				throw null;
			}

			public int CompareTo(object? obj)
			{
				throw null;
			}

			public bool Equals(EdgeKey other)
			{
				throw null;
			}

			public override bool Equals(object? obj)
			{
				throw null;
			}

			public override int GetHashCode()
			{
				throw null;
			}

			public override string ToString()
			{
				throw null;
			}
		}

		internal static readonly string OriginHeader;

		internal static readonly string AccessControlRequestMethod;

		internal static readonly string PreflightHttpMethod;

		internal const string Http405EndpointDisplayName = "405 HTTP Method Not Supported";

		internal const string AnyMethod = "*";

		/// <summary>
		/// For framework use only.
		/// </summary>
		public IComparer<Endpoint> Comparer
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// For framework use only.
		/// </summary>
		public override int Order
		{
			get
			{
				throw null;
			}
		}

		bool INodeBuilderPolicy.AppliesToEndpoints(IReadOnlyList<Endpoint> endpoints)
		{
			throw null;
		}

		bool IEndpointSelectorPolicy.AppliesToEndpoints(IReadOnlyList<Endpoint> endpoints)
		{
			throw null;
		}

		/// <summary>
		/// For framework use only.
		/// </summary>
		/// <param name="httpContext"></param>
		/// <param name="candidates"></param>
		/// <returns></returns>
		public Task ApplyAsync(HttpContext httpContext, CandidateSet candidates)
		{
			throw null;
		}

		/// <summary>
		/// For framework use only.
		/// </summary>
		/// <param name="endpoints"></param>
		/// <returns></returns>
		public IReadOnlyList<PolicyNodeEdge> GetEdges(IReadOnlyList<Endpoint> endpoints)
		{
			throw null;
		}

		/// <summary>
		/// For framework use only.
		/// </summary>
		/// <param name="exitDestination"></param>
		/// <param name="edges"></param>
		/// <returns></returns>
		public PolicyJumpTable BuildJumpTable(int exitDestination, IReadOnlyList<PolicyJumpTableEdge> edges)
		{
			throw null;
		}

		public HttpMethodMatcherPolicy()
		{
			throw null;
		}
	}
}
