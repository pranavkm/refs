using Microsoft.AspNetCore.SignalR.Protocol;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Internal;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.SignalR.Internal
{
	internal class DefaultHubDispatcher<THub> : HubDispatcher<THub> where THub : Hub
	{
		private static class Log
		{
			public static void ReceivedHubInvocation(ILogger logger, InvocationMessage invocationMessage)
			{
				throw null;
			}

			public static void UnsupportedMessageReceived(ILogger logger, string messageType)
			{
				throw null;
			}

			public static void UnknownHubMethod(ILogger logger, string hubMethod)
			{
				throw null;
			}

			public static void HubMethodNotAuthorized(ILogger logger, string hubMethod)
			{
				throw null;
			}

			public static void StreamingResult(ILogger logger, string invocationId, ObjectMethodExecutor objectMethodExecutor)
			{
				throw null;
			}

			public static void SendingResult(ILogger logger, string invocationId, ObjectMethodExecutor objectMethodExecutor)
			{
				throw null;
			}

			public static void FailedInvokingHubMethod(ILogger logger, string hubMethod, Exception exception)
			{
				throw null;
			}

			public static void HubMethodBound(ILogger logger, string hubName, string hubMethod)
			{
				throw null;
			}

			public static void CancelStream(ILogger logger, string invocationId)
			{
				throw null;
			}

			public static void UnexpectedCancel(ILogger logger)
			{
				throw null;
			}

			public static void ReceivedStreamHubInvocation(ILogger logger, StreamInvocationMessage invocationMessage)
			{
				throw null;
			}

			public static void StreamingMethodCalledWithInvoke(ILogger logger, HubMethodInvocationMessage invocationMessage)
			{
				throw null;
			}

			public static void NonStreamingMethodCalledWithStream(ILogger logger, HubMethodInvocationMessage invocationMessage)
			{
				throw null;
			}

			public static void InvalidReturnValueFromStreamingMethod(ILogger logger, string hubMethod)
			{
				throw null;
			}

			public static void ReceivedStreamItem(ILogger logger, StreamItemMessage message)
			{
				throw null;
			}

			public static void StartingParameterStream(ILogger logger, string streamId)
			{
				throw null;
			}

			public static void CompletingStream(ILogger logger, CompletionMessage message)
			{
				throw null;
			}

			public static void ClosingStreamWithBindingError(ILogger logger, CompletionMessage message)
			{
				throw null;
			}

			public static void UnexpectedStreamCompletion(ILogger logger)
			{
				throw null;
			}

			public static void UnexpectedStreamItem(ILogger logger)
			{
				throw null;
			}

			public static void InvalidHubParameters(ILogger logger, string hubMethod, Exception exception)
			{
				throw null;
			}
		}

		public DefaultHubDispatcher(IServiceScopeFactory serviceScopeFactory, IHubContext<THub> hubContext, bool enableDetailedErrors, ILogger<DefaultHubDispatcher<THub>> logger, List<IHubFilter> hubFilters)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(DefaultHubDispatcher<>._003COnConnectedAsync_003Ed__9))]
		[DebuggerStepThrough]
		public override Task OnConnectedAsync(HubConnectionContext connection)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(DefaultHubDispatcher<>._003COnDisconnectedAsync_003Ed__10))]
		[DebuggerStepThrough]
		public override Task OnDisconnectedAsync(HubConnectionContext connection, Exception exception)
		{
			throw null;
		}

		public override Task DispatchMessageAsync(HubConnectionContext connection, HubMessage hubMessage)
		{
			throw null;
		}

		public override IReadOnlyList<Type> GetParameterTypes(string methodName)
		{
			throw null;
		}
	}
}
