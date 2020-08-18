using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Net;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.HttpOverrides
{
	public class ForwardedHeadersMiddleware
	{
		private struct SetOfForwarders
		{
			public string IpAndPortText;

			public IPEndPoint RemoteIpAndPort;

			public string Host;

			public string Scheme;
		}

		public ForwardedHeadersMiddleware(RequestDelegate next, ILoggerFactory loggerFactory, IOptions<ForwardedHeadersOptions> options)
		{
			throw null;
		}

		public Task Invoke(HttpContext context)
		{
			throw null;
		}

		public void ApplyForwarders(HttpContext context)
		{
			throw null;
		}
	}
}
