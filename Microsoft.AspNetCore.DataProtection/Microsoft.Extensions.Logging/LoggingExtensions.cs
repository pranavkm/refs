using Microsoft.Win32;
using System;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Microsoft.Extensions.Logging
{
	/// <summary>
	/// Helpful extension methods on <see cref="T:Microsoft.Extensions.Logging.ILogger" />.
	/// </summary>
	internal static class LoggingExtensions
	{
		/// <summary>
		/// Returns a value stating whether the 'debug' log level is enabled.
		/// Returns false if the logger instance is null.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsDebugLevelEnabled(this ILogger logger)
		{
			throw null;
		}

		/// <summary>
		/// Returns a value stating whether the 'error' log level is enabled.
		/// Returns false if the logger instance is null.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsErrorLevelEnabled(this ILogger logger)
		{
			throw null;
		}

		/// <summary>
		/// Returns a value stating whether the 'information' log level is enabled.
		/// Returns false if the logger instance is null.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsInformationLevelEnabled(this ILogger logger)
		{
			throw null;
		}

		/// <summary>
		/// Returns a value stating whether the 'trace' log level is enabled.
		/// Returns false if the logger instance is null.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsTraceLevelEnabled(this ILogger logger)
		{
			throw null;
		}

		/// <summary>
		/// Returns a value stating whether the 'warning' log level is enabled.
		/// Returns false if the logger instance is null.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsWarningLevelEnabled(this ILogger logger)
		{
			throw null;
		}

		public static void UsingFallbackKeyWithExpirationAsDefaultKey(this ILogger logger, Guid keyId, DateTimeOffset expirationDate)
		{
			throw null;
		}

		public static void UsingKeyAsDefaultKey(this ILogger logger, Guid keyId)
		{
			throw null;
		}

		public static void OpeningCNGAlgorithmFromProviderWithHMAC(this ILogger logger, string hashAlgorithm, string hashAlgorithmProvider)
		{
			throw null;
		}

		public static void OpeningCNGAlgorithmFromProviderWithChainingModeCBC(this ILogger logger, string encryptionAlgorithm, string encryptionAlgorithmProvider)
		{
			throw null;
		}

		public static void PerformingUnprotectOperationToKeyWithPurposes(this ILogger logger, Guid keyIdFromPayload, string p0)
		{
			throw null;
		}

		public static void KeyWasNotFoundInTheKeyRingUnprotectOperationCannotProceed(this ILogger logger, Guid keyIdFromPayload)
		{
			throw null;
		}

		public static void KeyWasRevokedCallerRequestedUnprotectOperationProceedRegardless(this ILogger logger, Guid keyIdFromPayload)
		{
			throw null;
		}

		public static void KeyWasRevokedUnprotectOperationCannotProceed(this ILogger logger, Guid keyIdFromPayload)
		{
			throw null;
		}

		public static void OpeningCNGAlgorithmFromProviderWithChainingModeGCM(this ILogger logger, string encryptionAlgorithm, string encryptionAlgorithmProvider)
		{
			throw null;
		}

		public static void UsingManagedKeyedHashAlgorithm(this ILogger logger, string fullName)
		{
			throw null;
		}

		public static void UsingManagedSymmetricAlgorithm(this ILogger logger, string fullName)
		{
			throw null;
		}

		public static void KeyIsIneligibleToBeTheDefaultKeyBecauseItsMethodFailed(this ILogger logger, Guid keyId, string p0, Exception exception)
		{
			throw null;
		}

		public static void ConsideringKeyWithExpirationDateAsDefaultKey(this ILogger logger, Guid keyId, DateTimeOffset expirationDate)
		{
			throw null;
		}

		public static void KeyIsNoLongerUnderConsiderationAsDefault(this ILogger logger, Guid keyId)
		{
			throw null;
		}

		public static void UnknownElementWithNameFoundInKeyringSkipping(this ILogger logger, XName name)
		{
			throw null;
		}

		public static void MarkedKeyAsRevokedInTheKeyring(this ILogger logger, Guid revokedKeyId)
		{
			throw null;
		}

		public static void TriedToProcessRevocationOfKeyButNoSuchKeyWasFound(this ILogger logger, Guid revokedKeyId)
		{
			throw null;
		}

		public static void FoundKey(this ILogger logger, Guid keyId)
		{
			throw null;
		}

		public static void FoundRevocationOfAllKeysCreatedPriorTo(this ILogger logger, DateTimeOffset massRevocationDate)
		{
			throw null;
		}

		public static void FoundRevocationOfKey(this ILogger logger, Guid keyId)
		{
			throw null;
		}

		public static void ExceptionWhileProcessingRevocationElement(this ILogger logger, XElement revocationElement, Exception exception)
		{
			throw null;
		}

		public static void RevokingAllKeysAsOfForReason(this ILogger logger, DateTimeOffset revocationDate, string reason)
		{
			throw null;
		}

		public static void KeyCacheExpirationTokenTriggeredByOperation(this ILogger logger, string opName)
		{
			throw null;
		}

		public static void ExceptionWhileProcessingKeyElement(this ILogger logger, XElement keyElement, Exception exception)
		{
			throw null;
		}

		public static void AnExceptionOccurredWhileProcessingElementDebug(this ILogger logger, XElement keyElement, Exception exception)
		{
			throw null;
		}

		public static void EncryptingToWindowsDPAPIForCurrentUserAccount(this ILogger logger, string name)
		{
			throw null;
		}

		public static void AnErrorOccurredWhileEncryptingToX509CertificateWithThumbprint(this ILogger logger, string thumbprint, Exception exception)
		{
			throw null;
		}

		public static void EncryptingToX509CertificateWithThumbprint(this ILogger logger, string thumbprint)
		{
			throw null;
		}

		public static void ExceptionWhileTryingToResolveCertificateWithThumbprint(this ILogger logger, string thumbprint, Exception exception)
		{
			throw null;
		}

		public static void PerformingProtectOperationToKeyWithPurposes(this ILogger logger, Guid defaultKeyId, string p0)
		{
			throw null;
		}

		public static void DescriptorDeserializerTypeForKeyIs(this ILogger logger, Guid keyId, string assemblyQualifiedName)
		{
			throw null;
		}

		public static void KeyEscrowSinkFoundWritingKeyToEscrow(this ILogger logger, Guid keyId)
		{
			throw null;
		}

		public static void NoKeyEscrowSinkFoundNotWritingKeyToEscrow(this ILogger logger, Guid keyId)
		{
			throw null;
		}

		public static void NoXMLEncryptorConfiguredKeyMayBePersistedToStorageInUnencryptedForm(this ILogger logger, Guid keyId)
		{
			throw null;
		}

		public static void RevokingKeyForReason(this ILogger logger, Guid keyId, DateTimeOffset revocationDate, string reason)
		{
			throw null;
		}

		public static void ReadingDataFromFile(this ILogger logger, string fullPath)
		{
			throw null;
		}

		public static void NameIsNotSafeFileName(this ILogger logger, string friendlyName, string newFriendlyName)
		{
			throw null;
		}

		public static void WritingDataToFile(this ILogger logger, string finalFilename)
		{
			throw null;
		}

		public static void ReadingDataFromRegistryKeyValue(this ILogger logger, RegistryKey regKey, string valueName)
		{
			throw null;
		}

		public static void NameIsNotSafeRegistryValueName(this ILogger logger, string friendlyName, string newFriendlyName)
		{
			throw null;
		}

		public static void DecryptingSecretElementUsingWindowsDPAPING(this ILogger logger, string protectionDescriptorRule)
		{
			throw null;
		}

		public static void EncryptingToWindowsDPAPINGUsingProtectionDescriptorRule(this ILogger logger, string protectionDescriptorRuleString)
		{
			throw null;
		}

		public static void ExceptionOccurredTryingToDecryptElement(this ILogger logger, Exception exception)
		{
			throw null;
		}

		public static void EncryptingUsingNullEncryptor(this ILogger logger)
		{
			throw null;
		}

		public static void UsingEphemeralDataProtectionProvider(this ILogger logger)
		{
			throw null;
		}

		public static void ExistingCachedKeyRingIsExpired(this ILogger logger)
		{
			throw null;
		}

		public static void ErrorOccurredWhileRefreshingKeyRing(this ILogger logger, Exception exception)
		{
			throw null;
		}

		public static void ErrorOccurredWhileReadingKeyRing(this ILogger logger, Exception exception)
		{
			throw null;
		}

		public static void KeyRingDoesNotContainValidDefaultKey(this ILogger logger)
		{
			throw null;
		}

		public static void UsingInmemoryRepository(this ILogger logger)
		{
			throw null;
		}

		public static void DecryptingSecretElementUsingWindowsDPAPI(this ILogger logger)
		{
			throw null;
		}

		public static void DefaultKeyExpirationImminentAndRepository(this ILogger logger)
		{
			throw null;
		}

		public static void RepositoryContainsNoViableDefaultKey(this ILogger logger)
		{
			throw null;
		}

		public static void ErrorOccurredWhileEncryptingToWindowsDPAPI(this ILogger logger, Exception exception)
		{
			throw null;
		}

		public static void EncryptingToWindowsDPAPIForLocalMachineAccount(this ILogger logger)
		{
			throw null;
		}

		public static void ErrorOccurredWhileEncryptingToWindowsDPAPING(this ILogger logger, Exception exception)
		{
			throw null;
		}

		public static void PolicyResolutionStatesThatANewKeyShouldBeAddedToTheKeyRing(this ILogger logger)
		{
			throw null;
		}

		public static void CreatingKey(this ILogger logger, Guid keyId, DateTimeOffset creationDate, DateTimeOffset activationDate, DateTimeOffset expirationDate)
		{
			throw null;
		}

		public static void UsingEphemeralKeyRepository(this ILogger logger)
		{
			throw null;
		}

		public static void UsingRegistryAsKeyRepositoryWithDPAPI(this ILogger logger, string name)
		{
			throw null;
		}

		public static void UsingProfileAsKeyRepository(this ILogger logger, string fullName)
		{
			throw null;
		}

		public static void UsingProfileAsKeyRepositoryWithDPAPI(this ILogger logger, string fullName)
		{
			throw null;
		}

		public static void UsingAzureAsKeyRepository(this ILogger logger, string fullName)
		{
			throw null;
		}

		public static void KeyRingWasLoadedOnStartup(this ILogger logger, Guid defaultKeyId)
		{
			throw null;
		}

		public static void KeyRingFailedToLoadOnStartup(this ILogger logger, Exception innerException)
		{
			throw null;
		}

		public static void UsingEphemeralFileSystemLocationInContainer(this ILogger logger, string path)
		{
			throw null;
		}
	}
}
