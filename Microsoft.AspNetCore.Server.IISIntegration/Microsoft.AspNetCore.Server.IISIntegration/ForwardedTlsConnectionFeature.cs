using Microsoft.AspNetCore.Http.Features;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.IISIntegration
{
	internal class ForwardedTlsConnectionFeature : ITlsConnectionFeature
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

		public ForwardedTlsConnectionFeature(ILogger logger, StringValues header)
		{
			throw null;
		}

		public Task<X509Certificate2> GetClientCertificateAsync(CancellationToken cancellationToken)
		{
			throw null;
		}
	}
}
