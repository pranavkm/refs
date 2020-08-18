using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Server.Kestrel.Core.Features;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal
{
	internal class ConnectionLimitMiddleware<T> where T : BaseConnectionContext
	{
		private class ConnectionReleasor : IDecrementConcurrentConnectionCountFeature
		{
			public ConnectionReleasor(ResourceCounter normalConnectionCounter)
			{
				throw null;
			}

			public void ReleaseConnection()
			{
				throw null;
			}
		}

		public ConnectionLimitMiddleware(Func<T, Task> next, long connectionLimit, IKestrelTrace trace)
		{
			throw null;
		}

		internal ConnectionLimitMiddleware(Func<T, Task> next, ResourceCounter concurrentConnectionCounter, IKestrelTrace trace)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(ConnectionLimitMiddleware<>._003COnConnectionAsync_003Ed__5))]
		[DebuggerStepThrough]
		public Task OnConnectionAsync(T connection)
		{
			throw null;
		}
	}
}
