using System;
using System.Diagnostics;
using System.IO;
using System.IO.Pipelines;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.WebUtilities
{
	/// <summary>
	/// A <see cref="T:System.IO.Stream" /> that buffers content to be written to disk. Use <see cref="M:Microsoft.AspNetCore.WebUtilities.FileBufferingWriteStream.DrainBufferAsync(System.IO.Stream,System.Threading.CancellationToken)" />
	/// to write buffered content to a target <see cref="T:System.IO.Stream" />.
	/// </summary>
	public sealed class FileBufferingWriteStream : Stream
	{
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

		internal PagedByteBuffer PagedByteBuffer
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		internal FileStream? FileStream
		{
			[System.Runtime.CompilerServices.NullableContext(2)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		internal bool Disposed
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Initializes a new instance of <see cref="T:Microsoft.AspNetCore.WebUtilities.FileBufferingWriteStream" />.
		/// </summary>
		/// <param name="memoryThreshold">
		/// The maximum amount of memory in bytes to allocate before switching to a file on disk.
		/// Defaults to 32kb.
		/// </param>
		/// <param name="bufferLimit">
		/// The maximum amount of bytes that the <see cref="T:Microsoft.AspNetCore.WebUtilities.FileBufferingWriteStream" /> is allowed to buffer.
		/// </param>
		/// <param name="tempFileDirectoryAccessor">Provides the location of the directory to write buffered contents to.
		/// When unspecified, uses the value specified by the environment variable <c>ASPNETCORE_TEMP</c> if available, otherwise
		/// uses the value returned by <see cref="M:System.IO.Path.GetTempPath" />.
		/// </param>
		public FileBufferingWriteStream(int memoryThreshold = 32768, long? bufferLimit = null, Func<string>? tempFileDirectoryAccessor = null)
		{
			throw null;
		}

		/// <inheritdoc />
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw null;
		}

		/// <inheritdoc />
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		/// <inheritdoc />
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			throw null;
		}

		/// <inheritdoc />
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		/// <inheritdoc />
		[AsyncStateMachine(typeof(_003CWriteAsync_003Ed__31))]
		[DebuggerStepThrough]
		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
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
		public override void SetLength(long value)
		{
			throw null;
		}

		/// <summary>
		/// Drains buffered content to <paramref name="destination" />.
		/// </summary>
		/// <param name="destination">The <see cref="T:System.IO.Stream" /> to drain buffered contents to.</param>
		/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" />.</param>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task" /> that represents the asynchronous drain operation.</returns>
		[AsyncStateMachine(typeof(_003CDrainBufferAsync_003Ed__35))]
		[DebuggerStepThrough]
		public Task DrainBufferAsync(Stream destination, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CDrainBufferAsync_003Ed__36))]
		[DebuggerStepThrough]
		public Task DrainBufferAsync(PipeWriter destination, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		/// <inheritdoc />
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		/// <inheritdoc />
		[AsyncStateMachine(typeof(_003CDisposeAsync_003Ed__38))]
		[DebuggerStepThrough]
		public override ValueTask DisposeAsync()
		{
			throw null;
		}
	}
}
