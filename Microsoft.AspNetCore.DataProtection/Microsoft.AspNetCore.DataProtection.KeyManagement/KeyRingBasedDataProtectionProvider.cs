using Microsoft.AspNetCore.DataProtection.KeyManagement.Internal;
using Microsoft.Extensions.Logging;

namespace Microsoft.AspNetCore.DataProtection.KeyManagement
{
	internal sealed class KeyRingBasedDataProtectionProvider : IDataProtectionProvider
	{
		public KeyRingBasedDataProtectionProvider(IKeyRingProvider keyRingProvider, ILoggerFactory loggerFactory)
		{
			throw null;
		}

		public IDataProtector CreateProtector(string purpose)
		{
			throw null;
		}
	}
}
