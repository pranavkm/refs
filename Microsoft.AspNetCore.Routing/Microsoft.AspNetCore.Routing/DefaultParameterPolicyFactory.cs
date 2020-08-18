using Microsoft.AspNetCore.Routing.Patterns;
using Microsoft.Extensions.Options;
using System;

namespace Microsoft.AspNetCore.Routing
{
	internal class DefaultParameterPolicyFactory : ParameterPolicyFactory
	{
		public DefaultParameterPolicyFactory(IOptions<RouteOptions> options, IServiceProvider serviceProvider)
		{
			throw null;
		}

		public override IParameterPolicy Create(RoutePatternParameterPart? parameter, IParameterPolicy parameterPolicy)
		{
			throw null;
		}

		public override IParameterPolicy Create(RoutePatternParameterPart? parameter, string inlineText)
		{
			throw null;
		}
	}
}
