using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Http
{
	public abstract class ConnectionInfo
	{
		/// <summary>
		/// Gets or sets a unique identifier to represent this connection.
		/// </summary>
		public abstract string Id
		{
			[System.Runtime.CompilerServices.NullableContext(1)]
			get;
			[System.Runtime.CompilerServices.NullableContext(1)]
			set;
		}

		public abstract IPAddress? RemoteIpAddress
		{
			get;
			set;
		}

		public abstract int RemotePort
		{
			get;
			set;
		}

		public abstract IPAddress? LocalIpAddress
		{
			get;
			set;
		}

		public abstract int LocalPort
		{
			get;
			set;
		}

		public abstract X509Certificate2? ClientCertificate
		{
			get;
			set;
		}

		public abstract Task<X509Certificate2?> GetClientCertificateAsync(CancellationToken cancellationToken = default(CancellationToken));

		protected ConnectionInfo()
		{
			throw null;
		}
	}
}
