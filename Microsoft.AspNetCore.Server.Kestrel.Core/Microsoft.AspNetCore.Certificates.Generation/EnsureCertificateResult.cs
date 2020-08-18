namespace Microsoft.AspNetCore.Certificates.Generation
{
	internal enum EnsureCertificateResult
	{
		Succeeded = 1,
		ValidCertificatePresent,
		ErrorCreatingTheCertificate,
		ErrorSavingTheCertificateIntoTheCurrentUserPersonalStore,
		ErrorExportingTheCertificate,
		FailedToTrustTheCertificate,
		UserCancelledTrustStep,
		FailedToMakeKeyAccessible
	}
}
