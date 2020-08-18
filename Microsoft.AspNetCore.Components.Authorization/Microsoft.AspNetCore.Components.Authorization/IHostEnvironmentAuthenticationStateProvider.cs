using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Components.Authorization
{
	/// <summary>
	/// An interface implemented by <see cref="T:Microsoft.AspNetCore.Components.Authorization.AuthenticationStateProvider" /> classes that can receive authentication
	/// state information from the host environment.
	/// </summary>
	public interface IHostEnvironmentAuthenticationStateProvider
	{
		/// <summary>
		/// Supplies updated authentication state data to the <see cref="T:Microsoft.AspNetCore.Components.Authorization.AuthenticationStateProvider" />.
		/// </summary>
		/// <param name="authenticationStateTask">A task that resolves with the updated <see cref="T:Microsoft.AspNetCore.Components.Authorization.AuthenticationState" />.</param>
		void SetAuthenticationState(Task<AuthenticationState> authenticationStateTask);
	}
}
