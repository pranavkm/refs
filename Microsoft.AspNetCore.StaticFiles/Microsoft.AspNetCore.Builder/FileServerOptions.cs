using Microsoft.AspNetCore.StaticFiles.Infrastructure;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Builder
{
	/// <summary>
	/// Options for all of the static file middleware components
	/// </summary>
	public class FileServerOptions : SharedOptionsBase
	{
		/// <summary>
		/// Options for configuring the StaticFileMiddleware.
		/// </summary>
		public StaticFileOptions StaticFileOptions
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Options for configuring the DirectoryBrowserMiddleware.
		/// </summary>
		public DirectoryBrowserOptions DirectoryBrowserOptions
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Options for configuring the DefaultFilesMiddleware.
		/// </summary>
		public DefaultFilesOptions DefaultFilesOptions
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Directory browsing is disabled by default.
		/// </summary>
		public bool EnableDirectoryBrowsing
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
		/// Default files are enabled by default.
		/// </summary>
		public bool EnableDefaultFiles
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
		/// Creates a combined options class for all of the static file middleware components.
		/// </summary>
		public FileServerOptions()
		{
			throw null;
		}
	}
}
