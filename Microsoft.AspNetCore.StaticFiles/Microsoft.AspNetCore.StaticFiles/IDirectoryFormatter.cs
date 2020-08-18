using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.FileProviders;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.StaticFiles
{
	/// <summary>
	/// Generates the view for a directory
	/// </summary>
	public interface IDirectoryFormatter
	{
		/// <summary>
		/// Generates the view for a directory.
		/// Implementers should properly handle HEAD requests.
		/// Implementers should set all necessary response headers (e.g. Content-Type, Content-Length, etc.).
		/// </summary>
		Task GenerateContentAsync(HttpContext context, IEnumerable<IFileInfo> contents);
	}
}
