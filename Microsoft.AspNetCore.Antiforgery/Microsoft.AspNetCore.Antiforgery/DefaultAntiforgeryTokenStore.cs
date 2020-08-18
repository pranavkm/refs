using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Antiforgery
{
	internal class DefaultAntiforgeryTokenStore : IAntiforgeryTokenStore
	{
		public DefaultAntiforgeryTokenStore(IOptions<AntiforgeryOptions> optionsAccessor)
		{
			throw null;
		}

		public string? GetCookieToken(HttpContext httpContext)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CGetRequestTokensAsync_003Ed__3))]
		[DebuggerStepThrough]
		public Task<AntiforgeryTokenSet> GetRequestTokensAsync(HttpContext httpContext)
		{
			throw null;
		}

		public void SaveCookieToken(HttpContext httpContext, string token)
		{
			throw null;
		}
	}
}
