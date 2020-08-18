using Microsoft.AspNetCore.SignalR;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Components.Server.Circuits
{
	internal class CircuitClientProxy : IClientProxy
	{
		public bool Connected
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public string ConnectionId
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public IClientProxy Client
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public CircuitClientProxy()
		{
			throw null;
		}

		public CircuitClientProxy(IClientProxy clientProxy, string connectionId)
		{
			throw null;
		}

		public void Transfer(IClientProxy clientProxy, string connectionId)
		{
			throw null;
		}

		public void SetDisconnected()
		{
			throw null;
		}

		public Task SendCoreAsync(string method, object[] args, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}
	}
}
