using Microsoft.AspNetCore.Http.Features;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.IIS.Core
{
	internal class EmptyStream : ReadOnlyStream
	{
		public EmptyStream(IHttpBodyControlFeature bodyControl)
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

		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			throw null;
		}

		public void StopAcceptingReads()
		{
			throw null;
		}

		public void Abort(Exception error = null)
		{
			throw null;
		}
	}
}
