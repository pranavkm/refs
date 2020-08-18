using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Authentication
{
	public class AuthenticationMiddleware
	{
		public IAuthenticationSchemeProvider Schemes
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

		public AuthenticationMiddleware(RequestDelegate next, IAuthenticationSchemeProvider schemes)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CInvoke_003Ed__6))]
		[DebuggerStepThrough]
		public Task Invoke(HttpContext context)
		{
			throw null;
		}
	}
}
