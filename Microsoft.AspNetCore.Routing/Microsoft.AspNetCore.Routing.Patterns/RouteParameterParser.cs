namespace Microsoft.AspNetCore.Routing.Patterns
{
	internal static class RouteParameterParser
	{
		private enum ParseState
		{
			Start,
			ParsingName,
			InsideParenthesis,
			End
		}

		private readonly struct ParameterPolicyParseResults
		{
			public readonly int CurrentIndex;

			public readonly RoutePatternParameterPolicyReference[] ParameterPolicies;

			public ParameterPolicyParseResults(int currentIndex, RoutePatternParameterPolicyReference[] parameterPolicies)
			{
				throw null;
			}
		}

		public static RoutePatternParameterPart ParseRouteParameter(string parameter)
		{
			throw null;
		}
	}
}
