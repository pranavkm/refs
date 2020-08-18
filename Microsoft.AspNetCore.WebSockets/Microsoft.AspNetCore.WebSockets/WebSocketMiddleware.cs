using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Diagnostics;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.WebSockets
{
	public class WebSocketMiddleware
	{
		private class UpgradeHandshake : IHttpWebSocketFeature
		{
			public bool IsWebSocketRequest
			{
				get
				{
					throw null;
				}
			}

			public UpgradeHandshake(HttpContext context, IHttpUpgradeFeature upgradeFeature, WebSocketOptions options)
			{
				throw null;
			}

			[AsyncStateMachine(typeof(_003CAcceptAsync_003Ed__7))]
			[DebuggerStepThrough]
			public Task<WebSocket> AcceptAsync(WebSocketAcceptContext acceptContext)
			{
				throw null;
			}
		}

		public WebSocketMiddleware(RequestDelegate next, IOptions<WebSocketOptions> options, ILoggerFactory loggerFactory)
		{
			throw null;
		}

		public Task Invoke(HttpContext context)
		{
			throw null;
		}
	}
}
