using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Certificates;
using Microsoft.AspNetCore.Server.Kestrel.Https;
using Microsoft.AspNetCore.Server.Kestrel.Https.Internal;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal
{
	internal class SniOptionsSelector
	{
		private class SniOptions
		{
			public SslServerAuthenticationOptions SslOptions
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

			public HttpProtocols HttpProtocols
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

			public SniOptions()
			{
				throw null;
			}
		}

		private class LongestStringFirstComparer : IComparer<string>
		{
			public static LongestStringFirstComparer Instance
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			public int Compare(string x, string y)
			{
				throw null;
			}
		}

		public SniOptionsSelector(string endpointName, Dictionary<string, SniConfig> sniDictionary, ICertificateConfigLoader certifcateConfigLoader, HttpsConnectionAdapterOptions fallbackHttpsOptions, HttpProtocols fallbackHttpProtocols, ILogger<HttpsConnectionMiddleware> logger)
		{
			throw null;
		}

		public SslServerAuthenticationOptions GetOptions(ConnectionContext connection, string serverName)
		{
			throw null;
		}

		public static ValueTask<SslServerAuthenticationOptions> OptionsCallback(ConnectionContext connection, SslStream stream, SslClientHelloInfo clientHelloInfo, object state, CancellationToken cancellationToken)
		{
			throw null;
		}

		internal static SslServerAuthenticationOptions CloneSslOptions(SslServerAuthenticationOptions sslOptions)
		{
			throw null;
		}
	}
}
