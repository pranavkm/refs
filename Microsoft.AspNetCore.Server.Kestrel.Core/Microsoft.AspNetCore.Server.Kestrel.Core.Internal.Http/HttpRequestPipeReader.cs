using System;
using System.IO.Pipelines;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http
{
	/// <summary>
	/// Default HttpRequest PipeReader implementation to be used by Kestrel.
	/// </summary>
	internal sealed class HttpRequestPipeReader : PipeReader
	{
		public HttpRequestPipeReader()
		{
			throw null;
		}

		public override void AdvanceTo(SequencePosition consumed)
		{
			throw null;
		}

		public override void AdvanceTo(SequencePosition consumed, SequencePosition examined)
		{
			throw null;
		}

		public override void CancelPendingRead()
		{
			throw null;
		}

		public override void Complete(Exception exception = null)
		{
			throw null;
		}

		public override ValueTask<ReadResult> ReadAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		public override bool TryRead(out ReadResult result)
		{
			throw null;
		}

		public void StartAcceptingReads(MessageBody body)
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
