using System;
using System.Buffers;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Server.Kestrel.Transport.Sockets
{
	public class SocketTransportOptions
	{
		/// <summary>
		/// The number of I/O queues used to process requests. Set to 0 to directly schedule I/O to the ThreadPool.
		/// </summary>
		/// <remarks>
		/// Defaults to <see cref="P:System.Environment.ProcessorCount" /> rounded down and clamped between 1 and 16.
		/// </remarks>
		public int IOQueueCount
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

		/// <summary>
		/// Wait until there is data available to allocate a buffer. Setting this to false can increase throughput at the cost of increased memory usage.
		/// </summary>
		/// <remarks>
		/// Defaults to true.
		/// </remarks>
		public bool WaitForDataBeforeAllocatingBuffer
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

		/// <summary>
		/// Set to false to enable Nagle's algorithm for all connections.
		/// </summary>
		/// <remarks>
		/// Defaults to true.
		/// </remarks>
		public bool NoDelay
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

		/// <summary>
		/// The maximum length of the pending connection queue.
		/// </summary>
		/// <remarks>
		/// Defaults to 512.
		/// </remarks>
		public int Backlog
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

		public long? MaxReadBufferSize
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

		public long? MaxWriteBufferSize
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

		/// <summary>
		/// Inline application and transport continuations instead of dispatching to the threadpool.
		/// </summary>
		/// <remarks>
		/// This will run application code on the IO thread which is why this is unsafe.
		/// It is recommended to set the DOTNET_SYSTEM_NET_SOCKETS_INLINE_COMPLETIONS environment variable to '1' when using this setting to also inline the completions
		/// at the runtime layer as well.
		/// This setting can make performance worse if there is expensive work that will end up holding onto the IO thread for longer than needed.
		/// Test to make sure this setting helps performance.
		/// </remarks>
		public bool UnsafePreferInlineScheduling
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

		internal Func<MemoryPool<byte>> MemoryPoolFactory
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

		public SocketTransportOptions()
		{
			throw null;
		}
	}
}
