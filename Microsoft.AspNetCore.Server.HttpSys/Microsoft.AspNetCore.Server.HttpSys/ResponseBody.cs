using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.HttpSys
{
	internal class ResponseBody : Stream
	{
		internal RequestContext RequestContext
		{
			get
			{
				throw null;
			}
		}

		internal bool ThrowWriteExceptions
		{
			get
			{
				throw null;
			}
		}

		internal bool IsDisposed
		{
			get
			{
				throw null;
			}
		}

		public override bool CanSeek
		{
			get
			{
				throw null;
			}
		}

		public override bool CanWrite
		{
			get
			{
				throw null;
			}
		}

		public override bool CanRead
		{
			get
			{
				throw null;
			}
		}

		public override long Length
		{
			get
			{
				throw null;
			}
		}

		public override long Position
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		internal ResponseBody(RequestContext requestContext)
		{
			throw null;
		}

		public override void Flush()
		{
			throw null;
		}

		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			throw null;
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			throw null;
		}

		public override void SetLength(long value)
		{
			throw null;
		}

		public override int Read([In] [Out] byte[] buffer, int offset, int count)
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

		internal void Abort(bool dispose = true)
		{
			throw null;
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			throw null;
		}

		public override void EndWrite(IAsyncResult asyncResult)
		{
			throw null;
		}

		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CSendFileAsync_003Ed__48))]
		[DebuggerStepThrough]
		internal Task SendFileAsync(string fileName, long offset, long? count, CancellationToken cancellationToken)
		{
			throw null;
		}

		internal Task SendFileAsyncCore(string fileName, long offset, long? count, CancellationToken cancellationToken)
		{
			throw null;
		}

		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		internal void SwitchToOpaqueMode()
		{
			throw null;
		}

		internal void CancelLastWrite()
		{
			throw null;
		}
	}
}
