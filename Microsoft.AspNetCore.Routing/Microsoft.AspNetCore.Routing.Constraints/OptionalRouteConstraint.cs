using Microsoft.AspNetCore.Http;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Routing.Constraints
{
	/// <summary>
	/// Defines a constraint on an optional parameter. If the parameter is present, then it is constrained by InnerConstraint. 
	/// </summary>
	public class OptionalRouteConstraint : IRouteConstraint, IParameterPolicy
	{
		public IRouteConstraint InnerConstraint
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public OptionalRouteConstraint(IRouteConstraint innerConstraint)
		{
			throw null;
		}

		public bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
		{
			throw null;
		}
	}
}
