using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.HttpSys
{
	internal class AsyncAcceptContext : TaskCompletionSource<RequestContext>, IDisposable
	{
		internal static readonly IOCompletionCallback IOCallback;

		internal HttpSysListener Server
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		internal AsyncAcceptContext(HttpSysListener server)
		{
			throw null;
		}

		internal uint QueueBeginGetContext()
		{
			throw null;
		}

		internal void AllocateNativeRequest(uint? size = null, ulong requestId = 0uL)
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
