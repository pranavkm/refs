using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.Extensions.Logging;
using System.Buffers;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.IIS.Core
{
	internal class IISHttpContextOfT<TContext> : IISHttpContext
	{
		public IISHttpContextOfT(MemoryPool<byte> memoryPool, IHttpApplication<TContext> application, NativeSafeHandle pInProcessHandler, IISServerOptions options, IISHttpServer server, ILogger logger, bool useLatin1)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(IISHttpContextOfT<>._003CProcessRequestAsync_003Ed__2))]
		[DebuggerStepThrough]
		public override Task<bool> ProcessRequestAsync()
		{
			throw null;
		}
	}
}
