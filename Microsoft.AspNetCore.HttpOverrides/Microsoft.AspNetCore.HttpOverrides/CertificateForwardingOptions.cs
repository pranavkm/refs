using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Microsoft.AspNetCore.HttpOverrides
{
	/// <summary>
	/// Used to configure the <see cref="T:Microsoft.AspNetCore.HttpOverrides.CertificateForwardingMiddleware" />.
	/// </summary>
	public class CertificateForwardingOptions
	{
		/// <summary>
		/// The function used to convert the header to an instance of <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" />.
		/// </summary>
		/// <remarks>
		/// This defaults to a conversion from a base64 encoded string.
		/// </remarks>
		public Func<string, X509Certificate2> HeaderConverter;

		/// <summary>
		/// The name of the header containing the client certificate.
		/// </summary>
		/// <remarks>
		/// This defaults to X-Client-Cert
		/// </remarks>
		public string CertificateHeader
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

		public CertificateForwardingOptions()
		{
			throw null;
		}
	}
}
