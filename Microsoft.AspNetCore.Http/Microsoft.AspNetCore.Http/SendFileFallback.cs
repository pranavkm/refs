using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Http
{
	public static class SendFileFallback
	{
		/// <summary>
		/// Copies the segment of the file to the destination stream.
		/// </summary>
		/// <param name="destination">The stream to write the file segment to.</param>
		/// <param name="filePath">The full disk path to the file.</param>
		/// <param name="offset">The offset in the file to start at.</param>
		/// <param name="count">The number of bytes to send, or null to send the remainder of the file.</param>
		/// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> used to abort the transmission.</param>
		/// <returns></returns>
		[AsyncStateMachine(typeof(_003CSendFileAsync_003Ed__0))]
		[DebuggerStepThrough]
		public static Task SendFileAsync(Stream destination, string filePath, long offset, long? count, CancellationToken cancellationToken)
		{
			throw null;
		}
	}
}
