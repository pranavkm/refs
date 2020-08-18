using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Microsoft.Extensions.Localization
{
	/// <summary>
	/// This API supports infrastructure and is not intended to be used
	/// directly from your code. This API may change or be removed in future releases.
	/// </summary>
	internal class ResourceManagerStringProvider : IResourceStringProvider
	{
		public ResourceManagerStringProvider(IResourceNamesCache resourceCache, ResourceManager resourceManager, Assembly assembly, string baseName)
		{
			throw null;
		}

		public IList<string>? GetAllResourceStrings(CultureInfo culture, bool throwOnMissing)
		{
			throw null;
		}
	}
}
