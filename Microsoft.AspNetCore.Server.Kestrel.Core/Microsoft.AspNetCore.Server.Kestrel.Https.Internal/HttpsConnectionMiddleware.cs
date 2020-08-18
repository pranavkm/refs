using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Https.Internal
{
	internal class HttpsConnectionMiddleware
	{
		public HttpsConnectionMiddleware(ConnectionDelegate next, HttpsConnectionAdapterOptions options)
		{
			throw null;
		}

		public HttpsConnectionMiddleware(ConnectionDelegate next, HttpsConnectionAdapterOptions options, ILoggerFactory loggerFactory)
		{
			throw null;
		}

		internal HttpsConnectionMiddleware(ConnectionDelegate next, HttpsOptionsCallback httpsOptionsCallback, object httpsOptionsCallbackState, TimeSpan handshakeTimeout, ILoggerFactory loggerFactory)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003COnConnectionAsync_003Ed__15))]
		[DebuggerStepThrough]
		public Task OnConnectionAsync(ConnectionContext context)
		{
			throw null;
		}

		internal static void ConfigureAlpn(SslServerAuthenticationOptions serverOptions, HttpProtocols httpProtocols)
		{
			throw null;
		}

		internal static bool RemoteCertificateValidationCallback(ClientCertificateMode clientCertificateMode, Func<X509Certificate2, X509Chain, SslPolicyErrors, bool> clientCertificateValidation, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			throw null;
		}

		internal static void EnsureCertificateIsAllowedForServerAuth(X509Certificate2 certificate)
		{
			throw null;
		}

		internal static HttpProtocols ValidateAndNormalizeHttpProtocols(HttpProtocols httpProtocols, ILogger<HttpsConnectionMiddleware> logger)
		{
			throw null;
		}
	}
}
