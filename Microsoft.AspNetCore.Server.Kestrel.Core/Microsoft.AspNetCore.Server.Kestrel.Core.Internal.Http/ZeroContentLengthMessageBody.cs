using System;
using System.IO.Pipelines;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http
{
	internal sealed class ZeroContentLengthMessageBody : MessageBody
	{
		public override bool IsEmpty
		{
			get
			{
				throw null;
			}
		}

		public ZeroContentLengthMessageBody(bool keepAlive)
		{
			throw null;
		}

		public override ValueTask<ReadResult> ReadAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		public override Task ConsumeAsync()
		{
			throw null;
		}

		public override Task StopAsync()
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

		public override bool TryRead(out ReadResult result)
		{
			throw null;
		}

		public override void Complete(Exception ex)
		{
			throw null;
		}

		public override void CancelPendingRead()
		{
			throw null;
		}
	}
}
