using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Extensions.Http.Logging
{
	public class LoggingHttpMessageHandler : DelegatingHandler
	{
		public LoggingHttpMessageHandler(ILogger logger)
		{
		}

		public LoggingHttpMessageHandler(ILogger logger, HttpClientFactoryOptions options)
		{
		}

		[DebuggerStepThrough]
		protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			throw null;
		}
	}
}
