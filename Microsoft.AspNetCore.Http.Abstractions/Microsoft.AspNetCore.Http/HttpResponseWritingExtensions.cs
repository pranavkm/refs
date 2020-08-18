using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Http
{
	/// <summary>
	/// Convenience methods for writing to the response.
	/// </summary>
	public static class HttpResponseWritingExtensions
	{
		/// <summary>
		/// Writes the given text to the response body. UTF-8 encoding will be used.
		/// </summary>
		/// <param name="response">The <see cref="T:Microsoft.AspNetCore.Http.HttpResponse" />.</param>
		/// <param name="text">The text to write to the response.</param>
		/// <param name="cancellationToken">Notifies when request operations should be cancelled.</param>
		/// <returns>A task that represents the completion of the write operation.</returns>
		public static Task WriteAsync(this HttpResponse response, string text, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		/// <summary>
		/// Writes the given text to the response body using the given encoding.
		/// </summary>
		/// <param name="response">The <see cref="T:Microsoft.AspNetCore.Http.HttpResponse" />.</param>
		/// <param name="text">The text to write to the response.</param>
		/// <param name="encoding">The encoding to use.</param>
		/// <param name="cancellationToken">Notifies when request operations should be cancelled.</param>
		/// <returns>A task that represents the completion of the write operation.</returns>
		public static Task WriteAsync(this HttpResponse response, string text, Encoding encoding, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}
	}
}
