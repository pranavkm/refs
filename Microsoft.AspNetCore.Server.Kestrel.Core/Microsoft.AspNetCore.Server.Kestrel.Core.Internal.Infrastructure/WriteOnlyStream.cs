using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure
{
	internal abstract class WriteOnlyStream : Stream
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

		public override int ReadTimeout
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

		public override int Read(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			throw null;
		}

		protected WriteOnlyStream()
		{
			throw null;
		}
	}
}
