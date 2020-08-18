using Microsoft.AspNetCore.Routing.Template;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.ObjectPool;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Routing.Tree
{
	/// <summary>
	/// Builder for <see cref="T:Microsoft.AspNetCore.Routing.Tree.TreeRouter" /> instances.
	/// </summary>
	public class TreeRouteBuilder
	{
		/// <summary>
		/// Gets the list of <see cref="T:Microsoft.AspNetCore.Routing.Tree.InboundRouteEntry" />.
		/// </summary>
		public IList<InboundRouteEntry> InboundEntries
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the list of <see cref="T:Microsoft.AspNetCore.Routing.Tree.OutboundRouteEntry" />.
		/// </summary>
		public IList<OutboundRouteEntry> OutboundEntries
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Initializes a new instance of <see cref="T:Microsoft.AspNetCore.Routing.Tree.TreeRouteBuilder" />.
		/// </summary>
		/// <param name="loggerFactory">The <see cref="T:Microsoft.Extensions.Logging.ILoggerFactory" />.</param>
		/// <param name="objectPool">The <see cref="T:Microsoft.Extensions.ObjectPool.ObjectPool`1" />.</param>
		/// <param name="constraintResolver">The <see cref="T:Microsoft.AspNetCore.Routing.IInlineConstraintResolver" />.</param>
		internal TreeRouteBuilder(ILoggerFactory loggerFactory, ObjectPool<UriBuildingContext> objectPool, IInlineConstraintResolver constraintResolver)
		{
			throw null;
		}

		/// <summary>
		/// Adds a new inbound route to the <see cref="T:Microsoft.AspNetCore.Routing.Tree.TreeRouter" />.
		/// </summary>
		/// <param name="handler">The <see cref="T:Microsoft.AspNetCore.Routing.IRouter" /> for handling the route.</param>
		/// <param name="routeTemplate">The <see cref="T:Microsoft.AspNetCore.Routing.Template.RouteTemplate" /> of the route.</param>
		/// <param name="routeName">The route name.</param>
		/// <param name="order">The route order.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Routing.Tree.InboundRouteEntry" />.</returns>
		public InboundRouteEntry MapInbound(IRouter handler, RouteTemplate routeTemplate, string routeName, int order)
		{
			throw null;
		}

		/// <summary>
		/// Adds a new outbound route to the <see cref="T:Microsoft.AspNetCore.Routing.Tree.TreeRouter" />.
		/// </summary>
		/// <param name="handler">The <see cref="T:Microsoft.AspNetCore.Routing.IRouter" /> for handling the link generation.</param>
		/// <param name="routeTemplate">The <see cref="T:Microsoft.AspNetCore.Routing.Template.RouteTemplate" /> of the route.</param>
		/// <param name="requiredLinkValues">The <see cref="T:Microsoft.AspNetCore.Routing.RouteValueDictionary" /> containing the route values.</param>
		/// <param name="routeName">The route name.</param>
		/// <param name="order">The route order.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Routing.Tree.OutboundRouteEntry" />.</returns>
		public OutboundRouteEntry MapOutbound(IRouter handler, RouteTemplate routeTemplate, RouteValueDictionary requiredLinkValues, string routeName, int order)
		{
			throw null;
		}

		/// <summary>
		/// Builds a <see cref="T:Microsoft.AspNetCore.Routing.Tree.TreeRouter" /> with the <see cref="P:Microsoft.AspNetCore.Routing.Tree.TreeRouteBuilder.InboundEntries" />
		/// and <see cref="P:Microsoft.AspNetCore.Routing.Tree.TreeRouteBuilder.OutboundEntries" /> defined in this <see cref="T:Microsoft.AspNetCore.Routing.Tree.TreeRouteBuilder" />.
		/// </summary>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Routing.Tree.TreeRouter" />.</returns>
		public TreeRouter Build()
		{
			throw null;
		}

		/// <summary>
		/// Builds a <see cref="T:Microsoft.AspNetCore.Routing.Tree.TreeRouter" /> with the <see cref="P:Microsoft.AspNetCore.Routing.Tree.TreeRouteBuilder.InboundEntries" />
		/// and <see cref="P:Microsoft.AspNetCore.Routing.Tree.TreeRouteBuilder.OutboundEntries" /> defined in this <see cref="T:Microsoft.AspNetCore.Routing.Tree.TreeRouteBuilder" />.
		/// </summary>
		/// <param name="version">The version of the <see cref="T:Microsoft.AspNetCore.Routing.Tree.TreeRouter" />.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Routing.Tree.TreeRouter" />.</returns>
		public TreeRouter Build(int version)
		{
			throw null;
		}

		/// <summary>
		/// Removes all <see cref="P:Microsoft.AspNetCore.Routing.Tree.TreeRouteBuilder.InboundEntries" /> and <see cref="P:Microsoft.AspNetCore.Routing.Tree.TreeRouteBuilder.OutboundEntries" /> from this
		/// <see cref="T:Microsoft.AspNetCore.Routing.Tree.TreeRouteBuilder" />.
		/// </summary>
		public void Clear()
		{
			throw null;
		}
	}
}
