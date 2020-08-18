using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption;
using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel;
using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.DataProtection.XmlEncryption;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.DataProtection.KeyManagement
{
	/// <summary>
	/// Options that control how an <see cref="T:Microsoft.AspNetCore.DataProtection.KeyManagement.IKeyManager" /> should behave.
	/// </summary>
	public class KeyManagementOptions
	{
		/// <summary>
		/// Specifies whether the data protection system should auto-generate keys.
		/// </summary>
		/// <remarks>
		/// If this value is 'false', the system will not generate new keys automatically.
		/// The key ring must contain at least one active non-revoked key, otherwise calls
		/// to <see cref="M:Microsoft.AspNetCore.DataProtection.IDataProtector.Protect(System.Byte[])" /> may fail. The system may end up
		/// protecting payloads to expired keys if this property is set to 'false'.
		/// The default value is 'true'.
		/// </remarks>
		public bool AutoGenerateKeys
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

		/// <summary>
		/// Specifies the period before key expiration in which a new key should be generated
		/// so that it has time to propagate fully throughout the key ring. For example, if this
		/// period is 72 hours, then a new key will be created and persisted to storage
		/// approximately 72 hours before expiration.
		/// </summary>
		/// <remarks>
		/// This value is currently fixed at 48 hours.
		/// </remarks>
		internal TimeSpan KeyPropagationWindow
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Controls the auto-refresh period where the key ring provider will
		/// flush its collection of cached keys and reread the collection from
		/// backing storage.
		/// </summary>
		/// <remarks>
		/// This value is currently fixed at 24 hours.
		/// </remarks>
		internal TimeSpan KeyRingRefreshPeriod
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Specifies the maximum clock skew allowed between servers when reading
		/// keys from the key ring. The key ring may use a key which has not yet
		/// been activated or which has expired if the key's valid lifetime is within
		/// the allowed clock skew window. This value can be set to <see cref="F:System.TimeSpan.Zero" />
		/// if key activation and expiration times should be strictly honored by this server.
		/// </summary>
		/// <remarks>
		/// This value is currently fixed at 5 minutes.
		/// </remarks>
		internal TimeSpan MaxServerClockSkew
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Controls the lifetime (number of days before expiration)
		/// for newly-generated keys.
		/// </summary>
		/// <remarks>
		/// The lifetime cannot be less than one week.
		/// The default value is 90 days.
		/// </remarks>
		public TimeSpan NewKeyLifetime
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// The <see cref="T:Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.AlgorithmConfiguration" /> instance that can be used to create
		/// the <see cref="T:Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IAuthenticatedEncryptorDescriptor" /> instance.
		/// </summary>
		public AlgorithmConfiguration AuthenticatedEncryptorConfiguration
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

		/// <summary>
		/// The list of <see cref="T:Microsoft.AspNetCore.DataProtection.KeyManagement.IKeyEscrowSink" /> to store the key material in.
		/// </summary>
		public IList<IKeyEscrowSink> KeyEscrowSinks
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// The <see cref="T:Microsoft.AspNetCore.DataProtection.Repositories.IXmlRepository" /> to use for storing and retrieving XML elements.
		/// </summary>
		public IXmlRepository XmlRepository
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

		/// <summary>
		/// The <see cref="T:Microsoft.AspNetCore.DataProtection.XmlEncryption.IXmlEncryptor" /> to use for encrypting XML elements.
		/// </summary>
		public IXmlEncryptor XmlEncryptor
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

		/// <summary>
		/// The list of <see cref="T:Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.IAuthenticatedEncryptorFactory" /> that will be used for creating
		/// <see cref="T:Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.IAuthenticatedEncryptor" />s.
		/// </summary>
		public IList<IAuthenticatedEncryptorFactory> AuthenticatedEncryptorFactories
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public KeyManagementOptions()
		{
			throw null;
		}

		internal KeyManagementOptions(KeyManagementOptions other)
		{
			throw null;
		}
	}
}
