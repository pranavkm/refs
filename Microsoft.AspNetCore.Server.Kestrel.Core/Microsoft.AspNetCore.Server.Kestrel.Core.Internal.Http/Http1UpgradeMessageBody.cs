using System;
using System.IO.Pipelines;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http
{
	/// <summary>
	/// The upgrade stream uses the raw connection stream instead of going through the RequestBodyPipe. This
	/// removes the redundant copy from the transport pipe to the body pipe.
	/// </summary>
	internal sealed class Http1UpgradeMessageBody : Http1MessageBody
	{
		public override bool IsEmpty
		{
			get
			{
				throw null;
			}
		}

		public Http1UpgradeMessageBody(Http1Connection context)
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

		public override void AdvanceTo(SequencePosition consumed)
		{
			throw null;
		}

		public override void AdvanceTo(SequencePosition consumed, SequencePosition examined)
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

		public override Task ConsumeAsync()
		{
			throw null;
		}

		public override Task StopAsync()
		{
			throw null;
		}

		public override bool TryReadInternal(out ReadResult readResult)
		{
			throw null;
		}

		public override ValueTask<ReadResult> ReadAsyncInternal(CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}
	}
}
