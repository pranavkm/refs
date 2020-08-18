using System.Buffers;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO
{
	internal static class StreamExtensions
	{
		public static ValueTask WriteAsync(this Stream stream, ReadOnlySequence<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}
	}
}
