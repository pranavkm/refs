using Microsoft.AspNetCore.Http.Features;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Http
{
	public static class RequestFormReaderExtensions
	{
		/// <summary>
		/// Read the request body as a form with the given options. These options will only be used
		/// if the form has not already been read.
		/// </summary>
		/// <param name="request">The request.</param>
		/// <param name="options">Options for reading the form.</param>
		/// <param name="cancellationToken"></param>
		/// <returns>The parsed form.</returns>
		public static Task<IFormCollection> ReadFormAsync(this HttpRequest request, FormOptions options, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}
	}
}
