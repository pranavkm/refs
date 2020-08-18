using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Http
{
	internal static class StreamCopyOperationInternal
	{
		/// <summary>Asynchronously reads the given number of bytes from the source stream and writes them to another stream.</summary>
		/// <returns>A task that represents the asynchronous copy operation.</returns>
		/// <param name="source">The stream from which the contents will be copied.</param>
		/// <param name="destination">The stream to which the contents of the current stream will be copied.</param>
		/// <param name="count">The count of bytes to be copied.</param>
		/// <param name="cancel">The token to monitor for cancellation requests. The default value is <see cref="P:System.Threading.CancellationToken.None" />.</param>
		public static Task CopyToAsync(Stream source, Stream destination, long? count, CancellationToken cancel)
		{
			throw null;
		}

		/// <summary>Asynchronously reads the given number of bytes from the source stream and writes them to another stream, using a specified buffer size.</summary>
		/// <returns>A task that represents the asynchronous copy operation.</returns>
		/// <param name="source">The stream from which the contents will be copied.</param>
		/// <param name="destination">The stream to which the contents of the current stream will be copied.</param>
		/// <param name="count">The count of bytes to be copied.</param>
		/// <param name="bufferSize">The size, in bytes, of the buffer. This value must be greater than zero. The default size is 4096.</param>
		/// <param name="cancel">The token to monitor for cancellation requests. The default value is <see cref="P:System.Threading.CancellationToken.None" />.</param>
		[AsyncStateMachine(typeof(_003CCopyToAsync_003Ed__2))]
		[DebuggerStepThrough]
		public static Task CopyToAsync(Stream source, Stream destination, long? count, int bufferSize, CancellationToken cancel)
		{
			throw null;
		}
	}
}
