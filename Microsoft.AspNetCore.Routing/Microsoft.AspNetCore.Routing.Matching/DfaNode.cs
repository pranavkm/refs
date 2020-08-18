using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Routing.Matching
{
	[DebuggerDisplay("{DebuggerToString(),nq}")]
	internal class DfaNode
	{
		public int PathDepth
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

		public string Label
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

		public List<Endpoint> Matches
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public Dictionary<string, DfaNode> Literals
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public DfaNode Parameters
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

		public DfaNode CatchAll
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

		public INodeBuilderPolicy NodeBuilder
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

		public Dictionary<object, DfaNode> PolicyEdges
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public void AddPolicyEdge(object state, DfaNode node)
		{
			throw null;
		}

		public void AddLiteral(string literal, DfaNode node)
		{
			throw null;
		}

		public void AddMatch(Endpoint endpoint)
		{
			throw null;
		}

		public void AddMatches(IEnumerable<Endpoint> endpoints)
		{
			throw null;
		}

		public void Visit(Action<DfaNode> visitor)
		{
			throw null;
		}

		public DfaNode()
		{
			throw null;
		}
	}
}
