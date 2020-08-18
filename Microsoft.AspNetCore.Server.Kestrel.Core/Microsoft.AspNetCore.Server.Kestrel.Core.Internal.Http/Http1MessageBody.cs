using System.Diagnostics;
using System.IO.Pipelines;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http
{
	internal abstract class Http1MessageBody : MessageBody
	{
		protected readonly Http1Connection _context;

		protected bool _completed;

		protected Http1MessageBody(Http1Connection context)
		{
			throw null;
		}

		[System.Diagnostics.StackTraceHidden]
		protected void ThrowUnexpectedEndOfRequestContent()
		{
			throw null;
		}

		public abstract bool TryReadInternal(out ReadResult readResult);

		public abstract ValueTask<ReadResult> ReadAsyncInternal(CancellationToken cancellationToken = default(CancellationToken));

		protected override Task OnConsumeAsync()
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003COnConsumeAsyncAwaited_003Ed__7))]
		[DebuggerStepThrough]
		protected Task OnConsumeAsyncAwaited()
		{
			throw null;
		}

		public static MessageBody For(HttpVersion httpVersion, HttpRequestHeaders headers, Http1Connection context)
		{
			throw null;
		}

		protected void ThrowIfCompleted()
		{
			throw null;
		}
	}
}
