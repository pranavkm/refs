using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Microsoft.AspNetCore.DataProtection.Internal
{
	internal class KeyManagementOptionsSetup : IConfigureOptions<KeyManagementOptions>
	{
		public KeyManagementOptionsSetup()
		{
			throw null;
		}

		public KeyManagementOptionsSetup(ILoggerFactory loggerFactory)
		{
			throw null;
		}

		public KeyManagementOptionsSetup(IRegistryPolicyResolver registryPolicyResolver)
		{
			throw null;
		}

		public KeyManagementOptionsSetup(ILoggerFactory loggerFactory, IRegistryPolicyResolver registryPolicyResolver)
		{
			throw null;
		}

		public void Configure(KeyManagementOptions options)
		{
			throw null;
		}
	}
}
