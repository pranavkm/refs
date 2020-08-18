using Microsoft.AspNetCore.Http.Features;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.HttpOverrides
{
	internal class CertificateForwardingFeature : ITlsConnectionFeature
	{
		public X509Certificate2 ClientCertificate
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		public CertificateForwardingFeature(ILogger logger, StringValues header, CertificateForwardingOptions options)
		{
			throw null;
		}

		public Task<X509Certificate2> GetClientCertificateAsync(CancellationToken cancellationToken)
		{
			throw null;
		}
	}
}
