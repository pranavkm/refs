using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.CookiePolicy
{
	public class CookiePolicyMiddleware
	{
		private class CookiesWrapperFeature : IResponseCookiesFeature
		{
			public IResponseCookies Cookies
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			public CookiesWrapperFeature(ResponseCookiesWrapper wrapper)
			{
				throw null;
			}
		}

		public CookiePolicyOptions Options
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

		public CookiePolicyMiddleware(RequestDelegate next, IOptions<CookiePolicyOptions> options, ILoggerFactory factory)
		{
			throw null;
		}

		public CookiePolicyMiddleware(RequestDelegate next, IOptions<CookiePolicyOptions> options)
		{
			throw null;
		}

		public Task Invoke(HttpContext context)
		{
			throw null;
		}
	}
}
