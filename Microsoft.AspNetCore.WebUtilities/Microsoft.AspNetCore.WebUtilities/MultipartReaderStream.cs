using System.Buffers;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.WebUtilities
{
	internal sealed class MultipartReaderStream : Stream
	{
		public bool FinalBoundaryFound
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public long? LengthLimit
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

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

		/// <summary>
		/// Creates a stream that reads until it reaches the given boundary pattern.
		/// </summary>
		/// <param name="stream">The <see cref="T:Microsoft.AspNetCore.WebUtilities.BufferedReadStream" />.</param>
		/// <param name="boundary">The boundary pattern to use.</param>
		public MultipartReaderStream(BufferedReadStream stream, MultipartBoundary boundary)
		{
			throw null;
		}

		/// <summary>
		/// Creates a stream that reads until it reaches the given boundary pattern.
		/// </summary>
		/// <param name="stream">The <see cref="T:Microsoft.AspNetCore.WebUtilities.BufferedReadStream" />.</param>
		/// <param name="boundary">The boundary pattern to use.</param>
		/// <param name="bytePool">The ArrayPool pool to use for temporary byte arrays.</param>
		public MultipartReaderStream(BufferedReadStream stream, MultipartBoundary boundary, ArrayPool<byte> bytePool)
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

		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
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

		[AsyncStateMachine(typeof(_003CReadAsync_003Ed__36))]
		[DebuggerStepThrough]
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			throw null;
		}
	}
}
