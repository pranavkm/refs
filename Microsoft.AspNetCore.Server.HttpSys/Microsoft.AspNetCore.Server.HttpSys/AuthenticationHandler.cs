using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.HttpSys
{
	internal class AuthenticationHandler : IAuthenticationHandler
	{
		public Task<AuthenticateResult> AuthenticateAsync()
		{
			throw null;
		}

		public Task ChallengeAsync(AuthenticationProperties properties)
		{
			throw null;
		}

		public Task ForbidAsync(AuthenticationProperties properties)
		{
			throw null;
		}

		public Task InitializeAsync(AuthenticationScheme scheme, HttpContext context)
		{
			throw null;
		}

		public AuthenticationHandler()
		{
			throw null;
		}
	}
}
