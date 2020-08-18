using System;
using System.Buffers;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.WebUtilities
{
	/// <summary>
	/// A Stream that wraps another stream and allows reading lines.
	/// The data is buffered in memory.
	/// </summary>
	public class BufferedReadStream : Stream
	{
		/// <summary>
		/// The currently buffered data.
		/// </summary>
		public ArraySegment<byte> BufferedData
		{
			[System.Runtime.CompilerServices.NullableContext(0)]
			get
			{
				throw null;
			}
		}

		/// <inheritdoc />
		public override bool CanRead
		{
			get
			{
				throw null;
			}
		}

		/// <inheritdoc />
		public override bool CanSeek
		{
			get
			{
				throw null;
			}
		}

		/// <inheritdoc />
		public override bool CanTimeout
		{
			get
			{
				throw null;
			}
		}

		/// <inheritdoc />
		public override bool CanWrite
		{
			get
			{
				throw null;
			}
		}

		/// <inheritdoc />
		public override long Length
		{
			get
			{
				throw null;
			}
		}

		/// <inheritdoc />
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
		/// Creates a new stream.
		/// </summary>
		/// <param name="inner">The stream to wrap.</param>
		/// <param name="bufferSize">Size of buffer in bytes.</param>
		public BufferedReadStream(Stream inner, int bufferSize)
		{
			throw null;
		}

		/// <summary>
		/// Creates a new stream.
		/// </summary>
		/// <param name="inner">The stream to wrap.</param>
		/// <param name="bufferSize">Size of buffer in bytes.</param>
		/// <param name="bytePool">ArrayPool for the buffer.</param>
		public BufferedReadStream(Stream inner, int bufferSize, ArrayPool<byte> bytePool)
		{
			throw null;
		}

		/// <inheritdoc />
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw null;
		}

		/// <inheritdoc />
		public override void SetLength(long value)
		{
			throw null;
		}

		/// <inheritdoc />
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		/// <inheritdoc />
		public override void Flush()
		{
			throw null;
		}

		/// <inheritdoc />
		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			throw null;
		}

		/// <inheritdoc />
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		/// <inheritdoc />
		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			throw null;
		}

		/// <inheritdoc />
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		/// <inheritdoc />
		[AsyncStateMachine(typeof(_003CReadAsync_003Ed__33))]
		[DebuggerStepThrough]
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			throw null;
		}

		/// <summary>
		/// Ensures that the buffer is not empty.
		/// </summary>
		/// <returns>Returns <c>true</c> if the buffer is not empty; <c>false</c> otherwise.</returns>
		public bool EnsureBuffered()
		{
			throw null;
		}

		/// <summary>
		/// Ensures that the buffer is not empty.
		/// </summary>
		/// <param name="cancellationToken">Cancellation token.</param>
		/// <returns>Returns <c>true</c> if the buffer is not empty; <c>false</c> otherwise.</returns>
		[AsyncStateMachine(typeof(_003CEnsureBufferedAsync_003Ed__35))]
		[DebuggerStepThrough]
		public Task<bool> EnsureBufferedAsync(CancellationToken cancellationToken)
		{
			throw null;
		}

		/// <summary>
		/// Ensures that a minimum amount of buffered data is available.
		/// </summary>
		/// <param name="minCount">Minimum amount of buffered data.</param>
		/// <returns>Returns <c>true</c> if the minimum amount of buffered data is available; <c>false</c> otherwise.</returns>
		public bool EnsureBuffered(int minCount)
		{
			throw null;
		}

		/// <summary>
		/// Ensures that a minimum amount of buffered data is available.
		/// </summary>
		/// <param name="minCount">Minimum amount of buffered data.</param>
		/// <param name="cancellationToken">Cancellation token.</param>
		/// <returns>Returns <c>true</c> if the minimum amount of buffered data is available; <c>false</c> otherwise.</returns>
		[AsyncStateMachine(typeof(_003CEnsureBufferedAsync_003Ed__37))]
		[DebuggerStepThrough]
		public Task<bool> EnsureBufferedAsync(int minCount, CancellationToken cancellationToken)
		{
			throw null;
		}

		/// <summary>
		/// Reads a line. A line is defined as a sequence of characters followed by
		/// a carriage return immediately followed by a line feed. The resulting string does not
		/// contain the terminating carriage return and line feed.
		/// </summary>
		/// <param name="lengthLimit">Maximum allowed line length.</param>
		/// <returns>A line.</returns>
		public string ReadLine(int lengthLimit)
		{
			throw null;
		}

		/// <summary>
		/// Reads a line. A line is defined as a sequence of characters followed by
		/// a carriage return immediately followed by a line feed. The resulting string does not
		/// contain the terminating carriage return and line feed.
		/// </summary>
		/// <param name="lengthLimit">Maximum allowed line length.</param>
		/// <param name="cancellationToken">Cancellation token.</param>
		/// <returns>A line.</returns>
		[AsyncStateMachine(typeof(_003CReadLineAsync_003Ed__39))]
		[DebuggerStepThrough]
		public Task<string> ReadLineAsync(int lengthLimit, CancellationToken cancellationToken)
		{
			throw null;
		}
	}
}
