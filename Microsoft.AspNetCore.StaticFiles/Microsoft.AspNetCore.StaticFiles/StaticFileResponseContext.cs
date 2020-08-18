using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.FileProviders;
using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.StaticFiles
{
	/// <summary>
	/// Contains information about the request and the file that will be served in response.
	/// </summary>
	public class StaticFileResponseContext
	{
		/// <summary>
		/// The request and response information.
		/// </summary>
		public HttpContext Context
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// The file to be served.
		/// </summary>
		public IFileInfo File
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Constructs the <see cref="T:Microsoft.AspNetCore.StaticFiles.StaticFileResponseContext" />.
		/// </summary>
		[Obsolete("Use the constructor that passes in the HttpContext and IFileInfo parameters: StaticFileResponseContext(HttpContext context, IFileInfo file)", false)]
		public StaticFileResponseContext()
		{
			throw null;
		}

		/// <summary>
		/// Constructs the <see cref="T:Microsoft.AspNetCore.StaticFiles.StaticFileResponseContext" />.
		/// </summary>
		/// <param name="context">The request and response information.</param>
		/// <param name="file">The file to be served.</param>
		public StaticFileResponseContext(HttpContext context, IFileInfo file)
		{
			throw null;
		}
	}
}
