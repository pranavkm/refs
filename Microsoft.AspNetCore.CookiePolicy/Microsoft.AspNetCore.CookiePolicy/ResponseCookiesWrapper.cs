using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.Extensions.Logging;

namespace Microsoft.AspNetCore.CookiePolicy
{
	internal class ResponseCookiesWrapper : IResponseCookies, ITrackingConsentFeature
	{
		public bool IsConsentNeeded
		{
			get
			{
				throw null;
			}
		}

		public bool HasConsent
		{
			get
			{
				throw null;
			}
		}

		public bool CanTrack
		{
			get
			{
				throw null;
			}
		}

		public ResponseCookiesWrapper(HttpContext context, CookiePolicyOptions options, IResponseCookiesFeature feature, ILogger logger)
		{
			throw null;
		}

		public void GrantConsent()
		{
			throw null;
		}

		public void WithdrawConsent()
		{
			throw null;
		}

		public string CreateConsentCookie()
		{
			throw null;
		}

		public void Append(string key, string value)
		{
			throw null;
		}

		public void Append(string key, string value, CookieOptions options)
		{
			throw null;
		}

		public void Delete(string key)
		{
			throw null;
		}

		public void Delete(string key, CookieOptions options)
		{
			throw null;
		}
	}
}
