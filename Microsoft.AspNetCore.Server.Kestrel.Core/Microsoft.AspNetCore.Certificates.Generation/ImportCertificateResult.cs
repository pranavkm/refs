namespace Microsoft.AspNetCore.Certificates.Generation
{
	internal enum ImportCertificateResult
	{
		Succeeded = 1,
		CertificateFileMissing,
		InvalidCertificate,
		NoDevelopmentHttpsCertificate,
		ExistingCertificatesPresent,
		ErrorSavingTheCertificateIntoTheCurrentUserPersonalStore
	}
}
