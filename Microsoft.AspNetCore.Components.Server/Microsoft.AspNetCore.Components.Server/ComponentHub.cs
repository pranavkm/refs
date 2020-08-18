using Microsoft.AspNetCore.Components.Server.Circuits;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Components.Server
{
	internal sealed class ComponentHub : Hub
	{
		private static class Log
		{
			public static void ReceivedConfirmationForBatch(ILogger logger, long batchId)
			{
				throw null;
			}

			public static void CircuitAlreadyInitialized(ILogger logger, CircuitId circuitId)
			{
				throw null;
			}

			public static void CircuitHostNotInitialized(ILogger logger, [CallerMemberName] string callSite = "")
			{
				throw null;
			}

			public static void CircuitHostShutdown(ILogger logger, [CallerMemberName] string callSite = "")
			{
				throw null;
			}

			public static void InvalidInputData(ILogger logger, [CallerMemberName] string callSite = "")
			{
				throw null;
			}

			public static void CircuitInitializationFailed(ILogger logger, Exception exception)
			{
				throw null;
			}

			public static void CreatedCircuit(ILogger logger, CircuitId circuitId, string circuitSecret, string connectionId)
			{
				throw null;
			}

			public static void InvalidCircuitId(ILogger logger, string circuitSecret)
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the default endpoint path for incoming connections.
		/// </summary>
		public static PathString DefaultPath
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public ComponentHub(ServerComponentDeserializer serializer, CircuitFactory circuitFactory, CircuitIdFactory circuitIdFactory, CircuitRegistry circuitRegistry, ILogger<ComponentHub> logger)
		{
			throw null;
		}

		public override Task OnDisconnectedAsync(Exception exception)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CStartCircuit_003Ed__11))]
		[DebuggerStepThrough]
		public ValueTask<string> StartCircuit(string baseUri, string uri, string serializedComponentRecords)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CConnectCircuit_003Ed__12))]
		[DebuggerStepThrough]
		public ValueTask<bool> ConnectCircuit(string circuitIdSecret)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CBeginInvokeDotNetFromJS_003Ed__13))]
		[DebuggerStepThrough]
		public ValueTask BeginInvokeDotNetFromJS(string callId, string assemblyName, string methodIdentifier, long dotNetObjectId, string argsJson)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CEndInvokeJSFromDotNet_003Ed__14))]
		[DebuggerStepThrough]
		public ValueTask EndInvokeJSFromDotNet(long asyncHandle, bool succeeded, string arguments)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CDispatchBrowserEvent_003Ed__15))]
		[DebuggerStepThrough]
		public ValueTask DispatchBrowserEvent(string eventDescriptor, string eventArgs)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003COnRenderCompleted_003Ed__16))]
		[DebuggerStepThrough]
		public ValueTask OnRenderCompleted(long renderId, string errorMessageOrNull)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003COnLocationChanged_003Ed__17))]
		[DebuggerStepThrough]
		public ValueTask OnLocationChanged(string uri, bool intercepted)
		{
			throw null;
		}
	}
}
