using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Components.Server.Circuits
{
	/// <summary>
	/// Writeable memory stream backed by a an <see cref="T:Microsoft.AspNetCore.Components.Server.Circuits.ArrayBuilder`1" />.
	/// </summary>
	internal sealed class ArrayBuilderMemoryStream : Stream
	{
		private static class ThrowHelper
		{
			public static void ThrowArgumentNullException(string name)
			{
				throw null;
			}

			public static void ThrowArgumentOutOfRangeException(string name)
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

		public ArrayBuilder<byte> ArrayBuilder
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public ArrayBuilderMemoryStream(ArrayBuilder<byte> arrayBuilder)
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

		/// <inheritdoc />
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		/// <inheritdoc />
		public override ValueTask DisposeAsync()
		{
			throw null;
		}
	}
}
