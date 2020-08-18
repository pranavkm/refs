using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.AspNetCore.StaticFiles.Infrastructure;
using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Builder
{
	/// <summary>
	/// Options for serving static files
	/// </summary>
	public class StaticFileOptions : SharedOptionsBase
	{
		/// <summary>
		/// Used to map files to content-types.
		/// </summary>
		public IContentTypeProvider ContentTypeProvider
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
		/// The default content type for a request if the ContentTypeProvider cannot determine one.
		/// None is provided by default, so the client must determine the format themselves.
		/// http://www.w3.org/Protocols/rfc2616/rfc2616-sec7.html#sec7
		/// </summary>
		public string DefaultContentType
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
		/// If the file is not a recognized content-type should it be served?
		/// Default: false.
		/// </summary>
		public bool ServeUnknownFileTypes
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
		/// Indicates if files should be compressed for HTTPS requests when the Response Compression middleware is available.
		/// The default value is <see cref="F:Microsoft.AspNetCore.Http.Features.HttpsCompressionMode.Compress" />.
		/// </summary>
		/// <remarks>
		/// Enabling compression on HTTPS requests for remotely manipulable content may expose security problems.
		/// </remarks>
		public HttpsCompressionMode HttpsCompression
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
		/// Called after the status code and headers have been set, but before the body has been written.
		/// This can be used to add or change the response headers.
		/// </summary>
		public Action<StaticFileResponseContext> OnPrepareResponse
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
		/// Defaults to all request paths
		/// </summary>
		public StaticFileOptions()
		{
			throw null;
		}

		/// <summary>
		/// Defaults to all request paths
		/// </summary>
		/// <param name="sharedOptions"></param>
		public StaticFileOptions(SharedOptions sharedOptions)
		{
			throw null;
		}
	}
}
