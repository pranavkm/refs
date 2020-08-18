using Microsoft.AspNetCore.Http;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Microsoft.AspNetCore.Routing.Constraints
{
	public class RegexRouteConstraint : IRouteConstraint, IParameterPolicy
	{
		public Regex Constraint
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public RegexRouteConstraint(Regex regex)
		{
			throw null;
		}

		public RegexRouteConstraint(string regexPattern)
		{
			throw null;
		}

		public bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
		{
			throw null;
		}
	}
}
