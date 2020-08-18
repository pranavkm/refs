using System;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.SignalR.Internal
{
	internal class HubConnectionBinder<THub> : IInvocationBinder where THub : Hub
	{
		public HubConnectionBinder(HubDispatcher<THub> dispatcher, HubConnectionContext connection)
		{
			throw null;
		}

		public IReadOnlyList<Type> GetParameterTypes(string methodName)
		{
			throw null;
		}

		public Type GetReturnType(string invocationId)
		{
			throw null;
		}

		public Type GetStreamItemType(string streamId)
		{
			throw null;
		}
	}
}
