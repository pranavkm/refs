using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Components.Server.Circuits
{
	internal class CircuitHost : IAsyncDisposable
	{
		private static class Log
		{
			private static class EventIds
			{
				public static readonly EventId InitializationStarted;

				public static readonly EventId InitializationSucceeded;

				public static readonly EventId InitializationFailed;

				public static readonly EventId DisposeStarted;

				public static readonly EventId DisposeSucceeded;

				public static readonly EventId DisposeFailed;

				public static readonly EventId OnCircuitOpened;

				public static readonly EventId OnConnectionUp;

				public static readonly EventId OnConnectionDown;

				public static readonly EventId OnCircuitClosed;

				public static readonly EventId CircuitHandlerFailed;

				public static readonly EventId CircuitUnhandledException;

				public static readonly EventId CircuitTransmittingClientError;

				public static readonly EventId CircuitTransmittedClientErrorSuccess;

				public static readonly EventId CircuitTransmitErrorFailed;

				public static readonly EventId UnhandledExceptionClientDisconnected;

				public static readonly EventId DispatchEventFailedToParseEventData;

				public static readonly EventId DispatchEventFailedToDispatchEvent;

				public static readonly EventId BeginInvokeDotNet;

				public static readonly EventId BeginInvokeDotNetFailed;

				public static readonly EventId EndInvokeDispatchException;

				public static readonly EventId EndInvokeJSFailed;

				public static readonly EventId EndInvokeJSSucceeded;

				public static readonly EventId DispatchEventThroughJSInterop;

				public static readonly EventId LocationChange;

				public static readonly EventId LocationChangeSucceeded;

				public static readonly EventId LocationChangeFailed;

				public static readonly EventId LocationChangeFailedInCircuit;

				public static readonly EventId OnRenderCompletedFailed;
			}

			public static void InitializationStarted(ILogger logger)
			{
				throw null;
			}

			public static void InitializationSucceeded(ILogger logger)
			{
				throw null;
			}

			public static void InitializationFailed(ILogger logger, Exception exception)
			{
				throw null;
			}

			public static void DisposeStarted(ILogger logger, CircuitId circuitId)
			{
				throw null;
			}

			public static void DisposeSucceeded(ILogger logger, CircuitId circuitId)
			{
				throw null;
			}

			public static void DisposeFailed(ILogger logger, CircuitId circuitId, Exception exception)
			{
				throw null;
			}

			public static void CircuitOpened(ILogger logger, CircuitId circuitId)
			{
				throw null;
			}

			public static void ConnectionUp(ILogger logger, CircuitId circuitId, string connectionId)
			{
				throw null;
			}

			public static void ConnectionDown(ILogger logger, CircuitId circuitId, string connectionId)
			{
				throw null;
			}

			public static void CircuitClosed(ILogger logger, CircuitId circuitId)
			{
				throw null;
			}

			public static void CircuitHandlerFailed(ILogger logger, CircuitHandler handler, string handlerMethod, Exception exception)
			{
				throw null;
			}

			public static void CircuitUnhandledException(ILogger logger, CircuitId circuitId, Exception exception)
			{
				throw null;
			}

			public static void CircuitTransmitErrorFailed(ILogger logger, CircuitId circuitId, Exception exception)
			{
				throw null;
			}

			public static void EndInvokeDispatchException(ILogger logger, Exception ex)
			{
				throw null;
			}

			public static void EndInvokeJSFailed(ILogger logger, long asyncHandle, string arguments)
			{
				throw null;
			}

			public static void EndInvokeJSSucceeded(ILogger logger, long asyncCall)
			{
				throw null;
			}

			public static void DispatchEventFailedToParseEventData(ILogger logger, Exception ex)
			{
				throw null;
			}

			public static void DispatchEventFailedToDispatchEvent(ILogger logger, string eventHandlerId, Exception ex)
			{
				throw null;
			}

			public static void BeginInvokeDotNet(ILogger logger, string callId, string assemblyName, string methodIdentifier, long dotNetObjectId)
			{
				throw null;
			}

			public static void BeginInvokeDotNetFailed(ILogger logger, string callId, string assemblyName, string methodIdentifier, long dotNetObjectId, Exception exception)
			{
				throw null;
			}

			public static void LocationChange(ILogger logger, string uri, CircuitId circuitId)
			{
				throw null;
			}

			public static void LocationChangeSucceeded(ILogger logger, string uri, CircuitId circuitId)
			{
				throw null;
			}

			public static void LocationChangeFailed(ILogger logger, string uri, CircuitId circuitId, Exception exception)
			{
				throw null;
			}

			public static void LocationChangeFailedInCircuit(ILogger logger, string uri, CircuitId circuitId, Exception exception)
			{
				throw null;
			}

			public static void UnhandledExceptionClientDisconnected(ILogger logger, CircuitId circuitId, Exception exception)
			{
				throw null;
			}

			public static void CircuitTransmittingClientError(ILogger logger, CircuitId circuitId)
			{
				throw null;
			}

			public static void CircuitTransmittedClientErrorSuccess(ILogger logger, CircuitId circuitId)
			{
				throw null;
			}

			public static void OnRenderCompletedFailed(ILogger logger, long renderId, CircuitId circuitId, Exception e)
			{
				throw null;
			}
		}

		public CircuitHandle Handle
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public CircuitId CircuitId
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public Circuit Circuit
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public CircuitClientProxy Client
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

		public RemoteJSRuntime JSRuntime
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public RemoteRenderer Renderer
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public IReadOnlyList<ComponentDescriptor> Descriptors
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public IServiceProvider Services
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public event UnhandledExceptionEventHandler UnhandledException
		{
			[CompilerGenerated]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			remove
			{
				throw null;
			}
		}

		public CircuitHost(CircuitId circuitId, IServiceScope scope, CircuitOptions options, CircuitClientProxy client, RemoteRenderer renderer, IReadOnlyList<ComponentDescriptor> descriptors, RemoteJSRuntime jsRuntime, CircuitHandler[] circuitHandlers, ILogger logger)
		{
			throw null;
		}

		public Task InitializeAsync(CancellationToken cancellationToken)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CDisposeAsync_003Ed__36))]
		[DebuggerStepThrough]
		public ValueTask DisposeAsync()
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003COnConnectionUpAsync_003Ed__38))]
		[DebuggerStepThrough]
		public Task OnConnectionUpAsync(CancellationToken cancellationToken)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003COnConnectionDownAsync_003Ed__39))]
		[DebuggerStepThrough]
		public Task OnConnectionDownAsync(CancellationToken cancellationToken)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003COnRenderCompletedAsync_003Ed__41))]
		[DebuggerStepThrough]
		public Task OnRenderCompletedAsync(long renderId, string errorMessageOrNull)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CBeginInvokeDotNetFromJS_003Ed__42))]
		[DebuggerStepThrough]
		public Task BeginInvokeDotNetFromJS(string callId, string assemblyName, string methodIdentifier, long dotNetObjectId, string argsJson)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CEndInvokeJSFromDotNet_003Ed__43))]
		[DebuggerStepThrough]
		public Task EndInvokeJSFromDotNet(long asyncCall, bool succeeded, string arguments)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CDispatchEvent_003Ed__44))]
		[DebuggerStepThrough]
		public Task DispatchEvent(string eventDescriptorJson, string eventArgsJson)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003COnLocationChangedAsync_003Ed__45))]
		[DebuggerStepThrough]
		public Task OnLocationChangedAsync(string uri, bool intercepted)
		{
			throw null;
		}

		public void SetCircuitUser(ClaimsPrincipal user)
		{
			throw null;
		}

		public void SendPendingBatches()
		{
			throw null;
		}
	}
}
