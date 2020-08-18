using Microsoft.Extensions.FileProviders;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Http
{
	/// <summary>
	/// Provides extensions for HttpResponse exposing the SendFile extension.
	/// </summary>
	public static class SendFileResponseExtensions
	{
		/// <summary>
		/// Sends the given file using the SendFile extension.
		/// </summary>
		/// <param name="response"></param>
		/// <param name="file">The file.</param>
		/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" />.</param>
		public static Task SendFileAsync(this HttpResponse response, IFileInfo file, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		/// <summary>
		/// Sends the given file using the SendFile extension.
		/// </summary>
		/// <param name="response"></param>
		/// <param name="file">The file.</param>
		/// <param name="offset">The offset in the file.</param>
		/// <param name="count">The number of bytes to send, or null to send the remainder of the file.</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public static Task SendFileAsync(this HttpResponse response, IFileInfo file, long offset, long? count, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		/// <summary>
		/// Sends the given file using the SendFile extension.
		/// </summary>
		/// <param name="response"></param>
		/// <param name="fileName">The full path to the file.</param>
		/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" />.</param>
		/// <returns></returns>
		public static Task SendFileAsync(this HttpResponse response, string fileName, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		/// <summary>
		/// Sends the given file using the SendFile extension.
		/// </summary>
		/// <param name="response"></param>
		/// <param name="fileName">The full path to the file.</param>
		/// <param name="offset">The offset in the file.</param>
		/// <param name="count">The number of bytes to send, or null to send the remainder of the file.</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public static Task SendFileAsync(this HttpResponse response, string fileName, long offset, long? count, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}
	}
}
