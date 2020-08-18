using System;
using System.Security.Cryptography;

namespace Microsoft.AspNetCore.DataProtection
{
	internal static class Error
	{
		public static InvalidOperationException CertificateXmlEncryptor_CertificateNotFound(string thumbprint)
		{
			throw null;
		}

		public static ArgumentException Common_ArgumentCannotBeNullOrEmpty(string parameterName)
		{
			throw null;
		}

		public static ArgumentException Common_BufferIncorrectlySized(string parameterName, int actualSize, int expectedSize)
		{
			throw null;
		}

		public static CryptographicException CryptCommon_GenericError(Exception inner = null)
		{
			throw null;
		}

		public static CryptographicException CryptCommon_PayloadInvalid()
		{
			throw null;
		}

		public static InvalidOperationException Common_PropertyCannotBeNullOrEmpty(string propertyName)
		{
			throw null;
		}

		public static InvalidOperationException Common_PropertyMustBeNonNegative(string propertyName)
		{
			throw null;
		}

		public static CryptographicException Common_EncryptionFailed(Exception inner = null)
		{
			throw null;
		}

		public static CryptographicException Common_KeyNotFound(Guid id)
		{
			throw null;
		}

		public static CryptographicException Common_KeyRevoked(Guid id)
		{
			throw null;
		}

		public static ArgumentOutOfRangeException Common_ValueMustBeNonNegative(string paramName)
		{
			throw null;
		}

		public static CryptographicException DecryptionFailed(Exception inner)
		{
			throw null;
		}

		public static CryptographicException ProtectionProvider_BadMagicHeader()
		{
			throw null;
		}

		public static CryptographicException ProtectionProvider_BadVersion()
		{
			throw null;
		}

		public static InvalidOperationException XmlKeyManager_DuplicateKey(Guid keyId)
		{
			throw null;
		}
	}
}
