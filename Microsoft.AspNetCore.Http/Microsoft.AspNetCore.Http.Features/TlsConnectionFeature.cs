using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Http.Features
{
	public class TlsConnectionFeature : ITlsConnectionFeature
	{
		public X509Certificate2? ClientCertificate
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

		public Task<X509Certificate2?> GetClientCertificateAsync(CancellationToken cancellationToken)
		{
			throw null;
		}

		public TlsConnectionFeature()
		{
			throw null;
		}
	}
}
