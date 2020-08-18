using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption;
using Microsoft.AspNetCore.DataProtection.KeyManagement.Internal;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.DataProtection.KeyManagement
{
	/// <summary>
	/// A basic implementation of <see cref="T:Microsoft.AspNetCore.DataProtection.KeyManagement.Internal.IKeyRing" />.
	/// </summary>
	internal sealed class KeyRing : IKeyRing
	{
		private sealed class KeyHolder
		{
			internal KeyHolder(IKey key)
			{
				throw null;
			}

			internal IAuthenticatedEncryptor GetEncryptorInstance(out bool isRevoked)
			{
				throw null;
			}
		}

		public IAuthenticatedEncryptor DefaultAuthenticatedEncryptor
		{
			get
			{
				throw null;
			}
		}

		public Guid DefaultKeyId
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public KeyRing(IKey defaultKey, IEnumerable<IKey> allKeys)
		{
			throw null;
		}

		public IAuthenticatedEncryptor GetAuthenticatedEncryptorByKeyId(Guid keyId, out bool isRevoked)
		{
			throw null;
		}
	}
}
