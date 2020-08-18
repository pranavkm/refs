using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.FileProviders;
using System.Collections.Generic;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.StaticFiles
{
	/// <summary>
	/// Generates an HTML view for a directory.
	/// </summary>
	public class HtmlDirectoryFormatter : IDirectoryFormatter
	{
		/// <summary>
		/// Constructs the <see cref="T:Microsoft.AspNetCore.StaticFiles.HtmlDirectoryFormatter" />.
		/// </summary>
		/// <param name="encoder">The character encoding representation to use.</param>
		public HtmlDirectoryFormatter(HtmlEncoder encoder)
		{
			throw null;
		}

		/// <summary>
		/// Generates an HTML view for a directory.
		/// </summary>
		public virtual Task GenerateContentAsync(HttpContext context, IEnumerable<IFileInfo> contents)
		{
			throw null;
		}
	}
}
