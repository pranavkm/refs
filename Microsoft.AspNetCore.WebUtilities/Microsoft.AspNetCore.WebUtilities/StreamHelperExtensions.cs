using System.Buffers;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.WebUtilities
{
	public static class StreamHelperExtensions
	{
		public static Task DrainAsync(this Stream stream, CancellationToken cancellationToken)
		{
			throw null;
		}

		public static Task DrainAsync(this Stream stream, long? limit, CancellationToken cancellationToken)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CDrainAsync_003Ed__3))]
		[DebuggerStepThrough]
		public static Task DrainAsync(this Stream stream, ArrayPool<byte> bytePool, long? limit, CancellationToken cancellationToken)
		{
			throw null;
		}
	}
}
