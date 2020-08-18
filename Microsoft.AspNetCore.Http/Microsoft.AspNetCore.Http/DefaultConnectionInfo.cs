using Microsoft.AspNetCore.Http.Features;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Http
{
	internal sealed class DefaultConnectionInfo : ConnectionInfo
	{
		private struct FeatureInterfaces
		{
			public IHttpConnectionFeature? Connection;

			public ITlsConnectionFeature? TlsConnection;
		}

		/// <inheritdoc />
		public override string Id
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

		public override IPAddress? RemoteIpAddress
		{
			[System.Runtime.CompilerServices.NullableContext(2)]
			get
			{
				throw null;
			}
			[System.Runtime.CompilerServices.NullableContext(2)]
			set
			{
				throw null;
			}
		}

		public override int RemotePort
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

		public override IPAddress? LocalIpAddress
		{
			[System.Runtime.CompilerServices.NullableContext(2)]
			get
			{
				throw null;
			}
			[System.Runtime.CompilerServices.NullableContext(2)]
			set
			{
				throw null;
			}
		}

		public override int LocalPort
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

		public override X509Certificate2? ClientCertificate
		{
			[System.Runtime.CompilerServices.NullableContext(2)]
			get
			{
				throw null;
			}
			[System.Runtime.CompilerServices.NullableContext(2)]
			set
			{
				throw null;
			}
		}

		public DefaultConnectionInfo(IFeatureCollection features)
		{
			throw null;
		}

		public void Initialize(IFeatureCollection features)
		{
			throw null;
		}

		public void Initialize(IFeatureCollection features, int revision)
		{
			throw null;
		}

		public void Uninitialize()
		{
			throw null;
		}

		public override Task<X509Certificate2?> GetClientCertificateAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}
	}
}
