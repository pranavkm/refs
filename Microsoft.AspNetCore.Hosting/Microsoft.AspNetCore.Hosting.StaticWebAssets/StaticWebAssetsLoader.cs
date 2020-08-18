using Microsoft.Extensions.Configuration;
using System.IO;

namespace Microsoft.AspNetCore.Hosting.StaticWebAssets
{
	/// <summary>
	/// Loader for static web assets
	/// </summary>
	public class StaticWebAssetsLoader
	{
		internal const string StaticWebAssetsManifestName = "Microsoft.AspNetCore.StaticWebAssets.xml";

		/// <summary>
		/// Configure the <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostEnvironment" /> to use static web assets.
		/// </summary>
		/// <param name="environment">The application <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostEnvironment" />.</param>
		/// <param name="configuration">The host <see cref="T:Microsoft.Extensions.Configuration.IConfiguration" />.</param>
		public static void UseStaticWebAssets(IWebHostEnvironment environment, IConfiguration configuration)
		{
			throw null;
		}

		internal static void UseStaticWebAssetsCore(IWebHostEnvironment environment, Stream manifest)
		{
			throw null;
		}

		internal static Stream? ResolveManifest(IWebHostEnvironment environment, IConfiguration configuration)
		{
			throw null;
		}

		public StaticWebAssetsLoader()
		{
			throw null;
		}
	}
}
