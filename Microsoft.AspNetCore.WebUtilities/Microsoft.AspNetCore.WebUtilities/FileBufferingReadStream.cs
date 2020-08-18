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
	/// A Stream that wraps another stream and enables rewinding by buffering the content as it is read.
	/// The content is buffered in memory up to a certain size and then spooled to a temp file on disk.
	/// The temp file will be deleted on Dispose.
	/// </summary>
	public class FileBufferingReadStream : Stream
	{
		public bool InMemory
		{
			get
			{
				throw null;
			}
		}

		public string? TempFileName
		{
			[System.Runtime.CompilerServices.NullableContext(2)]
			get
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
		/// Initializes a new instance of <see cref="T:Microsoft.AspNetCore.WebUtilities.FileBufferingReadStream" />.
		/// </summary>
		/// <param name="inner">The wrapping <see cref="T:System.IO.Stream" />.</param>
		/// <param name="memoryThreshold">The maximum size to buffer in memory.</param>
		public FileBufferingReadStream(Stream inner, int memoryThreshold)
		{
			throw null;
		}

		public FileBufferingReadStream(Stream inner, int memoryThreshold, long? bufferLimit, Func<string> tempFileDirectoryAccessor)
		{
			throw null;
		}

		public FileBufferingReadStream(Stream inner, int memoryThreshold, long? bufferLimit, Func<string> tempFileDirectoryAccessor, ArrayPool<byte> bytePool)
		{
			throw null;
		}

		public FileBufferingReadStream(Stream inner, int memoryThreshold, long? bufferLimit, string tempFileDirectory)
		{
			throw null;
		}

		public FileBufferingReadStream(Stream inner, int memoryThreshold, long? bufferLimit, string tempFileDirectory, ArrayPool<byte> bytePool)
		{
			throw null;
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			throw null;
		}

		public override int Read(Span<byte> buffer)
		{
			throw null;
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CReadAsync_003Ed__38))]
		[DebuggerStepThrough]
		public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
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

		public override void SetLength(long value)
		{
			throw null;
		}

		public override void Flush()
		{
			throw null;
		}

		public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken)
		{
			throw null;
		}

		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CDisposeAsync_003Ed__45))]
		[DebuggerStepThrough]
		public override ValueTask DisposeAsync()
		{
			throw null;
		}
	}
}
