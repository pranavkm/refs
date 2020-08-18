using Microsoft.Extensions.Logging;
using Microsoft.Extensions.ObjectPool;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Routing.Tree
{
	/// <summary>
	/// An <see cref="T:Microsoft.AspNetCore.Routing.IRouter" /> implementation for attribute routing.
	/// </summary>
	public class TreeRouter : IRouter
	{
		public static readonly string RouteGroupKey;

		/// <summary>
		/// Gets the version of this route.
		/// </summary>
		public int Version
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		internal IEnumerable<UrlMatchingTree> MatchingTrees
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates a new instance of <see cref="T:Microsoft.AspNetCore.Routing.Tree.TreeRouter" />.
		/// </summary>
		/// <param name="trees">The list of <see cref="T:Microsoft.AspNetCore.Routing.Tree.UrlMatchingTree" /> that contains the route entries.</param>
		/// <param name="linkGenerationEntries">The set of <see cref="T:Microsoft.AspNetCore.Routing.Tree.OutboundRouteEntry" />.</param>
		/// <param name="urlEncoder">The <see cref="T:System.Text.Encodings.Web.UrlEncoder" />.</param>
		/// <param name="objectPool">The <see cref="T:Microsoft.Extensions.ObjectPool.ObjectPool`1" />.</param>
		/// <param name="routeLogger">The <see cref="T:Microsoft.Extensions.Logging.ILogger" /> instance.</param>
		/// <param name="constraintLogger">The <see cref="T:Microsoft.Extensions.Logging.ILogger" /> instance used
		/// in <see cref="T:Microsoft.AspNetCore.Routing.RouteConstraintMatcher" />.</param>
		/// <param name="version">The version of this route.</param>
		internal TreeRouter(UrlMatchingTree[] trees, IEnumerable<OutboundRouteEntry> linkGenerationEntries, UrlEncoder urlEncoder, ObjectPool<UriBuildingContext> objectPool, ILogger routeLogger, ILogger constraintLogger, int version)
		{
			throw null;
		}

		/// <inheritdoc />
		public VirtualPathData GetVirtualPath(VirtualPathContext context)
		{
			throw null;
		}

		/// <inheritdoc />
		[AsyncStateMachine(typeof(_003CRouteAsync_003Ed__13))]
		[DebuggerStepThrough]
		public Task RouteAsync(RouteContext context)
		{
			throw null;
		}
	}
}
