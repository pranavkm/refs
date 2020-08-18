using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal
{
	internal class ConfigurationReader
	{
		public IDictionary<string, CertificateConfig> Certificates
		{
			get
			{
				throw null;
			}
		}

		public EndpointDefaults EndpointDefaults
		{
			get
			{
				throw null;
			}
		}

		public IEnumerable<EndpointConfig> Endpoints
		{
			get
			{
				throw null;
			}
		}

		public ConfigurationReader(IConfiguration configuration)
		{
			throw null;
		}

		internal static void ThrowIfContainsHttpsOnlyConfiguration(EndpointConfig endpoint)
		{
			throw null;
		}
	}
}
