using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.FileProviders;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.StaticFiles.Infrastructure
{
	/// <summary>
	/// Options common to several middleware components
	/// </summary>
	public abstract class SharedOptionsBase
	{
		/// <summary>
		/// Options common to several middleware components
		/// </summary>
		protected SharedOptions SharedOptions
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// The relative request path that maps to static resources.
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
		/// Indicates whether to redirect to add a trailing slash at the end of path. Relative resource links may require this.
		/// </summary>
		public bool RedirectToAppendTrailingSlash
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
		/// Creates an new instance of the SharedOptionsBase.
		/// </summary>
		/// <param name="sharedOptions"></param>
		protected SharedOptionsBase(SharedOptions sharedOptions)
		{
			throw null;
		}
	}
}
