using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.StaticFiles
{
	/// <summary>
	/// Provides a mapping between file extensions and MIME types.
	/// </summary>
	public class FileExtensionContentTypeProvider : IContentTypeProvider
	{
		/// <summary>
		/// The cross reference table of file extensions and content-types.
		/// </summary>
		public IDictionary<string, string> Mappings
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates a new provider with a set of default mappings.
		/// </summary>
		public FileExtensionContentTypeProvider()
		{
			throw null;
		}

		/// <summary>
		/// Creates a lookup engine using the provided mapping.
		/// It is recommended that the IDictionary instance use StringComparer.OrdinalIgnoreCase.
		/// </summary>
		/// <param name="mapping"></param>
		public FileExtensionContentTypeProvider(IDictionary<string, string> mapping)
		{
			throw null;
		}

		/// <summary>
		/// Given a file path, determine the MIME type
		/// </summary>
		/// <param name="subpath">A file path</param>
		/// <param name="contentType">The resulting MIME type</param>
		/// <returns>True if MIME type could be determined</returns>
		public bool TryGetContentType(string subpath, out string contentType)
		{
			throw null;
		}
	}
}
