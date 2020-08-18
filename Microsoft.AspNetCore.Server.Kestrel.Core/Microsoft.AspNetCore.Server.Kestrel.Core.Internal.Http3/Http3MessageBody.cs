using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http;
using System;
using System.Diagnostics;
using System.IO.Pipelines;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http3
{
	internal sealed class Http3MessageBody : MessageBody
	{
		protected override void OnReadStarting()
		{
			throw null;
		}

		protected override void OnReadStarted()
		{
			throw null;
		}

		public static MessageBody For(Http3Stream context)
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
