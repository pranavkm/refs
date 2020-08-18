using Microsoft.Net.Http.Headers;
using System.IO;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.WebUtilities
{
	/// <summary>
	/// Represents a file multipart section
	/// </summary>
	public class FileMultipartSection
	{
		/// <summary>
		/// Gets the original section from which this object was created
		/// </summary>
		public MultipartSection Section
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the file stream from the section body
		/// </summary>
		public Stream? FileStream
		{
			[System.Runtime.CompilerServices.NullableContext(2)]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the name of the section
		/// </summary>
		public string Name
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the name of the file from the section
		/// </summary>
		public string FileName
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates a new instance of the <see cref="T:Microsoft.AspNetCore.WebUtilities.FileMultipartSection" /> class
		/// </summary>
		/// <param name="section">The section from which to create the <see cref="T:Microsoft.AspNetCore.WebUtilities.FileMultipartSection" /></param>
		/// <remarks>Reparses the content disposition header</remarks>
		public FileMultipartSection(MultipartSection section)
		{
			throw null;
		}

		/// <summary>
		/// Creates a new instance of the <see cref="T:Microsoft.AspNetCore.WebUtilities.FileMultipartSection" /> class
		/// </summary>
		/// <param name="section">The section from which to create the <see cref="T:Microsoft.AspNetCore.WebUtilities.FileMultipartSection" /></param>
		/// <param name="header">An already parsed content disposition header</param>
		public FileMultipartSection(MultipartSection section, ContentDispositionHeaderValue? header)
		{
			throw null;
		}
	}
}
