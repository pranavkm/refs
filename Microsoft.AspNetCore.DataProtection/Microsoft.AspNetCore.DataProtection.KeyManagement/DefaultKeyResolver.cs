using Microsoft.AspNetCore.DataProtection.KeyManagement.Internal;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.DataProtection.KeyManagement
{
	/// <summary>
	/// Implements policy for resolving the default key from a candidate keyring.
	/// </summary>
	internal sealed class DefaultKeyResolver : IDefaultKeyResolver
	{
		public DefaultKeyResolver(IOptions<KeyManagementOptions> keyManagementOptions)
		{
			throw null;
		}

		public DefaultKeyResolver(IOptions<KeyManagementOptions> keyManagementOptions, ILoggerFactory loggerFactory)
		{
			throw null;
		}

		public DefaultKeyResolution ResolveDefaultKeyPolicy(DateTimeOffset now, IEnumerable<IKey> allKeys)
		{
			throw null;
		}
	}
}
