using Microsoft.AspNetCore.Routing.DecisionTree;
using System.Collections.Generic;
using System.Diagnostics;

namespace Microsoft.AspNetCore.Routing.Tree
{
	[DebuggerDisplay("{DebuggerDisplayString,nq}")]
	internal class LinkGenerationDecisionTree
	{
		private class OutboundMatchClassifier : IClassifier<OutboundMatch>
		{
			public IEqualityComparer<object> ValueComparer
			{
				get
				{
					throw null;
				}
			}

			public IDictionary<string, DecisionCriterionValue> GetCriteria(OutboundMatch item)
			{
				throw null;
			}

			public OutboundMatchClassifier()
			{
				throw null;
			}
		}

		private class OutboundMatchResultComparer : IComparer<OutboundMatchResult>
		{
			public static readonly OutboundMatchResultComparer Instance;

			public int Compare(OutboundMatchResult x, OutboundMatchResult y)
			{
				throw null;
			}

			public OutboundMatchResultComparer()
			{
				throw null;
			}
		}

		internal string DebuggerDisplayString
		{
			get
			{
				throw null;
			}
		}

		public LinkGenerationDecisionTree(IReadOnlyList<OutboundMatch> entries)
		{
			throw null;
		}

		public IList<OutboundMatchResult> GetMatches(RouteValueDictionary values, RouteValueDictionary ambientValues)
		{
			throw null;
		}
	}
}
