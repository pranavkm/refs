using Microsoft.AspNetCore.SignalR.Protocol;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.SignalR.Internal
{
	internal abstract class HubDispatcher<THub> where THub : Hub
	{
		public abstract Task OnConnectedAsync(HubConnectionContext connection);

		public abstract Task OnDisconnectedAsync(HubConnectionContext connection, Exception? exception);

		public abstract Task DispatchMessageAsync(HubConnectionContext connection, HubMessage hubMessage);

		public abstract IReadOnlyList<Type> GetParameterTypes(string name);

		protected HubDispatcher()
		{
			throw null;
		}
	}
}
