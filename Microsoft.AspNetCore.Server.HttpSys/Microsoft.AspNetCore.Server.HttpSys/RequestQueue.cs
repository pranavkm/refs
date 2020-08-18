using Microsoft.Extensions.Logging;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

namespace Microsoft.AspNetCore.Server.HttpSys
{
	internal class RequestQueue
	{
		/// <summary>
		/// True if this instace created the queue instead of attaching to an existing one.
		/// </summary>
		internal bool Created
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		internal SafeHandle Handle
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		internal ThreadPoolBoundHandle BoundHandle
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		internal RequestQueue(UrlGroup urlGroup, string requestQueueName, RequestQueueMode mode, ILogger logger)
		{
			throw null;
		}

		internal void AttachToUrlGroup()
		{
			throw null;
		}

		internal void DetachFromUrlGroup()
		{
			throw null;
		}

		internal void SetLengthLimit(long length)
		{
			throw null;
		}

		internal void SetRejectionVerbosity(Http503VerbosityLevel verbosity)
		{
			throw null;
		}

		public void Dispose()
		{
			throw null;
		}
	}
}
