using Microsoft.AspNetCore.Components.Server.Circuits;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Components.Server
{
	internal class CircuitDisconnectMiddleware
	{
		private class Log
		{
			public static void CircuitTerminatingGracefully(ILogger logger, CircuitId circuitId)
			{
				throw null;
			}

			public static void CircuitTerminatedGracefully(ILogger logger, CircuitId circuitId)
			{
				throw null;
			}

			public static void InvalidCircuitId(ILogger logger, string circuitSecret)
			{
				throw null;
			}

			public Log()
			{
				throw null;
			}
		}

		public ILogger<CircuitDisconnectMiddleware> Logger
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public CircuitRegistry Registry
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public CircuitIdFactory CircuitIdFactory
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public RequestDelegate Next
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public CircuitDisconnectMiddleware(ILogger<CircuitDisconnectMiddleware> logger, CircuitRegistry registry, CircuitIdFactory circuitIdFactory, RequestDelegate next)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CInvoke_003Ed__14))]
		[DebuggerStepThrough]
		public Task Invoke(HttpContext context)
		{
			throw null;
		}
	}
}
