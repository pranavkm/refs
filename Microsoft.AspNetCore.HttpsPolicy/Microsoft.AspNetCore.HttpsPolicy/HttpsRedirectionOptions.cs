using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.HttpsPolicy
{
	/// <summary>
	/// Options for the HTTPS Redirection Middleware.
	/// </summary>
	public class HttpsRedirectionOptions
	{
		/// <summary>
		/// The status code used for the redirect response. The default is 307.
		/// </summary>
		public int RedirectStatusCode
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
		/// The HTTPS port to be added to the redirected URL.
		/// </summary>
		/// <remarks>
		/// If the HttpsPort is not set, we will try to get the HttpsPort from the following:
		/// 1. HTTPS_PORT environment variable
		/// 2. IServerAddressesFeature
		/// If that fails then the middleware will log a warning and turn off.
		/// </remarks>
		public int? HttpsPort
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

		public HttpsRedirectionOptions()
		{
			throw null;
		}
	}
}
