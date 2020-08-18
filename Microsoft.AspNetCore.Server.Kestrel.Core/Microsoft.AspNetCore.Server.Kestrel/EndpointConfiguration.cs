using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.AspNetCore.Server.Kestrel.Https;
using Microsoft.Extensions.Configuration;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Server.Kestrel
{
	public class EndpointConfiguration
	{
		public bool IsHttps
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public ListenOptions ListenOptions
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public HttpsConnectionAdapterOptions HttpsOptions
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public IConfigurationSection ConfigSection
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		internal EndpointConfiguration(bool isHttps, ListenOptions listenOptions, HttpsConnectionAdapterOptions httpsOptions, IConfigurationSection configSection)
		{
			throw null;
		}
	}
}
