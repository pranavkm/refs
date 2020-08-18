using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Internal;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.SignalR
{
	/// <summary>
	/// Handles incoming connections and implements the SignalR Hub Protocol.
	/// </summary>
	public class HubConnectionHandler<THub> : ConnectionHandler where THub : Hub
	{
		private static class Log
		{
			public static void ErrorDispatchingHubEvent(ILogger logger, string hubMethod, Exception exception)
			{
				throw null;
			}

			public static void ErrorProcessingRequest(ILogger logger, Exception exception)
			{
				throw null;
			}

			public static void AbortFailed(ILogger logger, Exception exception)
			{
				throw null;
			}

			public static void ErrorSendingClose(ILogger logger, Exception exception)
			{
				throw null;
			}

			public static void ConnectedStarting(ILogger logger)
			{
				throw null;
			}

			public static void ConnectedEnding(ILogger logger)
			{
				throw null;
			}
		}

		internal ISystemClock SystemClock
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
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.SignalR.HubConnectionHandler`1" /> class.
		/// </summary>
		/// <param name="lifetimeManager">The hub lifetime manager.</param>
		/// <param name="protocolResolver">The protocol resolver used to resolve the protocols between client and server.</param>
		/// <param name="globalHubOptions">The global options used to initialize hubs.</param>
		/// <param name="hubOptions">Hub specific options used to initialize hubs. These options override the global options.</param>
		/// <param name="loggerFactory">The logger factory.</param>
		/// <param name="userIdProvider">The user ID provider used to get the user ID from a hub connection.</param>
		/// <param name="serviceScopeFactory">The service scope factory.</param>
		/// <remarks>This class is typically created via dependency injection.</remarks>
		public HubConnectionHandler(HubLifetimeManager<THub> lifetimeManager, IHubProtocolResolver protocolResolver, IOptions<HubOptions> globalHubOptions, IOptions<HubOptions<THub>> hubOptions, ILoggerFactory loggerFactory, IUserIdProvider userIdProvider, IServiceScopeFactory serviceScopeFactory)
		{
			throw null;
		}

		/// <inheritdoc />
		[AsyncStateMachine(typeof(HubConnectionHandler<>._003COnConnectedAsync_003Ed__15))]
		[DebuggerStepThrough]
		public override Task OnConnectedAsync(ConnectionContext connection)
		{
			throw null;
		}
	}
}
