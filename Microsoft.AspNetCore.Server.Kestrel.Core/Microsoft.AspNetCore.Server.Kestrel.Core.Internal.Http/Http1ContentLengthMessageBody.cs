using System;
using System.Diagnostics;
using System.IO.Pipelines;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http
{
	internal sealed class Http1ContentLengthMessageBody : Http1MessageBody
	{
		public Http1ContentLengthMessageBody(bool keepAlive, long contentLength, Http1Connection context)
		{
			throw null;
		}

		public override ValueTask<ReadResult> ReadAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CReadAsyncInternal_003Ed__9))]
		[DebuggerStepThrough]
		public override ValueTask<ReadResult> ReadAsyncInternal(CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		public override bool TryRead(out ReadResult readResult)
		{
			throw null;
		}

		public override bool TryReadInternal(out ReadResult readResult)
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

		protected override void OnReadStarting()
		{
			throw null;
		}

		public override void Complete(Exception exception)
		{
			throw null;
		}

		public override void CancelPendingRead()
		{
			throw null;
		}

		protected override Task OnStopAsync()
		{
			throw null;
		}
	}
}
