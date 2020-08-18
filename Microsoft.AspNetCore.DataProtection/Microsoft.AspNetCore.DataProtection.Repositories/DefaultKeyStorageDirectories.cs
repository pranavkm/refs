using System.IO;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.DataProtection.Repositories
{
	internal sealed class DefaultKeyStorageDirectories : IDefaultKeyStorageDirectories
	{
		public static IDefaultKeyStorageDirectories Instance
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// The default key storage directory.
		/// On Windows, this currently corresponds to "Environment.SpecialFolder.LocalApplication/ASP.NET/DataProtection-Keys".
		/// On Linux and macOS, this currently corresponds to "$HOME/.aspnet/DataProtection-Keys".
		/// </summary>
		/// <remarks>
		/// This property can return null if no suitable default key storage directory can
		/// be found, such as the case when the user profile is unavailable.
		/// </remarks>
		public DirectoryInfo GetKeyStorageDirectory()
		{
			throw null;
		}

		public DirectoryInfo GetKeyStorageDirectoryForAzureWebSites()
		{
			throw null;
		}
	}
}
