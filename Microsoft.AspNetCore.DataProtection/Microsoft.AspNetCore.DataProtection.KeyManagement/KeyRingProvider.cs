using Microsoft.AspNetCore.DataProtection.KeyManagement.Internal;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.DataProtection.KeyManagement
{
	internal sealed class KeyRingProvider : ICacheableKeyRingProvider, IKeyRingProvider
	{
		internal ICacheableKeyRingProvider CacheableKeyRingProvider
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

		internal DateTime AutoRefreshWindowEnd
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

		public KeyRingProvider(IKeyManager keyManager, IOptions<KeyManagementOptions> keyManagementOptions, IDefaultKeyResolver defaultKeyResolver)
		{
			throw null;
		}

		public KeyRingProvider(IKeyManager keyManager, IOptions<KeyManagementOptions> keyManagementOptions, IDefaultKeyResolver defaultKeyResolver, ILoggerFactory loggerFactory)
		{
			throw null;
		}

		internal bool InAutoRefreshWindow()
		{
			throw null;
		}

		public IKeyRing GetCurrentKeyRing()
		{
			throw null;
		}

		internal IKeyRing RefreshCurrentKeyRing()
		{
			throw null;
		}

		internal IKeyRing GetCurrentKeyRingCore(DateTime utcNow, bool forceRefresh = false)
		{
			throw null;
		}

		CacheableKeyRing ICacheableKeyRingProvider.GetCacheableKeyRing(DateTimeOffset now)
		{
			throw null;
		}
	}
}
