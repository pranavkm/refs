using Microsoft.AspNetCore.Routing.Template;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Routing.Tree
{
	/// <summary>
	/// Used to build an <see cref="T:Microsoft.AspNetCore.Routing.Tree.TreeRouter" />. Represents a URL template tha will be used to match incoming
	/// request URLs.
	/// </summary>
	public class InboundRouteEntry
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
		/// Gets or sets the <see cref="T:Microsoft.AspNetCore.Routing.IRouter" /> to invoke when this entry matches.
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
		/// Entries are ordered first by <see cref="P:Microsoft.AspNetCore.Routing.Tree.InboundRouteEntry.Order" /> (ascending) then by <see cref="P:Microsoft.AspNetCore.Routing.Tree.InboundRouteEntry.Precedence" /> (descending).
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
		/// Gets or sets the precedence of the entry.
		/// </summary>
		/// <remarks>
		/// Entries are ordered first by <see cref="P:Microsoft.AspNetCore.Routing.Tree.InboundRouteEntry.Order" /> (ascending) then by <see cref="P:Microsoft.AspNetCore.Routing.Tree.InboundRouteEntry.Precedence" /> (descending).
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
		/// Gets or sets the <see cref="P:Microsoft.AspNetCore.Routing.Tree.InboundRouteEntry.RouteTemplate" />.
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

		public InboundRouteEntry()
		{
			throw null;
		}
	}
}
