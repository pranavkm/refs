using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption;
using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.DataProtection.KeyManagement
{
	/// <summary>
	/// The basic implementation of <see cref="T:Microsoft.AspNetCore.DataProtection.KeyManagement.IKey" />.
	/// </summary>
	internal abstract class KeyBase : IKey
	{
		public DateTimeOffset ActivationDate
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public DateTimeOffset CreationDate
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public DateTimeOffset ExpirationDate
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public bool IsRevoked
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public Guid KeyId
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public IAuthenticatedEncryptorDescriptor Descriptor
		{
			get
			{
				throw null;
			}
		}

		public KeyBase(Guid keyId, DateTimeOffset creationDate, DateTimeOffset activationDate, DateTimeOffset expirationDate, Lazy<IAuthenticatedEncryptorDescriptor> lazyDescriptor, IEnumerable<IAuthenticatedEncryptorFactory> encryptorFactories)
		{
			throw null;
		}

		public IAuthenticatedEncryptor CreateEncryptor()
		{
			throw null;
		}

		internal void SetRevoked()
		{
			throw null;
		}
	}
}
