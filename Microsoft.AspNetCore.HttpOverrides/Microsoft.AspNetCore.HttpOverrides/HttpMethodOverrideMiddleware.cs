using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.HttpOverrides
{
	public class HttpMethodOverrideMiddleware
	{
		public HttpMethodOverrideMiddleware(RequestDelegate next, IOptions<HttpMethodOverrideOptions> options)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CInvoke_003Ed__4))]
		[DebuggerStepThrough]
		public Task Invoke(HttpContext context)
		{
			throw null;
		}
	}
}
