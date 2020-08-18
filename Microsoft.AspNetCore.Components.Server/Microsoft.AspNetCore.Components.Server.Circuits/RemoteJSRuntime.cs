using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.JSInterop;
using Microsoft.JSInterop.Infrastructure;
using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components.Server.Circuits
{
	internal class RemoteJSRuntime : JSRuntime
	{
		public static class Log
		{
			internal static void BeginInvokeJS(ILogger logger, long asyncHandle, string identifier)
			{
				throw null;
			}

			internal static void InvokeDotNetMethodException(ILogger logger, in DotNetInvocationInfo invocationInfo, Exception exception)
			{
				throw null;
			}

			internal static void InvokeDotNetMethodSuccess(ILogger<RemoteJSRuntime> logger, in DotNetInvocationInfo invocationInfo)
			{
				throw null;
			}
		}

		public ElementReferenceContext ElementReferenceContext
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public RemoteJSRuntime(IOptions<CircuitOptions> options, ILogger<RemoteJSRuntime> logger)
		{
			throw null;
		}

		internal void Initialize(CircuitClientProxy clientProxy)
		{
			throw null;
		}

		protected override void EndInvokeDotNet(DotNetInvocationInfo invocationInfo, in DotNetInvocationResult invocationResult)
		{
			throw null;
		}

		protected override void BeginInvokeJS(long asyncHandle, string identifier, string argsJson)
		{
			throw null;
		}
	}
}
