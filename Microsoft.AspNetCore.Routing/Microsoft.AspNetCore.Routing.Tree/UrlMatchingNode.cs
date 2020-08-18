using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Routing.Tree
{
	/// <summary>
	/// A node in a <see cref="T:Microsoft.AspNetCore.Routing.Tree.UrlMatchingTree" />.
	/// </summary>
	[DebuggerDisplay("{DebuggerToString(),nq}")]
	public class UrlMatchingNode
	{
		/// <summary>
		/// Gets the length of the path to this node in the <see cref="T:Microsoft.AspNetCore.Routing.Tree.UrlMatchingTree" />.
		/// </summary>
		public int Depth
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether this node represents a catch all segment.
		/// </summary>
		public bool IsCatchAll
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

		/// <summary>
		/// Gets the list of matching route entries associated with this node.
		/// </summary>
		/// <remarks>
		/// These entries are sorted by precedence then template.
		/// </remarks>
		public List<InboundMatch> Matches
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the literal segments following this segment.
		/// </summary>
		public Dictionary<string, UrlMatchingNode> Literals
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets the <see cref="T:Microsoft.AspNetCore.Routing.Tree.UrlMatchingNode" /> representing
		/// parameter segments with constraints following this segment in the <see cref="T:Microsoft.AspNetCore.Routing.Tree.TreeRouter" />.
		/// </summary>
		public UrlMatchingNode ConstrainedParameters
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

		/// <summary>
		/// Gets or sets the <see cref="T:Microsoft.AspNetCore.Routing.Tree.UrlMatchingNode" /> representing
		/// parameter segments following this segment in the <see cref="T:Microsoft.AspNetCore.Routing.Tree.TreeRouter" />.
		/// </summary>
		public UrlMatchingNode Parameters
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

		/// <summary>
		/// Gets or sets the <see cref="T:Microsoft.AspNetCore.Routing.Tree.UrlMatchingNode" /> representing
		/// catch all parameter segments with constraints following this segment in the <see cref="T:Microsoft.AspNetCore.Routing.Tree.TreeRouter" />.
		/// </summary>
		public UrlMatchingNode ConstrainedCatchAlls
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

		/// <summary>
		/// Gets or sets the <see cref="T:Microsoft.AspNetCore.Routing.Tree.UrlMatchingNode" /> representing
		/// catch all parameter segments following this segment in the <see cref="T:Microsoft.AspNetCore.Routing.Tree.TreeRouter" />.
		/// </summary>
		public UrlMatchingNode CatchAlls
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

		/// <summary>
		/// Initializes a new instance of <see cref="T:Microsoft.AspNetCore.Routing.Tree.UrlMatchingNode" />.
		/// </summary>
		/// <param name="length">The length of the path to this node in the <see cref="T:Microsoft.AspNetCore.Routing.Tree.UrlMatchingTree" />.</param>
		public UrlMatchingNode(int length)
		{
			throw null;
		}
	}
}
