using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.HttpSys
{
	internal class RequestStream : Stream
	{
		internal RequestContext RequestContext
		{
			get
			{
				throw null;
			}
		}

		public bool HasStarted
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public long? MaxSize
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

		internal RequestStream(RequestContext httpContext)
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

		public override void Flush()
		{
			throw null;
		}

		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			throw null;
		}

		internal void SwitchToOpaqueMode()
		{
			throw null;
		}

		internal void Abort()
		{
			throw null;
		}

		public override int Read([In] [Out] byte[] buffer, int offset, int size)
		{
			throw null;
		}

		internal void UpdateAfterRead(uint statusCode, uint dataRead)
		{
			throw null;
		}

		public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
		{
			throw null;
		}

		public override int EndRead(IAsyncResult asyncResult)
		{
			throw null;
		}

		public override Task<int> ReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken)
		{
			throw null;
		}

		public override void Write(byte[] buffer, int offset, int size)
		{
			throw null;
		}

		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
		{
			throw null;
		}

		public override void EndWrite(IAsyncResult asyncResult)
		{
			throw null;
		}

		internal bool TryCheckSizeLimit(int bytesRead, out Exception exception)
		{
			throw null;
		}

		protected override void Dispose(bool disposing)
		{
			throw null;
		}
	}
}
