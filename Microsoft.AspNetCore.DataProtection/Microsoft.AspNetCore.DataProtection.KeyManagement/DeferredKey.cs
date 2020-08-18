using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption;
using Microsoft.AspNetCore.DataProtection.KeyManagement.Internal;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Microsoft.AspNetCore.DataProtection.KeyManagement
{
	/// <summary>
	/// The basic implementation of <see cref="T:Microsoft.AspNetCore.DataProtection.KeyManagement.IKey" />, where the incoming XML element
	/// hasn't yet been fully processed.
	/// </summary>
	internal sealed class DeferredKey : KeyBase
	{
		public DeferredKey(Guid keyId, DateTimeOffset creationDate, DateTimeOffset activationDate, DateTimeOffset expirationDate, IInternalXmlKeyManager keyManager, XElement keyElement, IEnumerable<IAuthenticatedEncryptorFactory> encryptorFactories)
		{
			throw null;
		}
	}
}
