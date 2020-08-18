using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Routing.Matching
{
	/// <summary>
	/// A <see cref="T:Microsoft.AspNetCore.Routing.MatcherPolicy" /> that implements filtering and selection by
	/// the host header of a request.
	/// </summary>
	public sealed class HostMatcherPolicy : MatcherPolicy, IEndpointComparerPolicy, INodeBuilderPolicy, IEndpointSelectorPolicy
	{
		private class HostMetadataEndpointComparer : EndpointMetadataComparer<IHostMetadata>
		{
			protected override int CompareMetadata(IHostMetadata? x, IHostMetadata? y)
			{
				throw null;
			}

			public HostMetadataEndpointComparer()
			{
				throw null;
			}
		}

		private class HostPolicyJumpTable : PolicyJumpTable
		{
			public HostPolicyJumpTable(int exitDestination, (EdgeKey host, int destination)[] destinations)
			{
				throw null;
			}

			public override int GetDestination(HttpContext httpContext)
			{
				throw null;
			}
		}

		private readonly struct EdgeKey : IEquatable<EdgeKey>, IComparable<EdgeKey>, IComparable
		{
			internal static readonly EdgeKey WildcardEdgeKey;

			public readonly int? Port;

			public readonly string Host;

			private readonly string? _wildcardEndsWith;

			public bool HasHostWildcard
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			public bool MatchesHost
			{
				get
				{
					throw null;
				}
			}

			public bool MatchesPort
			{
				get
				{
					throw null;
				}
			}

			public bool MatchesAll
			{
				get
				{
					throw null;
				}
			}

			[System.Runtime.CompilerServices.NullableContext(2)]
			public EdgeKey(string? host, int? port)
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

			public bool MatchHost(string host)
			{
				throw null;
			}

			public override int GetHashCode()
			{
				throw null;
			}

			public override bool Equals(object? obj)
			{
				throw null;
			}

			public override string ToString()
			{
				throw null;
			}
		}

		public override int Order
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public IComparer<Endpoint> Comparer
		{
			[CompilerGenerated]
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

		public Task ApplyAsync(HttpContext httpContext, CandidateSet candidates)
		{
			throw null;
		}

		public IReadOnlyList<PolicyNodeEdge> GetEdges(IReadOnlyList<Endpoint> endpoints)
		{
			throw null;
		}

		public PolicyJumpTable BuildJumpTable(int exitDestination, IReadOnlyList<PolicyJumpTableEdge> edges)
		{
			throw null;
		}

		public HostMatcherPolicy()
		{
			throw null;
		}
	}
}
