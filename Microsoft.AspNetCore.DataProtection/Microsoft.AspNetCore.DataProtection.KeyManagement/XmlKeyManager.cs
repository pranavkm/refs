using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel;
using Microsoft.AspNetCore.DataProtection.Internal;
using Microsoft.AspNetCore.DataProtection.KeyManagement.Internal;
using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.DataProtection.XmlEncryption;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Xml.Linq;

namespace Microsoft.AspNetCore.DataProtection.KeyManagement
{
	/// <summary>
	/// A key manager backed by an <see cref="T:Microsoft.AspNetCore.DataProtection.Repositories.IXmlRepository" />.
	/// </summary>
	public sealed class XmlKeyManager : IKeyManager, IInternalXmlKeyManager
	{
		private sealed class AggregateKeyEscrowSink : IKeyEscrowSink
		{
			public AggregateKeyEscrowSink(IList<IKeyEscrowSink> sinks)
			{
				throw null;
			}

			public void Store(Guid keyId, XElement element)
			{
				throw null;
			}
		}

		internal static readonly XName KeyElementName;

		internal static readonly XName IdAttributeName;

		internal static readonly XName VersionAttributeName;

		internal static readonly XName CreationDateElementName;

		internal static readonly XName ActivationDateElementName;

		internal static readonly XName ExpirationDateElementName;

		internal static readonly XName DescriptorElementName;

		internal static readonly XName DeserializerTypeAttributeName;

		internal static readonly XName RevocationElementName;

		internal static readonly XName RevocationDateElementName;

		internal static readonly XName ReasonElementName;

		internal IXmlEncryptor KeyEncryptor
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		internal IXmlRepository KeyRepository
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates an <see cref="T:Microsoft.AspNetCore.DataProtection.KeyManagement.XmlKeyManager" />.
		/// </summary>
		/// <param name="keyManagementOptions">The <see cref="T:Microsoft.Extensions.Options.IOptions`1" /> instance that provides the configuration.</param>
		/// <param name="activator">The <see cref="T:Microsoft.AspNetCore.DataProtection.Internal.IActivator" />.</param>
		public XmlKeyManager(IOptions<KeyManagementOptions> keyManagementOptions, IActivator activator)
		{
			throw null;
		}

		/// <summary>
		/// Creates an <see cref="T:Microsoft.AspNetCore.DataProtection.KeyManagement.XmlKeyManager" />.
		/// </summary>
		/// <param name="keyManagementOptions">The <see cref="T:Microsoft.Extensions.Options.IOptions`1" /> instance that provides the configuration.</param>
		/// <param name="activator">The <see cref="T:Microsoft.AspNetCore.DataProtection.Internal.IActivator" />.</param>
		/// <param name="loggerFactory">The <see cref="T:Microsoft.Extensions.Logging.ILoggerFactory" />.</param>
		public XmlKeyManager(IOptions<KeyManagementOptions> keyManagementOptions, IActivator activator, ILoggerFactory loggerFactory)
		{
			throw null;
		}

		internal XmlKeyManager(IOptions<KeyManagementOptions> keyManagementOptions, IActivator activator, ILoggerFactory loggerFactory, IDefaultKeyStorageDirectories keyStorageDirectories)
		{
			throw null;
		}

		internal XmlKeyManager(IOptions<KeyManagementOptions> keyManagementOptions, IActivator activator, ILoggerFactory loggerFactory, IInternalXmlKeyManager internalXmlKeyManager)
		{
			throw null;
		}

		public IKey CreateNewKey(DateTimeOffset activationDate, DateTimeOffset expirationDate)
		{
			throw null;
		}

		public IReadOnlyCollection<IKey> GetAllKeys()
		{
			throw null;
		}

		public CancellationToken GetCacheExpirationToken()
		{
			throw null;
		}

		public void RevokeAllKeys(DateTimeOffset revocationDate, string reason = null)
		{
			throw null;
		}

		public void RevokeKey(Guid keyId, string reason = null)
		{
			throw null;
		}

		IKey IInternalXmlKeyManager.CreateNewKey(Guid keyId, DateTimeOffset creationDate, DateTimeOffset activationDate, DateTimeOffset expirationDate)
		{
			throw null;
		}

		IAuthenticatedEncryptorDescriptor IInternalXmlKeyManager.DeserializeDescriptorFromKeyElement(XElement keyElement)
		{
			throw null;
		}

		void IInternalXmlKeyManager.RevokeSingleKey(Guid keyId, DateTimeOffset revocationDate, string reason)
		{
			throw null;
		}

		internal KeyValuePair<IXmlRepository, IXmlEncryptor> GetFallbackKeyRepositoryEncryptorPair()
		{
			throw null;
		}
	}
}
