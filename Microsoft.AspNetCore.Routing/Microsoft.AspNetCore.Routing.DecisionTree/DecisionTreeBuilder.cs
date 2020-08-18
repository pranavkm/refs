using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Routing.DecisionTree
{
	internal static class DecisionTreeBuilder<TItem>
	{
		private class TreeBuilderContext
		{
			public HashSet<string> CurrentCriteria
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			public HashSet<ItemDescriptor<TItem>> MatchedItems
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			public TreeBuilderContext()
			{
				throw null;
			}

			public TreeBuilderContext(TreeBuilderContext other)
			{
				throw null;
			}
		}

		private class Criterion : Dictionary<DecisionCriterionValue, List<ItemDescriptor<TItem>>>
		{
			public Criterion(DecisionCriterionValueEqualityComparer comparer)
			{
				throw null;
			}
		}

		public static DecisionTreeNode<TItem> GenerateTree(IReadOnlyList<TItem> items, IClassifier<TItem> classifier)
		{
			throw null;
		}
	}
}
