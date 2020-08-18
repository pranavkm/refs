using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Microsoft.AspNetCore.Certificates.Generation
{
	internal abstract class CertificateManager
	{
		[EventSource(Name = "Dotnet-dev-certs")]
		public class CertificateManagerEventSource : EventSource
		{
			[Event(1, Level = EventLevel.Verbose)]
			public void ListCertificatesStart(StoreLocation location, StoreName storeName)
			{
				throw null;
			}

			[Event(2, Level = EventLevel.Verbose)]
			public void DescribeFoundCertificates(string matchingCertificates)
			{
				throw null;
			}

			[Event(3, Level = EventLevel.Verbose)]
			public void CheckCertificatesValidity()
			{
				throw null;
			}

			[Event(4, Level = EventLevel.Verbose)]
			public void DescribeValidCertificates(string validCertificates)
			{
				throw null;
			}

			[Event(5, Level = EventLevel.Verbose)]
			public void DescribeInvalidValidCertificates(string invalidCertificates)
			{
				throw null;
			}

			[Event(6, Level = EventLevel.Verbose)]
			public void ListCertificatesEnd()
			{
				throw null;
			}

			[Event(7, Level = EventLevel.Error)]
			public void ListCertificatesError(string e)
			{
				throw null;
			}

			[Event(8, Level = EventLevel.Verbose)]
			public void FilteredCertificates(string filteredCertificates)
			{
				throw null;
			}

			[Event(9, Level = EventLevel.Verbose)]
			public void ExcludedCertificates(string excludedCertificates)
			{
				throw null;
			}

			[Event(11, Level = EventLevel.Verbose)]
			public void MacOSMakeCertificateAccessibleAcrossPartitionsStart(string cert)
			{
				throw null;
			}

			[Event(12, Level = EventLevel.Verbose)]
			public void MacOSMakeCertificateAccessibleAcrossPartitionsEnd()
			{
				throw null;
			}

			[Event(13, Level = EventLevel.Error)]
			public void MacOSMakeCertificateAccessibleAcrossPartitionsError(string ex)
			{
				throw null;
			}

			[Event(14, Level = EventLevel.Verbose)]
			public void ValidCertificatesFound(string certificates)
			{
				throw null;
			}

			[Event(15, Level = EventLevel.Verbose)]
			public void SelectedCertificate(string certificate)
			{
				throw null;
			}

			[Event(16, Level = EventLevel.Verbose)]
			public void NoValidCertificatesFound()
			{
				throw null;
			}

			[Event(17, Level = EventLevel.Verbose)]
			public void CreateDevelopmentCertificateStart()
			{
				throw null;
			}

			[Event(18, Level = EventLevel.Verbose)]
			public void CreateDevelopmentCertificateEnd()
			{
				throw null;
			}

			[Event(19, Level = EventLevel.Error)]
			public void CreateDevelopmentCertificateError(string e)
			{
				throw null;
			}

			[Event(20, Level = EventLevel.Verbose)]
			public void SaveCertificateInStoreStart(string certificate, StoreName name, StoreLocation location)
			{
				throw null;
			}

			[Event(21, Level = EventLevel.Verbose)]
			public void SaveCertificateInStoreEnd()
			{
				throw null;
			}

			[Event(22, Level = EventLevel.Error)]
			public void SaveCertificateInStoreError(string e)
			{
				throw null;
			}

			[Event(23, Level = EventLevel.Verbose)]
			public void ExportCertificateStart(string certificate, string path, bool includePrivateKey)
			{
				throw null;
			}

			[Event(24, Level = EventLevel.Verbose)]
			public void NoPasswordForCertificate()
			{
				throw null;
			}

			[Event(25, Level = EventLevel.Verbose)]
			public void CreateExportCertificateDirectory(string path)
			{
				throw null;
			}

			[Event(26, Level = EventLevel.Error)]
			public void ExportCertificateError(string ex)
			{
				throw null;
			}

			[Event(27, Level = EventLevel.Verbose)]
			public void WriteCertificateToDisk(string path)
			{
				throw null;
			}

			[Event(28, Level = EventLevel.Error)]
			public void WriteCertificateToDiskError(string ex)
			{
				throw null;
			}

			[Event(29, Level = EventLevel.Verbose)]
			public void TrustCertificateStart(string certificate)
			{
				throw null;
			}

			[Event(30, Level = EventLevel.Verbose)]
			public void TrustCertificateEnd()
			{
				throw null;
			}

			[Event(31, Level = EventLevel.Error)]
			public void TrustCertificateError(string ex)
			{
				throw null;
			}

			[Event(32, Level = EventLevel.Verbose)]
			public void MacOSTrustCommandStart(string command)
			{
				throw null;
			}

			[Event(33, Level = EventLevel.Verbose)]
			public void MacOSTrustCommandEnd()
			{
				throw null;
			}

			[Event(34, Level = EventLevel.Verbose)]
			public void MacOSTrustCommandError(int exitCode)
			{
				throw null;
			}

			[Event(35, Level = EventLevel.Verbose)]
			public void MacOSRemoveCertificateTrustRuleStart(string certificate)
			{
				throw null;
			}

			[Event(36, Level = EventLevel.Verbose)]
			public void MacOSRemoveCertificateTrustRuleEnd()
			{
				throw null;
			}

			[Event(37, Level = EventLevel.Verbose)]
			public void MacOSRemoveCertificateTrustRuleError(int exitCode)
			{
				throw null;
			}

			[Event(38, Level = EventLevel.Verbose)]
			public void MacOSCertificateUntrusted(string certificate)
			{
				throw null;
			}

			[Event(39, Level = EventLevel.Verbose)]
			public void MacOSRemoveCertificateFromKeyChainStart(string keyChain, string certificate)
			{
				throw null;
			}

			[Event(40, Level = EventLevel.Verbose)]
			public void MacOSRemoveCertificateFromKeyChainEnd()
			{
				throw null;
			}

			[Event(41, Level = EventLevel.Verbose)]
			public void MacOSRemoveCertificateFromKeyChainError(int exitCode)
			{
				throw null;
			}

			[Event(42, Level = EventLevel.Verbose)]
			public void RemoveCertificateFromUserStoreStart(string certificate)
			{
				throw null;
			}

			[Event(43, Level = EventLevel.Verbose)]
			public void RemoveCertificateFromUserStoreEnd()
			{
				throw null;
			}

			[Event(44, Level = EventLevel.Error)]
			public void RemoveCertificateFromUserStoreError(string ex)
			{
				throw null;
			}

			[Event(45, Level = EventLevel.Verbose)]
			public void WindowsAddCertificateToRootStore()
			{
				throw null;
			}

			[Event(46, Level = EventLevel.Verbose)]
			public void WindowsCertificateAlreadyTrusted()
			{
				throw null;
			}

			[Event(47, Level = EventLevel.Verbose)]
			public void WindowsCertificateTrustCanceled()
			{
				throw null;
			}

			[Event(48, Level = EventLevel.Verbose)]
			public void WindowsRemoveCertificateFromRootStoreStart()
			{
				throw null;
			}

			[Event(49, Level = EventLevel.Verbose)]
			public void WindowsRemoveCertificateFromRootStoreEnd()
			{
				throw null;
			}

			[Event(50, Level = EventLevel.Verbose)]
			public void WindowsRemoveCertificateFromRootStoreNotFound()
			{
				throw null;
			}

			[Event(51, Level = EventLevel.Verbose)]
			public void CorrectCertificateStateStart(string certificate)
			{
				throw null;
			}

			[Event(52, Level = EventLevel.Verbose)]
			public void CorrectCertificateStateEnd()
			{
				throw null;
			}

			[Event(53, Level = EventLevel.Error)]
			public void CorrectCertificateStateError(string error)
			{
				throw null;
			}

			[Event(54, Level = EventLevel.Verbose)]
			internal void MacOSAddCertificateToKeyChainStart(string keychain, string certificate)
			{
				throw null;
			}

			[Event(55, Level = EventLevel.Verbose)]
			internal void MacOSAddCertificateToKeyChainEnd()
			{
				throw null;
			}

			[Event(56, Level = EventLevel.Error)]
			internal void MacOSAddCertificateToKeyChainError(int exitCode)
			{
				throw null;
			}

			[Event(57, Level = EventLevel.Verbose)]
			public void WritePemKeyToDisk(string path)
			{
				throw null;
			}

			[Event(58, Level = EventLevel.Error)]
			public void WritePemKeyToDiskError(string ex)
			{
				throw null;
			}

			[Event(59, Level = EventLevel.Error)]
			internal void ImportCertificateMissingFile(string certificatePath)
			{
				throw null;
			}

			[Event(60, Level = EventLevel.Error)]
			internal void ImportCertificateExistingCertificates(string certificateDescription)
			{
				throw null;
			}

			[Event(61, Level = EventLevel.Verbose)]
			internal void LoadCertificateStart(string certificatePath)
			{
				throw null;
			}

			[Event(62, Level = EventLevel.Verbose)]
			internal void LoadCertificateEnd(string description)
			{
				throw null;
			}

			[Event(63, Level = EventLevel.Error)]
			internal void LoadCertificateError(string ex)
			{
				throw null;
			}

			[Event(64, Level = EventLevel.Error)]
			internal void NoHttpsDevelopmentCertificate(string description)
			{
				throw null;
			}

			public CertificateManagerEventSource()
			{
				throw null;
			}
		}

		internal class UserCancelledTrustException : Exception
		{
			public UserCancelledTrustException()
			{
				throw null;
			}
		}

		internal struct CheckCertificateStateResult
		{
			public bool Result
			{
				[CompilerGenerated]
				readonly get
				{
					throw null;
				}
			}

			public string Message
			{
				[CompilerGenerated]
				readonly get
				{
					throw null;
				}
			}

			public CheckCertificateStateResult(bool result, string message)
			{
				throw null;
			}
		}

		internal enum RemoveLocations
		{
			Undefined,
			Local,
			Trusted,
			All
		}

		internal const string AspNetHttpsOid = "1.3.6.1.4.1.311.84.1.1";

		internal const string AspNetHttpsOidFriendlyName = "ASP.NET Core HTTPS development certificate";

		public const int RSAMinimumKeySizeInBits = 2048;

		public static CertificateManager Instance
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public static CertificateManagerEventSource Log
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

		public int AspNetHttpsCertificateVersion
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			internal set
			{
				throw null;
			}
		}

		public string Subject
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public CertificateManager()
		{
			throw null;
		}

		internal CertificateManager(string subject, int version)
		{
			throw null;
		}

		public bool IsHttpsDevelopmentCertificate(X509Certificate2 certificate)
		{
			throw null;
		}

		public IList<X509Certificate2> ListCertificates(StoreName storeName, StoreLocation location, bool isValid, bool requireExportable = true)
		{
			throw null;
		}

		public IList<X509Certificate2> GetHttpsCertificates()
		{
			throw null;
		}

		public EnsureCertificateResult EnsureAspNetCoreHttpsDevelopmentCertificate(DateTimeOffset notBefore, DateTimeOffset notAfter, string path = null, bool trust = false, bool includePrivateKey = false, string password = null, CertificateKeyExportFormat keyExportFormat = CertificateKeyExportFormat.Pfx, bool isInteractive = true)
		{
			throw null;
		}

		internal ImportCertificateResult ImportCertificate(string certificatePath, string password)
		{
			throw null;
		}

		public void CleanupHttpsCertificates()
		{
			throw null;
		}

		public abstract bool IsTrusted(X509Certificate2 certificate);

		protected abstract X509Certificate2 SaveCertificateCore(X509Certificate2 certificate);

		protected abstract void TrustCertificateCore(X509Certificate2 certificate);

		protected abstract bool IsExportable(X509Certificate2 c);

		protected abstract void RemoveCertificateFromTrustedRoots(X509Certificate2 certificate);

		protected abstract IList<X509Certificate2> GetCertificatesToRemove(StoreName storeName, StoreLocation storeLocation);

		internal void ExportCertificate(X509Certificate2 certificate, string path, bool includePrivateKey, string password, CertificateKeyExportFormat format)
		{
			throw null;
		}

		internal X509Certificate2 CreateAspNetCoreHttpsDevelopmentCertificate(DateTimeOffset notBefore, DateTimeOffset notAfter)
		{
			throw null;
		}

		internal X509Certificate2 SaveCertificate(X509Certificate2 certificate)
		{
			throw null;
		}

		internal void TrustCertificate(X509Certificate2 certificate)
		{
			throw null;
		}

		internal void RemoveAllCertificates(StoreName storeName, StoreLocation storeLocation)
		{
			throw null;
		}

		internal void RemoveCertificate(X509Certificate2 certificate, RemoveLocations locations)
		{
			throw null;
		}

		internal abstract CheckCertificateStateResult CheckCertificateState(X509Certificate2 candidate, bool interactive);

		internal abstract void CorrectCertificateState(X509Certificate2 candidate);

		internal X509Certificate2 CreateSelfSignedCertificate(X500DistinguishedName subject, IEnumerable<X509Extension> extensions, DateTimeOffset notBefore, DateTimeOffset notAfter)
		{
			throw null;
		}

		internal static void DisposeCertificates(IEnumerable<X509Certificate2> disposables)
		{
			throw null;
		}

		internal static string ToCertificateDescription(IEnumerable<X509Certificate2> matchingCertificates)
		{
			throw null;
		}

		internal static string GetDescription(X509Certificate2 c)
		{
			throw null;
		}
	}
}
