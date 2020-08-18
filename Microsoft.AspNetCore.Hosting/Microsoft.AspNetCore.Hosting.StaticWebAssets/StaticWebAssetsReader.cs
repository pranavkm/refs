using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Hosting.StaticWebAssets
{
	internal static class StaticWebAssetsReader
	{
		internal readonly struct ContentRootMapping
		{
			public string BasePath
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			public string Path
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			public ContentRootMapping(string basePath, string path)
			{
				throw null;
			}
		}

		[IteratorStateMachine(typeof(_003CParse_003Ed__3))]
		internal static IEnumerable<ContentRootMapping> Parse(Stream manifest)
		{
			throw null;
		}
	}
}
