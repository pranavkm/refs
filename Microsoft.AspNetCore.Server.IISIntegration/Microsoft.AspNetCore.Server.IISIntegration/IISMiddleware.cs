using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.IISIntegration
{
	public class IISMiddleware
	{
		public IISMiddleware(RequestDelegate next, ILoggerFactory loggerFactory, IOptions<IISOptions> options, string pairingToken, IAuthenticationSchemeProvider authentication, IHostApplicationLifetime applicationLifetime)
		{
			throw null;
		}

		public IISMiddleware(RequestDelegate next, ILoggerFactory loggerFactory, IOptions<IISOptions> options, string pairingToken, bool isWebsocketsSupported, IAuthenticationSchemeProvider authentication, IHostApplicationLifetime applicationLifetime)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CInvoke_003Ed__15))]
		[DebuggerStepThrough]
		public Task Invoke(HttpContext httpContext)
		{
			throw null;
		}
	}
}
