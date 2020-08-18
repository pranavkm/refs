using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Microsoft.AspNetCore.DataProtection.KeyManagement.Internal
{
	/// <summary>
	/// Wraps both a keyring and its expiration policy.
	/// </summary>
	public sealed class CacheableKeyRing
	{
		internal DateTime ExpirationTimeUtc
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		internal IKeyRing KeyRing
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		internal CacheableKeyRing(CancellationToken expirationToken, DateTimeOffset expirationTime, IKey defaultKey, IEnumerable<IKey> allKeys)
		{
			throw null;
		}

		internal CacheableKeyRing(CancellationToken expirationToken, DateTimeOffset expirationTime, IKeyRing keyRing)
		{
			throw null;
		}

		internal static bool IsValid(CacheableKeyRing keyRing, DateTime utcNow)
		{
			throw null;
		}

		/// <summary>
		/// Returns a new <see cref="T:Microsoft.AspNetCore.DataProtection.KeyManagement.Internal.CacheableKeyRing" /> which is identical to 'this' but with a
		/// lifetime extended 2 minutes from <paramref name="now" />. The inner cancellation token
		/// is also disconnected.
		/// </summary>
		internal CacheableKeyRing WithTemporaryExtendedLifetime(DateTimeOffset now)
		{
			throw null;
		}
	}
}
