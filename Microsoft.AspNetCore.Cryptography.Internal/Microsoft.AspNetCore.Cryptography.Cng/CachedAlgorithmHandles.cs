using Microsoft.AspNetCore.Cryptography.SafeHandles;
using System;

namespace Microsoft.AspNetCore.Cryptography.Cng
{
	/// <summary>
	/// Provides cached CNG algorithm provider instances, as calling BCryptOpenAlgorithmProvider is expensive.
	/// Callers should use caution never to dispose of the algorithm provider instances returned by this type.
	/// </summary>
	internal static class CachedAlgorithmHandles
	{
		private struct CachedAlgorithmInfo
		{
			private WeakReference<BCryptAlgorithmHandle> _algorithmHandle;

			private readonly Func<BCryptAlgorithmHandle> _factory;

			public CachedAlgorithmInfo(Func<BCryptAlgorithmHandle> factory)
			{
				throw null;
			}

			public static BCryptAlgorithmHandle GetAlgorithmHandle(ref CachedAlgorithmInfo cachedAlgorithmInfo)
			{
				throw null;
			}
		}

		public static BCryptAlgorithmHandle AES_CBC
		{
			get
			{
				throw null;
			}
		}

		public static BCryptAlgorithmHandle AES_GCM
		{
			get
			{
				throw null;
			}
		}

		public static BCryptAlgorithmHandle HMAC_SHA1
		{
			get
			{
				throw null;
			}
		}

		public static BCryptAlgorithmHandle HMAC_SHA256
		{
			get
			{
				throw null;
			}
		}

		public static BCryptAlgorithmHandle HMAC_SHA512
		{
			get
			{
				throw null;
			}
		}

		public static BCryptAlgorithmHandle PBKDF2
		{
			get
			{
				throw null;
			}
		}

		public static BCryptAlgorithmHandle SHA1
		{
			get
			{
				throw null;
			}
		}

		public static BCryptAlgorithmHandle SHA256
		{
			get
			{
				throw null;
			}
		}

		public static BCryptAlgorithmHandle SHA512
		{
			get
			{
				throw null;
			}
		}

		public static BCryptAlgorithmHandle SP800_108_CTR_HMAC
		{
			get
			{
				throw null;
			}
		}
	}
}
