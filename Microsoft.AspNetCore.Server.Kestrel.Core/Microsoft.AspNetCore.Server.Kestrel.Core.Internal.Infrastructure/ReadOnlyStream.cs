using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure
{
	internal abstract class ReadOnlyStream : Stream
	{
		public override bool CanRead
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

		public override int WriteTimeout
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

		protected ReadOnlyStream()
		{
			throw null;
		}
	}
}
