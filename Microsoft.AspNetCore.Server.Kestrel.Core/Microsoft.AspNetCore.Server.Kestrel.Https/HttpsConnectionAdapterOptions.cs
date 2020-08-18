using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using System;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;

namespace Microsoft.AspNetCore.Server.Kestrel.Https
{
	/// <summary>
	/// Settings for how Kestrel should handle HTTPS connections.
	/// </summary>
	public class HttpsConnectionAdapterOptions
	{
		internal static TimeSpan DefaultHandshakeTimeout;

		/// <summary>
		/// <para>
		/// Specifies the server certificate used to authenticate HTTPS connections. This is ignored if ServerCertificateSelector is set.
		/// </para>
		/// <para>
		/// If the server certificate has an Extended Key Usage extension, the usages must include Server Authentication (OID 1.3.6.1.5.5.7.3.1).
		/// </para>
		/// </summary>
		public X509Certificate2 ServerCertificate
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

		/// <summary>
		/// <para>
		/// A callback that will be invoked to dynamically select a server certificate. This is higher priority than ServerCertificate.
		/// If SNI is not available then the name parameter will be null.
		/// </para>
		/// <para>
		/// If the server certificate has an Extended Key Usage extension, the usages must include Server Authentication (OID 1.3.6.1.5.5.7.3.1).
		/// </para>
		/// </summary>
		public Func<ConnectionContext, string, X509Certificate2> ServerCertificateSelector
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

		/// <summary>
		/// Specifies the client certificate requirements for a HTTPS connection. Defaults to <see cref="F:Microsoft.AspNetCore.Server.Kestrel.Https.ClientCertificateMode.NoCertificate" />.
		/// </summary>
		public ClientCertificateMode ClientCertificateMode
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

		/// <summary>
		/// Specifies a callback for additional client certificate validation that will be invoked during authentication. This will be ignored
		/// if <see cref="M:Microsoft.AspNetCore.Server.Kestrel.Https.HttpsConnectionAdapterOptions.AllowAnyClientCertificate" /> is called after this callback is set.
		/// </summary>
		public Func<X509Certificate2, X509Chain, SslPolicyErrors, bool> ClientCertificateValidation
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

		/// <summary>
		/// Specifies allowable SSL protocols. Defaults to <see cref="F:System.Security.Authentication.SslProtocols.None" /> which allows the operating system to choose the best protocol to use,
		/// and to block protocols that are not secure. Unless your app has a specific reason not to, you should use this default.
		/// </summary>
		public SslProtocols SslProtocols
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

		/// <summary>
		/// The protocols enabled on this endpoint.
		/// </summary>
		/// <remarks>Defaults to HTTP/1.x only.</remarks>
		internal HttpProtocols HttpProtocols
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

		/// <summary>
		/// Specifies whether the certificate revocation list is checked during authentication.
		/// </summary>
		public bool CheckCertificateRevocation
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

		/// <summary>
		/// Provides direct configuration of the <see cref="T:System.Net.Security.SslServerAuthenticationOptions" /> on a per-connection basis.
		/// This is called after all of the other settings have already been applied.
		/// </summary>
		public Action<ConnectionContext, SslServerAuthenticationOptions> OnAuthenticate
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

		/// <summary>
		/// Specifies the maximum amount of time allowed for the TLS/SSL handshake. This must be positive and finite. Defaults to 10 seconds.
		/// </summary>
		public TimeSpan HandshakeTimeout
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

		/// <summary>
		/// Initializes a new instance of <see cref="T:Microsoft.AspNetCore.Server.Kestrel.Https.HttpsConnectionAdapterOptions" />.
		/// </summary>
		public HttpsConnectionAdapterOptions()
		{
			throw null;
		}

		/// <summary>
		/// Overrides the current <see cref="P:Microsoft.AspNetCore.Server.Kestrel.Https.HttpsConnectionAdapterOptions.ClientCertificateValidation" /> callback and allows any client certificate.
		/// </summary>
		public void AllowAnyClientCertificate()
		{
			throw null;
		}
	}
}
