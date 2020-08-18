using Microsoft.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.WebUtilities
{
	/// <summary>
	/// Represents a form multipart section
	/// </summary>
	public class FormMultipartSection
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
		/// The form name
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
		/// Creates a new instance of the <see cref="T:Microsoft.AspNetCore.WebUtilities.FormMultipartSection" /> class
		/// </summary>
		/// <param name="section">The section from which to create the <see cref="T:Microsoft.AspNetCore.WebUtilities.FormMultipartSection" /></param>
		/// <remarks>Reparses the content disposition header</remarks>
		public FormMultipartSection(MultipartSection section)
		{
			throw null;
		}

		/// <summary>
		/// Creates a new instance of the <see cref="T:Microsoft.AspNetCore.WebUtilities.FormMultipartSection" /> class
		/// </summary>
		/// <param name="section">The section from which to create the <see cref="T:Microsoft.AspNetCore.WebUtilities.FormMultipartSection" /></param>
		/// <param name="header">An already parsed content disposition header</param>
		public FormMultipartSection(MultipartSection section, ContentDispositionHeaderValue? header)
		{
			throw null;
		}

		/// <summary>
		/// Gets the form value
		/// </summary>
		/// <returns>The form value</returns>
		public Task<string> GetValueAsync()
		{
			throw null;
		}
	}
}
