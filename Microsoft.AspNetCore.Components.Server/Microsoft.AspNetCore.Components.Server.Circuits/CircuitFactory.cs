using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Security.Claims;

namespace Microsoft.AspNetCore.Components.Server.Circuits
{
	internal class CircuitFactory
	{
		private static class Log
		{
			internal static void CreatedCircuit(ILogger logger, CircuitHost circuitHost)
			{
				throw null;
			}
		}

		public CircuitFactory(IServiceScopeFactory scopeFactory, ILoggerFactory loggerFactory, CircuitIdFactory circuitIdFactory, IOptions<CircuitOptions> options)
		{
			throw null;
		}

		public CircuitHost CreateCircuitHost(IReadOnlyList<ComponentDescriptor> components, CircuitClientProxy client, string baseUri, string uri, ClaimsPrincipal user)
		{
			throw null;
		}
	}
}
