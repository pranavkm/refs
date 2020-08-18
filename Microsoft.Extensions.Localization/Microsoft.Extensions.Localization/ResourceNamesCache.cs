using System;
using System.Collections.Generic;

namespace Microsoft.Extensions.Localization
{
	/// <summary>
	/// An implementation of <see cref="T:Microsoft.Extensions.Localization.IResourceNamesCache" /> backed by a <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />.
	/// </summary>
	public class ResourceNamesCache : IResourceNamesCache
	{
		/// <summary>
		/// Creates a new <see cref="T:Microsoft.Extensions.Localization.ResourceNamesCache" />
		/// </summary>
		public ResourceNamesCache()
		{
			throw null;
		}

		/// <inheritdoc />
		public IList<string>? GetOrAdd(string name, Func<string, IList<string>?> valueFactory)
		{
			throw null;
		}
	}
}
