using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel;
using System;
using System.Xml.Linq;

namespace Microsoft.AspNetCore.DataProtection.KeyManagement.Internal
{
	/// <summary>
	/// This API supports infrastructure and is not intended to be used
	/// directly from your code. This API may change or be removed in future releases.
	/// </summary>
	public interface IInternalXmlKeyManager
	{
		IKey CreateNewKey(Guid keyId, DateTimeOffset creationDate, DateTimeOffset activationDate, DateTimeOffset expirationDate);

		IAuthenticatedEncryptorDescriptor DeserializeDescriptorFromKeyElement(XElement keyElement);

		void RevokeSingleKey(Guid keyId, DateTimeOffset revocationDate, string reason);
	}
}
