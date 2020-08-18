using Microsoft.AspNetCore.Components.Authorization;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Components.Server
{
	/// <summary>
	/// An <see cref="T:Microsoft.AspNetCore.Components.Authorization.AuthenticationStateProvider" /> intended for use in server-side Blazor.
	/// </summary>
	public class ServerAuthenticationStateProvider : AuthenticationStateProvider, IHostEnvironmentAuthenticationStateProvider
	{
		/// <inheritdoc />
		public override Task<AuthenticationState> GetAuthenticationStateAsync()
		{
			throw null;
		}

		/// <inheritdoc />
		public void SetAuthenticationState(Task<AuthenticationState> authenticationStateTask)
		{
			throw null;
		}

		public ServerAuthenticationStateProvider()
		{
			throw null;
		}
	}
}
