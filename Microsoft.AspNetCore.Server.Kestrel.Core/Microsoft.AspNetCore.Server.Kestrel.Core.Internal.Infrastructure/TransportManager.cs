using Microsoft.AspNetCore.Connections;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure
{
	internal class TransportManager
	{
		private class ActiveTransport : IAsyncDisposable
		{
			public IConnectionListenerBase ConnectionListener
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			public Task AcceptLoopTask
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			public TransportConnectionManager TransportConnectionManager
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			public EndpointConfig? EndpointConfig
			{
				[System.Runtime.CompilerServices.NullableContext(2)]
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			public ActiveTransport(IConnectionListenerBase transport, Task acceptLoopTask, TransportConnectionManager transportConnectionManager, EndpointConfig? endpointConfig = null)
			{
				throw null;
			}

			[AsyncStateMachine(typeof(_003CUnbindAsync_003Ed__13))]
			[DebuggerStepThrough]
			public Task UnbindAsync(CancellationToken cancellationToken)
			{
				throw null;
			}

			public ValueTask DisposeAsync()
			{
				throw null;
			}
		}

		private class GenericConnectionListener : IConnectionListener<ConnectionContext>, IConnectionListenerBase, IAsyncDisposable
		{
			public EndPoint EndPoint
			{
				get
				{
					throw null;
				}
			}

			public GenericConnectionListener(IConnectionListener connectionListener)
			{
				throw null;
			}

			public ValueTask<ConnectionContext> AcceptAsync(CancellationToken cancellationToken = default(CancellationToken))
			{
				throw null;
			}

			public ValueTask UnbindAsync(CancellationToken cancellationToken = default(CancellationToken))
			{
				throw null;
			}

			public ValueTask DisposeAsync()
			{
				throw null;
			}
		}

		private class GenericMultiplexedConnectionListener : IConnectionListener<MultiplexedConnectionContext>, IConnectionListenerBase, IAsyncDisposable
		{
			public EndPoint EndPoint
			{
				get
				{
					throw null;
				}
			}

			public GenericMultiplexedConnectionListener(IMultiplexedConnectionListener multiplexedConnectionListener)
			{
				throw null;
			}

			public ValueTask<MultiplexedConnectionContext> AcceptAsync(CancellationToken cancellationToken = default(CancellationToken))
			{
				throw null;
			}

			public ValueTask UnbindAsync(CancellationToken cancellationToken = default(CancellationToken))
			{
				throw null;
			}

			public ValueTask DisposeAsync()
			{
				throw null;
			}
		}

		[System.Runtime.CompilerServices.NullableContext(2)]
		public TransportManager(IConnectionListenerFactory? transportFactory, IMultiplexedConnectionListenerFactory? multiplexedTransportFactory, ServiceContext serviceContext)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CBindAsync_003Ed__9))]
		[DebuggerStepThrough]
		public Task<EndPoint> BindAsync(EndPoint endPoint, ConnectionDelegate connectionDelegate, EndpointConfig? endpointConfig)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CBindAsync_003Ed__10))]
		[DebuggerStepThrough]
		public Task<EndPoint> BindAsync(EndPoint endPoint, MultiplexedConnectionDelegate multiplexedConnectionDelegate, EndpointConfig? endpointConfig)
		{
			throw null;
		}

		public Task StopEndpointsAsync(List<EndpointConfig> endpointsToStop, CancellationToken cancellationToken)
		{
			throw null;
		}

		public Task StopAsync(CancellationToken cancellationToken)
		{
			throw null;
		}
	}
}
