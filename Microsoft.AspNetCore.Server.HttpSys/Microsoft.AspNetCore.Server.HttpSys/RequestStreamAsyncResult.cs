using Microsoft.AspNetCore.HttpSys.Internal;
using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.HttpSys
{
	internal class RequestStreamAsyncResult : IAsyncResult, IDisposable
	{
		internal RequestStream RequestStream
		{
			get
			{
				throw null;
			}
		}

		internal SafeNativeOverlapped NativeOverlapped
		{
			get
			{
				throw null;
			}
		}

		internal IntPtr PinnedBuffer
		{
			get
			{
				throw null;
			}
		}

		internal uint DataAlreadyRead
		{
			get
			{
				throw null;
			}
		}

		internal Task<int> Task
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

		internal RequestStreamAsyncResult(RequestStream requestStream, object userState, AsyncCallback callback)
		{
			throw null;
		}

		internal RequestStreamAsyncResult(RequestStream requestStream, object userState, AsyncCallback callback, uint dataAlreadyRead)
		{
			throw null;
		}

		internal RequestStreamAsyncResult(RequestStream requestStream, object userState, AsyncCallback callback, byte[] buffer, int offset, uint dataAlreadyRead)
		{
			throw null;
		}

		internal RequestStreamAsyncResult(RequestStream requestStream, object userState, AsyncCallback callback, byte[] buffer, int offset, uint dataAlreadyRead, CancellationTokenRegistration cancellationRegistration)
		{
			throw null;
		}

		internal void IOCompleted(uint errorCode, uint numBytes)
		{
			throw null;
		}

		internal void Complete(int read, uint errorCode = 0u)
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

		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}
	}
}
