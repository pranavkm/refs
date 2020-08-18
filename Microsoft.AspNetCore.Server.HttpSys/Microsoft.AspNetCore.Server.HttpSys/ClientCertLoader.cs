using Microsoft.Extensions.Logging;
using System;
using System.Runtime.InteropServices;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.HttpSys
{
	internal sealed class ClientCertLoader : IAsyncResult, IDisposable
	{
		internal SafeHandle RequestQueueHandle
		{
			get
			{
				throw null;
			}
		}

		internal X509Certificate2 ClientCert
		{
			get
			{
				throw null;
			}
		}

		internal int ClientCertError
		{
			get
			{
				throw null;
			}
		}

		internal Exception ClientCertException
		{
			get
			{
				throw null;
			}
		}

		public object AsyncState
		{
			get
			{
				throw null;
			}
		}

		public WaitHandle AsyncWaitHandle
		{
			get
			{
				throw null;
			}
		}

		public bool CompletedSynchronously
		{
			get
			{
				throw null;
			}
		}

		public bool IsCompleted
		{
			get
			{
				throw null;
			}
		}

		internal ClientCertLoader(RequestContext requestContext, CancellationToken cancellationToken)
		{
			throw null;
		}

		internal Task LoadClientCertificateAsync()
		{
			throw null;
		}

		public void Dispose()
		{
			throw null;
		}

		internal static ChannelBinding GetChannelBindingFromTls(RequestQueue requestQueue, ulong connectionId, ILogger logger)
		{
			throw null;
		}
	}
}
