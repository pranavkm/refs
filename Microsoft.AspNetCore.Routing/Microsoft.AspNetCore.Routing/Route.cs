using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Routing
{
	public class Route : RouteBase
	{
		public string? RouteTemplate
		{
			[System.Runtime.CompilerServices.NullableContext(2)]
			get
			{
				throw null;
			}
		}

		public Route(IRouter target, string routeTemplate, IInlineConstraintResolver inlineConstraintResolver)
		{
			throw null;
		}

		public Route(IRouter target, string routeTemplate, RouteValueDictionary? defaults, IDictionary<string, object>? constraints, RouteValueDictionary? dataTokens, IInlineConstraintResolver inlineConstraintResolver)
		{
			throw null;
		}

		[System.Runtime.CompilerServices.NullableContext(2)]
		public Route(IRouter target, string? routeName, string? routeTemplate, RouteValueDictionary? defaults, IDictionary<string, object>? constraints, RouteValueDictionary? dataTokens, IInlineConstraintResolver inlineConstraintResolver)
		{
			throw null;
		}

		protected override Task OnRouteMatched(RouteContext context)
		{
			throw null;
		}

		protected override VirtualPathData? OnVirtualPathGenerated(VirtualPathContext context)
		{
			throw null;
		}
	}
}
