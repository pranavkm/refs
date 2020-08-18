using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption;
using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.DataProtection.KeyManagement
{
	/// <summary>
	/// The basic implementation of <see cref="T:Microsoft.AspNetCore.DataProtection.KeyManagement.IKey" />, where the <see cref="T:Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IAuthenticatedEncryptorDescriptor" />
	/// has already been created.
	/// </summary>
	internal sealed class Key : KeyBase
	{
		[System.Runtime.CompilerServices.NullableContext(1)]
		public Key(Guid keyId, DateTimeOffset creationDate, DateTimeOffset activationDate, DateTimeOffset expirationDate, IAuthenticatedEncryptorDescriptor descriptor, IEnumerable<IAuthenticatedEncryptorFactory> encryptorFactories)
		{
			throw null;
		}
	}
}
