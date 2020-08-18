using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http;
using System;
using System.Diagnostics;
using System.IO.Pipelines;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http2
{
	internal sealed class Http2MessageBody : MessageBody
	{
		public Http2MessageBody(Http2Stream context)
		{
			throw null;
		}

		protected override void OnReadStarting()
		{
			throw null;
		}

		protected override void OnReadStarted()
		{
			throw null;
		}

		public override void Reset()
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

		public override bool TryRead(out ReadResult readResult)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CReadAsync_003Ed__9))]
		[DebuggerStepThrough]
		public override ValueTask<ReadResult> ReadAsync(CancellationToken cancellationToken = default(CancellationToken))
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
