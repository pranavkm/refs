using Microsoft.AspNetCore.Http.Features;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.IIS.Core
{
	internal class HttpRequestStream : ReadOnlyStream
	{
		public HttpRequestStream(IHttpBodyControlFeature bodyControl)
		{
			throw null;
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			throw null;
		}

		public override int EndRead(IAsyncResult asyncResult)
		{
			throw null;
		}

		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			throw null;
		}

		public override ValueTask<int> ReadAsync(Memory<byte> destination, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CCopyToAsync_003Ed__11))]
		[DebuggerStepThrough]
		public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken)
		{
			throw null;
		}

		public void StartAcceptingReads(IISHttpContext body)
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
