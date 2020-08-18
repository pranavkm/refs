using Microsoft.AspNetCore.Routing.Template;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Routing.Tree
{
	/// <summary>
	/// Used to build a <see cref="T:Microsoft.AspNetCore.Routing.Tree.TreeRouter" />. Represents a URL template that will be used to generate
	/// outgoing URLs.
	/// </summary>
	public class OutboundRouteEntry
	{
		/// <summary>
		/// Gets or sets the route constraints.
		/// </summary>
		public IDictionary<string, IRouteConstraint> Constraints
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
		/// Gets or sets the route defaults.
		/// </summary>
		public RouteValueDictionary Defaults
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
		/// The <see cref="T:Microsoft.AspNetCore.Routing.IRouter" /> to invoke when this entry matches.
		/// </summary>
		public IRouter Handler
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
		/// Gets or sets the order of the entry.
		/// </summary>
		/// <remarks>
		/// Entries are ordered first by <see cref="P:Microsoft.AspNetCore.Routing.Tree.OutboundRouteEntry.Order" /> (ascending) then by <see cref="P:Microsoft.AspNetCore.Routing.Tree.OutboundRouteEntry.Precedence" /> (descending).
		/// </remarks>
		public int Order
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
		/// Gets or sets the precedence of the template for link generation. A greater value of
		/// <see cref="P:Microsoft.AspNetCore.Routing.Tree.OutboundRouteEntry.Precedence" /> means that an entry is considered first.
		/// </summary>
		/// <remarks>
		/// Entries are ordered first by <see cref="P:Microsoft.AspNetCore.Routing.Tree.OutboundRouteEntry.Order" /> (ascending) then by <see cref="P:Microsoft.AspNetCore.Routing.Tree.OutboundRouteEntry.Precedence" /> (descending).
		/// </remarks>
		public decimal Precedence
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
		/// Gets or sets the name of the route.
		/// </summary>
		public string RouteName
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
		/// Gets or sets the set of values that must be present for link genration.
		/// </summary>
		public RouteValueDictionary RequiredLinkValues
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
		/// Gets or sets the <see cref="P:Microsoft.AspNetCore.Routing.Tree.OutboundRouteEntry.RouteTemplate" />.
		/// </summary>
		public RouteTemplate RouteTemplate
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
		/// Gets or sets the data that is associated with this entry.
		/// </summary>
		public object Data
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

		public OutboundRouteEntry()
		{
			throw null;
		}
	}
}
