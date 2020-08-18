using Microsoft.AspNetCore.HttpSys.Internal;
using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.HttpSys
{
	internal class ResponseStreamAsyncResult : IAsyncResult, IDisposable
	{
		internal SafeNativeOverlapped NativeOverlapped
		{
			get
			{
				throw null;
			}
		}

		internal Task Task
		{
			get
			{
				throw null;
			}
		}

		internal uint BytesSent
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

		internal ushort DataChunkCount
		{
			get
			{
				throw null;
			}
		}

		internal unsafe HttpApiTypes.HTTP_DATA_CHUNK* DataChunks
		{
			get
			{
				throw null;
			}
		}

		internal bool EndCalled
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public object AsyncState
		{
			get
			{
				throw null;
			}
		}

		public WaitHandle AsyncWaitHandle
		{
			get
			{
				throw null;
			}
		}

		public bool CompletedSynchronously
		{
			get
			{
				throw null;
			}
		}

		public bool IsCompleted
		{
			get
			{
				throw null;
			}
		}

		internal ResponseStreamAsyncResult(ResponseBody responseStream, CancellationToken cancellationToken)
		{
			throw null;
		}

		internal ResponseStreamAsyncResult(ResponseBody responseStream, ArraySegment<byte> data, bool chunked, CancellationToken cancellationToken)
		{
			throw null;
		}

		internal ResponseStreamAsyncResult(ResponseBody responseStream, FileStream fileStream, long offset, long count, bool chunked, CancellationToken cancellationToken)
		{
			throw null;
		}

		internal void IOCompleted(uint errorCode)
		{
			throw null;
		}

		internal void IOCompleted(uint errorCode, uint numBytes)
		{
			throw null;
		}

		internal void Complete()
		{
			throw null;
		}

		internal void FailSilently()
		{
			throw null;
		}

		internal void Cancel(bool dispose)
		{
			throw null;
		}

		internal void Fail(Exception ex)
		{
			throw null;
		}

		public void Dispose()
		{
			throw null;
		}
	}
}
