using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Components.Server.Circuits
{
	/// <summary>
	/// <see cref="T:Microsoft.AspNetCore.Components.Server.Circuits.CircuitRegistry" /> manages the lifetime of a <see cref="T:Microsoft.AspNetCore.Components.Server.Circuits.CircuitHost" />.
	/// </summary>
	/// <remarks>
	/// Hosts start off by being registered using <see cref="T:Microsoft.AspNetCore.Components.Server.Circuits.CircuitHost" />.
	///
	/// In the simplest of cases, the client disconnects e.g. the user is done with the application and closes the browser.
	/// The server (eventually) learns of the disconnect. The host is transitioned from <see cref="P:Microsoft.AspNetCore.Components.Server.Circuits.CircuitRegistry.ConnectedCircuits" /> to
	/// <see cref="P:Microsoft.AspNetCore.Components.Server.Circuits.CircuitRegistry.DisconnectedCircuits" /> where it sits with an expiration time. We'll mark the associated <see cref="T:Microsoft.AspNetCore.Components.Server.Circuits.CircuitClientProxy" /> as disconnected
	/// so that consumers of the Circuit know of the current state.
	/// Once the entry for the host in <see cref="P:Microsoft.AspNetCore.Components.Server.Circuits.CircuitRegistry.DisconnectedCircuits" /> expires, we'll dispose off the host.
	///
	/// The alternate case is when the disconnect was transient, e.g. due to a network failure, and the client attempts to reconnect.
	/// We'll attempt to connect it back to the host and the preserved server state, when available. In this event, we do the opposite of
	/// what we did during disconnect - transition the host from <see cref="P:Microsoft.AspNetCore.Components.Server.Circuits.CircuitRegistry.DisconnectedCircuits" /> to <see cref="P:Microsoft.AspNetCore.Components.Server.Circuits.CircuitRegistry.ConnectedCircuits" />, and transfer
	/// the <see cref="T:Microsoft.AspNetCore.Components.Server.Circuits.CircuitClientProxy" /> to use the new client instance that attempted to reconnect to the server. Removing the entry from
	/// <see cref="P:Microsoft.AspNetCore.Components.Server.Circuits.CircuitRegistry.DisconnectedCircuits" /> should ensure we no longer have to concern ourselves with entry expiration.
	///
	/// Knowing when a client disconnected is not an exact science. There's a fair possibility that a client may reconnect before the server realizes.
	/// Consequently, we have to account for reconnects and disconnects occuring simultaneously as well as appearing out of order.
	/// To manage this, we use a critical section to manage all state transitions.
	/// </remarks>
	internal class CircuitRegistry
	{
		private readonly struct DisconnectedCircuitEntry
		{
			public CircuitHost CircuitHost
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			public CancellationTokenSource TokenSource
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			public DisconnectedCircuitEntry(CircuitHost circuitHost, CancellationTokenSource tokenSource)
			{
				throw null;
			}
		}

		private static class Log
		{
			private static class EventIds
			{
				public static readonly EventId ExceptionDisposingCircuit;

				public static readonly EventId ExceptionDisposingTokenSource;

				public static readonly EventId AttemptingToReconnect;

				public static readonly EventId FailedToFindCircuit;

				public static readonly EventId ConnectingToActiveCircuit;

				public static readonly EventId ConnectingToDisconnectedCircuit;

				public static readonly EventId FailedToReconnectToCircuit;

				public static readonly EventId CircuitDisconnectStarted;

				public static readonly EventId CircuitNotActive;

				public static readonly EventId CircuitConnectedToDifferentConnection;

				public static readonly EventId CircuitMarkedDisconnected;

				public static readonly EventId CircuitEvicted;

				public static readonly EventId CircuitDisconnectedPermanently;

				public static readonly EventId CircuitExceptionHandlerFailed;
			}

			public static void UnhandledExceptionDisposingCircuitHost(ILogger logger, Exception exception)
			{
				throw null;
			}

			public static void ExceptionDisposingTokenSource(ILogger logger, Exception exception)
			{
				throw null;
			}

			public static void CircuitConnectStarted(ILogger logger, CircuitId circuitId)
			{
				throw null;
			}

			public static void FailedToFindCircuit(ILogger logger, CircuitId circuitId)
			{
				throw null;
			}

			public static void ConnectingToActiveCircuit(ILogger logger, CircuitId circuitId, string connectionId)
			{
				throw null;
			}

			public static void ConnectingToDisconnectedCircuit(ILogger logger, CircuitId circuitId, string connectionId)
			{
				throw null;
			}

			public static void FailedToReconnectToCircuit(ILogger logger, CircuitId circuitId, Exception exception = null)
			{
				throw null;
			}

			public static void ReconnectionSucceeded(ILogger logger, CircuitId circuitId)
			{
				throw null;
			}

			public static void CircuitDisconnectStarted(ILogger logger, CircuitId circuitId, string connectionId)
			{
				throw null;
			}

			public static void CircuitNotActive(ILogger logger, CircuitId circuitId)
			{
				throw null;
			}

			public static void CircuitConnectedToDifferentConnection(ILogger logger, CircuitId circuitId, string connectionId)
			{
				throw null;
			}

			public static void CircuitMarkedDisconnected(ILogger logger, CircuitId circuitId)
			{
				throw null;
			}

			public static void CircuitDisconnectedPermanently(ILogger logger, CircuitId circuitId)
			{
				throw null;
			}

			public static void CircuitEvicted(ILogger logger, CircuitId circuitId, EvictionReason evictionReason)
			{
				throw null;
			}

			public static void CircuitExceptionHandlerFailed(ILogger logger, CircuitId circuitId, Exception exception)
			{
				throw null;
			}
		}

		internal ConcurrentDictionary<CircuitId, CircuitHost> ConnectedCircuits
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		internal MemoryCache DisconnectedCircuits
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public CircuitRegistry(IOptions<CircuitOptions> options, ILogger<CircuitRegistry> logger, CircuitIdFactory CircuitHostFactory)
		{
			throw null;
		}

		/// <summary>
		/// Registers an active <see cref="T:Microsoft.AspNetCore.Components.Server.Circuits.CircuitHost" /> with the register.
		/// </summary>
		public void Register(CircuitHost circuitHost)
		{
			throw null;
		}

		public virtual Task DisconnectAsync(CircuitHost circuitHost, string connectionId)
		{
			throw null;
		}

		protected virtual bool DisconnectCore(CircuitHost circuitHost, string connectionId)
		{
			throw null;
		}

		public void RegisterDisconnectedCircuit(CircuitHost circuitHost)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CConnectAsync_003Ed__16))]
		[DebuggerStepThrough]
		public virtual Task<CircuitHost> ConnectAsync(CircuitId circuitId, IClientProxy clientProxy, string connectionId, CancellationToken cancellationToken)
		{
			throw null;
		}

		protected virtual (CircuitHost circuitHost, bool previouslyConnected) ConnectCore(CircuitId circuitId, IClientProxy clientProxy, string connectionId)
		{
			throw null;
		}

		protected virtual void OnEntryEvicted(object key, object value, EvictionReason reason, object state)
		{
			throw null;
		}

		public ValueTask TerminateAsync(CircuitId circuitId)
		{
			throw null;
		}
	}
}
