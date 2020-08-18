using System.Collections.Generic;

namespace Microsoft.AspNetCore.Components.Rendering
{
	/// <summary>
	/// This comparer is optimized for use with dictionaries where the great majority of insertions/lookups
	/// don't match existing entries. For example, when building a dictionary of almost entirely unique keys.
	/// It's faster than the normal string comparer in this case because it doesn't use string.GetHashCode,
	/// and hence doesn't have to consider every character in the string.
	///
	/// This primary scenario is <see cref="M:Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder.ProcessDuplicateAttributes(System.Int32)" />, which needs
	/// to detect when one attribute is overriding another, but in the vast majority of cases attributes don't
	/// actually override each other.
	/// </summary>
	internal class SimplifiedStringHashComparer : IEqualityComparer<string>
	{
		public static readonly SimplifiedStringHashComparer Instance;

		public bool Equals(string? x, string? y)
		{
			throw null;
		}

		public int GetHashCode(string key)
		{
			throw null;
		}

		public SimplifiedStringHashComparer()
		{
			throw null;
		}
	}
}
