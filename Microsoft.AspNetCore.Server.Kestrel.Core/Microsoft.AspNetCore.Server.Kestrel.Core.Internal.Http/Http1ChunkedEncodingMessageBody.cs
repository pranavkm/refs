using System;
using System.Diagnostics;
using System.IO.Pipelines;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http
{
	/// <summary>
	///   http://tools.ietf.org/html/rfc2616#section-3.6.1
	/// </summary>
	internal sealed class Http1ChunkedEncodingMessageBody : Http1MessageBody
	{
		private enum Mode
		{
			Prefix,
			Extension,
			Data,
			Suffix,
			Trailer,
			TrailerHeaders,
			Complete
		}

		public Http1ChunkedEncodingMessageBody(bool keepAlive, Http1Connection context)
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

		public override bool TryReadInternal(out ReadResult readResult)
		{
			throw null;
		}

		public override ValueTask<ReadResult> ReadAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CReadAsyncInternal_003Ed__14))]
		[DebuggerStepThrough]
		public override ValueTask<ReadResult> ReadAsyncInternal(CancellationToken cancellationToken = default(CancellationToken))
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

		protected override void OnReadStarted()
		{
			throw null;
		}
	}
}
