using System;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.Routing
{
	internal static class ParameterPolicyActivator
	{
		public static T ResolveParameterPolicy<T>(IDictionary<string, Type> inlineParameterPolicyMap, IServiceProvider serviceProvider, string inlineParameterPolicy, out string parameterPolicyKey) where T : IParameterPolicy
		{
			throw null;
		}
	}
}
