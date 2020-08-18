using Microsoft.AspNetCore.Routing.Template;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.Routing
{
	public static class InlineRouteParameterParser
	{
		private enum ParseState
		{
			Start,
			ParsingName,
			InsideParenthesis,
			End
		}

		private readonly struct ConstraintParseResults
		{
			public readonly int CurrentIndex;

			public readonly IEnumerable<InlineConstraint> Constraints;

			public ConstraintParseResults(int currentIndex, IEnumerable<InlineConstraint> constraints)
			{
				throw null;
			}
		}

		public static TemplatePart ParseRouteParameter(string routeParameter)
		{
			throw null;
		}
	}
}
