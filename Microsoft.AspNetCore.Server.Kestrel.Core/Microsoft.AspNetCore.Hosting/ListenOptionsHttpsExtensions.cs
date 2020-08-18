using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.AspNetCore.Server.Kestrel.Https;
using Microsoft.AspNetCore.Server.Kestrel.Https.Internal;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Microsoft.AspNetCore.Hosting
{
	/// <summary>
	/// Extension methods for <see cref="T:Microsoft.AspNetCore.Server.Kestrel.Core.ListenOptions" /> that configure Kestrel to use HTTPS for a given endpoint.
	/// </summary>
	public static class ListenOptionsHttpsExtensions
	{
		/// <summary>
		/// Configure Kestrel to use HTTPS with the default certificate if available.
		/// This will throw if no default certificate is configured.
		/// </summary>
		/// <param name="listenOptions">The <see cref="T:Microsoft.AspNetCore.Server.Kestrel.Core.ListenOptions" /> to configure.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Server.Kestrel.Core.ListenOptions" />.</returns>
		public static ListenOptions UseHttps(this ListenOptions listenOptions)
		{
			throw null;
		}

		/// <summary>
		/// Configure Kestrel to use HTTPS.
		/// </summary>
		/// <param name="listenOptions">The <see cref="T:Microsoft.AspNetCore.Server.Kestrel.Core.ListenOptions" /> to configure.</param>
		/// <param name="fileName">The name of a certificate file, relative to the directory that contains the application
		/// content files.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Server.Kestrel.Core.ListenOptions" />.</returns>
		public static ListenOptions UseHttps(this ListenOptions listenOptions, string fileName)
		{
			throw null;
		}

		/// <summary>
		/// Configure Kestrel to use HTTPS.
		/// </summary>
		/// <param name="listenOptions">The <see cref="T:Microsoft.AspNetCore.Server.Kestrel.Core.ListenOptions" /> to configure.</param>
		/// <param name="fileName">The name of a certificate file, relative to the directory that contains the application
		/// content files.</param>
		/// <param name="password">The password required to access the X.509 certificate data.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Server.Kestrel.Core.ListenOptions" />.</returns>
		public static ListenOptions UseHttps(this ListenOptions listenOptions, string fileName, string password)
		{
			throw null;
		}

		/// <summary>
		/// Configure Kestrel to use HTTPS.
		/// </summary>
		/// <param name="listenOptions">The <see cref="T:Microsoft.AspNetCore.Server.Kestrel.Core.ListenOptions" /> to configure.</param>
		/// <param name="fileName">The name of a certificate file, relative to the directory that contains the application content files.</param>
		/// <param name="password">The password required to access the X.509 certificate data.</param>
		/// <param name="configureOptions">An Action to configure the <see cref="T:Microsoft.AspNetCore.Server.Kestrel.Https.HttpsConnectionAdapterOptions" />.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Server.Kestrel.Core.ListenOptions" />.</returns>
		public static ListenOptions UseHttps(this ListenOptions listenOptions, string fileName, string password, Action<HttpsConnectionAdapterOptions> configureOptions)
		{
			throw null;
		}

		/// <summary>
		/// Configure Kestrel to use HTTPS.
		/// </summary>
		/// <param name="listenOptions">The <see cref="T:Microsoft.AspNetCore.Server.Kestrel.Core.ListenOptions" /> to configure.</param>
		/// <param name="storeName">The certificate store to load the certificate from.</param>
		/// <param name="subject">The subject name for the certificate to load.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Server.Kestrel.Core.ListenOptions" />.</returns>
		public static ListenOptions UseHttps(this ListenOptions listenOptions, StoreName storeName, string subject)
		{
			throw null;
		}

		/// <summary>
		/// Configure Kestrel to use HTTPS.
		/// </summary>
		/// <param name="listenOptions">The <see cref="T:Microsoft.AspNetCore.Server.Kestrel.Core.ListenOptions" /> to configure.</param>
		/// <param name="storeName">The certificate store to load the certificate from.</param>
		/// <param name="subject">The subject name for the certificate to load.</param>
		/// <param name="allowInvalid">Indicates if invalid certificates should be considered, such as self-signed certificates.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Server.Kestrel.Core.ListenOptions" />.</returns>
		public static ListenOptions UseHttps(this ListenOptions listenOptions, StoreName storeName, string subject, bool allowInvalid)
		{
			throw null;
		}

		/// <summary>
		/// Configure Kestrel to use HTTPS.
		/// </summary>
		/// <param name="listenOptions">The <see cref="T:Microsoft.AspNetCore.Server.Kestrel.Core.ListenOptions" /> to configure.</param>
		/// <param name="storeName">The certificate store to load the certificate from.</param>
		/// <param name="subject">The subject name for the certificate to load.</param>
		/// <param name="allowInvalid">Indicates if invalid certificates should be considered, such as self-signed certificates.</param>
		/// <param name="location">The store location to load the certificate from.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Server.Kestrel.Core.ListenOptions" />.</returns>
		public static ListenOptions UseHttps(this ListenOptions listenOptions, StoreName storeName, string subject, bool allowInvalid, StoreLocation location)
		{
			throw null;
		}

		/// <summary>
		/// Configure Kestrel to use HTTPS.
		/// </summary>
		/// <param name="listenOptions">The <see cref="T:Microsoft.AspNetCore.Server.Kestrel.Core.ListenOptions" /> to configure.</param>
		/// <param name="storeName">The certificate store to load the certificate from.</param>
		/// <param name="subject">The subject name for the certificate to load.</param>
		/// <param name="allowInvalid">Indicates if invalid certificates should be considered, such as self-signed certificates.</param>
		/// <param name="location">The store location to load the certificate from.</param>
		/// <param name="configureOptions">An Action to configure the <see cref="T:Microsoft.AspNetCore.Server.Kestrel.Https.HttpsConnectionAdapterOptions" />.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Server.Kestrel.Core.ListenOptions" />.</returns>
		public static ListenOptions UseHttps(this ListenOptions listenOptions, StoreName storeName, string subject, bool allowInvalid, StoreLocation location, Action<HttpsConnectionAdapterOptions> configureOptions)
		{
			throw null;
		}

		/// <summary>
		/// Configure Kestrel to use HTTPS.
		/// </summary>
		/// <param name="listenOptions"> The <see cref="T:Microsoft.AspNetCore.Server.Kestrel.Core.ListenOptions" /> to configure.</param>
		/// <param name="serverCertificate">The X.509 certificate.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Server.Kestrel.Core.ListenOptions" />.</returns>
		public static ListenOptions UseHttps(this ListenOptions listenOptions, X509Certificate2 serverCertificate)
		{
			throw null;
		}

		/// <summary>
		/// Configure Kestrel to use HTTPS.
		/// </summary>
		/// <param name="listenOptions">The <see cref="T:Microsoft.AspNetCore.Server.Kestrel.Core.ListenOptions" /> to configure.</param>
		/// <param name="serverCertificate">The X.509 certificate.</param>
		/// <param name="configureOptions">An Action to configure the <see cref="T:Microsoft.AspNetCore.Server.Kestrel.Https.HttpsConnectionAdapterOptions" />.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Server.Kestrel.Core.ListenOptions" />.</returns>
		public static ListenOptions UseHttps(this ListenOptions listenOptions, X509Certificate2 serverCertificate, Action<HttpsConnectionAdapterOptions> configureOptions)
		{
			throw null;
		}

		/// <summary>
		/// Configure Kestrel to use HTTPS.
		/// </summary>
		/// <param name="listenOptions">The <see cref="T:Microsoft.AspNetCore.Server.Kestrel.Core.ListenOptions" /> to configure.</param>
		/// <param name="configureOptions">An action to configure options for HTTPS.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Server.Kestrel.Core.ListenOptions" />.</returns>
		public static ListenOptions UseHttps(this ListenOptions listenOptions, Action<HttpsConnectionAdapterOptions> configureOptions)
		{
			throw null;
		}

		internal static bool TryUseHttps(this ListenOptions listenOptions)
		{
			throw null;
		}

		/// <summary>
		/// Configure Kestrel to use HTTPS.
		/// </summary>
		/// <param name="listenOptions">The <see cref="T:Microsoft.AspNetCore.Server.Kestrel.Core.ListenOptions" /> to configure.</param>
		/// <param name="httpsOptions">Options to configure HTTPS.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Server.Kestrel.Core.ListenOptions" />.</returns>
		public static ListenOptions UseHttps(this ListenOptions listenOptions, HttpsConnectionAdapterOptions httpsOptions)
		{
			throw null;
		}

		/// <summary>
		/// Configure Kestrel to use HTTPS.
		/// </summary>
		/// <param name="listenOptions">The <see cref="T:Microsoft.AspNetCore.Server.Kestrel.Core.ListenOptions" /> to configure.</param>
		/// <param name="httpsOptionsCallback">Callback to configure HTTPS options.</param>
		/// <param name="state">State for the <see cref="T:System.Net.Security.ServerOptionsSelectionCallback" />.</param>
		/// <param name="handshakeTimeout">Specifies the maximum amount of time allowed for the TLS/SSL handshake. This must be positive and finite.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Server.Kestrel.Core.ListenOptions" />.</returns>
		internal static ListenOptions UseHttps(this ListenOptions listenOptions, HttpsOptionsCallback httpsOptionsCallback, object state, TimeSpan handshakeTimeout)
		{
			throw null;
		}
	}
}
