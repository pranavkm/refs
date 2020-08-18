using System;
using System.Buffers;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Internal
{
	internal sealed class MemoryBufferWriter : Stream, IBufferWriter<byte>
	{
		/// <summary>
		/// Holds a byte[] from the pool and a size value. Basically a Memory but guaranteed to be backed by an ArrayPool byte[], so that we know we can return it.
		/// </summary>
		private readonly struct CompletedBuffer
		{
			public byte[] Buffer
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			public int Length
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			public ReadOnlySpan<byte> Span
			{
				get
				{
					throw null;
				}
			}

			public CompletedBuffer(byte[] buffer, int length)
			{
				throw null;
			}

			public void Return()
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

		public MemoryBufferWriter(int minimumSegmentSize = 4096)
		{
			throw null;
		}

		public static MemoryBufferWriter Get()
		{
			throw null;
		}

		public static void Return(MemoryBufferWriter writer)
		{
			throw null;
		}

		public void Reset()
		{
			throw null;
		}

		public void Advance(int count)
		{
			throw null;
		}

		public Memory<byte> GetMemory(int sizeHint = 0)
		{
			throw null;
		}

		public Span<byte> GetSpan(int sizeHint = 0)
		{
			throw null;
		}

		public void CopyTo(IBufferWriter<byte> destination)
		{
			throw null;
		}

		public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken)
		{
			throw null;
		}

		public byte[] ToArray()
		{
			throw null;
		}

		public void CopyTo(Span<byte> span)
		{
			throw null;
		}

		public override void Flush()
		{
			throw null;
		}

		public override Task FlushAsync(CancellationToken cancellationToken)
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

		public override void WriteByte(byte value)
		{
			throw null;
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		public override void Write(ReadOnlySpan<byte> span)
		{
			throw null;
		}

		protected override void Dispose(bool disposing)
		{
			throw null;
		}
	}
}
