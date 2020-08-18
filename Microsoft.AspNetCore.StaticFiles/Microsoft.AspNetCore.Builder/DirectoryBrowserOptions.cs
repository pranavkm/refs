using Microsoft.AspNetCore.StaticFiles;
using Microsoft.AspNetCore.StaticFiles.Infrastructure;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Builder
{
	/// <summary>
	/// Directory browsing options
	/// </summary>
	public class DirectoryBrowserOptions : SharedOptionsBase
	{
		/// <summary>
		/// The component that generates the view.
		/// </summary>
		public IDirectoryFormatter Formatter
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Enabled directory browsing for all request paths
		/// </summary>
		public DirectoryBrowserOptions()
		{
			throw null;
		}

		/// <summary>
		/// Enabled directory browsing all request paths
		/// </summary>
		/// <param name="sharedOptions"></param>
		public DirectoryBrowserOptions(SharedOptions sharedOptions)
		{
			throw null;
		}
	}
}
