using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.FileProviders;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.StaticFiles.Infrastructure
{
	/// <summary>
	/// Options common to several middleware components
	/// </summary>
	public class SharedOptions
	{
		/// <summary>
		/// The request path that maps to static resources
		/// </summary>
		public PathString RequestPath
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// The file system used to locate resources
		/// </summary>
		public IFileProvider FileProvider
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
		/// Indicates whether to redirect to add a trailing slash at the end of path. Relative resource links may require this.
		/// </summary>
		public bool RedirectToAppendTrailingSlash
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
		/// Defaults to all request paths.
		/// </summary>
		public SharedOptions()
		{
			throw null;
		}
	}
}
