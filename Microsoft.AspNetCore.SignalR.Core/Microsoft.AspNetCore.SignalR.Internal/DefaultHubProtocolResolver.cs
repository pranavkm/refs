using Microsoft.AspNetCore.SignalR.Protocol;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.SignalR.Internal
{
	internal class DefaultHubProtocolResolver : IHubProtocolResolver
	{
		private static class Log
		{
			public static void RegisteredSignalRProtocol(ILogger logger, string protocolName, Type implementationType)
			{
				throw null;
			}

			public static void FoundImplementationForProtocol(ILogger logger, string protocolName)
			{
				throw null;
			}
		}

		public IReadOnlyList<IHubProtocol> AllProtocols
		{
			get
			{
				throw null;
			}
		}

		public DefaultHubProtocolResolver(IEnumerable<IHubProtocol> availableProtocols, ILogger<DefaultHubProtocolResolver> logger)
		{
			throw null;
		}

		public virtual IHubProtocol? GetProtocol(string protocolName, IReadOnlyList<string>? supportedProtocols)
		{
			throw null;
		}
	}
}
