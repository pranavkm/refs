using Microsoft.AspNetCore.Connections;
using System.Buffers;
using System.Diagnostics;
using System.IO.Pipelines;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Transport.Sockets.Internal
{
	internal sealed class SocketConnection : TransportConnection
	{
		public PipeWriter Input
		{
			get
			{
				throw null;
			}
		}

		public PipeReader Output
		{
			get
			{
				throw null;
			}
		}

		public override MemoryPool<byte> MemoryPool
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		internal SocketConnection(Socket socket, MemoryPool<byte> memoryPool, PipeScheduler transportScheduler, ISocketsTrace trace, long? maxReadBufferSize = null, long? maxWriteBufferSize = null, bool waitForData = true, bool useInlineSchedulers = false)
		{
			throw null;
		}

		public void Start()
		{
			throw null;
		}

		public override void Abort(ConnectionAbortedException abortReason)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CDisposeAsync_003Ed__26))]
		[DebuggerStepThrough]
		public override ValueTask DisposeAsync()
		{
			throw null;
		}
	}
}
