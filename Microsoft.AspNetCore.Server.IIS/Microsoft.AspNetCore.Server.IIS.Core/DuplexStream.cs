using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.IIS.Core
{
	internal class DuplexStream : Stream
	{
		public override bool CanRead
		{
			get
			{
				throw null;
			}
		}

		public override bool CanSeek
		{
			get
			{
				throw null;
			}
		}

		public override bool CanWrite
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

		public DuplexStream(Stream requestBody, Stream responseBody)
		{
			throw null;
		}

		public override void Flush()
		{
			throw null;
		}

		public override int Read(byte[] buffer, int offset, int count)
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

		public override void Write(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			throw null;
		}

		public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			throw null;
		}

		public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken)
		{
			throw null;
		}

		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			throw null;
		}
	}
}
