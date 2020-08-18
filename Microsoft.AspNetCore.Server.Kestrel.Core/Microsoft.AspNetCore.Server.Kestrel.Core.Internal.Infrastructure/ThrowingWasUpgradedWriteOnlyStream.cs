using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure
{
	internal sealed class ThrowingWasUpgradedWriteOnlyStream : WriteOnlyStream
	{
		public override bool CanSeek
		{
			get
			{
				throw null;
			}
		}

		public override long Length
		{
			get
			{
				throw null;
			}
		}

		public override long Position
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			throw null;
		}

		public override void Flush()
		{
			throw null;
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			throw null;
		}

		public override void SetLength(long value)
		{
			throw null;
		}

		public ThrowingWasUpgradedWriteOnlyStream()
		{
			throw null;
		}
	}
}
