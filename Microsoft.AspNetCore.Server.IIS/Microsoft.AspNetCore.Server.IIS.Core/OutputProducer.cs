using System;
using System.IO.Pipelines;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.IIS.Core
{
	internal class OutputProducer
	{
		public PipeReader Reader
		{
			get
			{
				throw null;
			}
		}

		public OutputProducer(Pipe pipe)
		{
			throw null;
		}

		public Task FlushAsync(CancellationToken cancellationToken)
		{
			throw null;
		}

		public void Complete()
		{
			throw null;
		}

		public void Abort(Exception error)
		{
			throw null;
		}

		public Task WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken)
		{
			throw null;
		}
	}
}
