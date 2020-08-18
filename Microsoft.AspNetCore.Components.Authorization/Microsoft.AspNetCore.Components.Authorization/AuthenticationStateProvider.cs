using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Components.Authorization
{
	/// <summary>
	/// Provides information about the authentication state of the current user.
	/// </summary>
	public abstract class AuthenticationStateProvider
	{
		/// <summary>
		/// An event that provides notification when the <see cref="T:Microsoft.AspNetCore.Components.Authorization.AuthenticationState" />
		/// has changed. For example, this event may be raised if a user logs in or out.
		/// </summary>
		public event AuthenticationStateChangedHandler AuthenticationStateChanged
		{
			[CompilerGenerated]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			remove
			{
				throw null;
			}
		}

		/// <summary>
		/// Asynchronously gets an <see cref="T:Microsoft.AspNetCore.Components.Authorization.AuthenticationState" /> that describes the current user.
		/// </summary>
		/// <returns>A task that, when resolved, gives an <see cref="T:Microsoft.AspNetCore.Components.Authorization.AuthenticationState" /> instance that describes the current user.</returns>
		public abstract Task<AuthenticationState> GetAuthenticationStateAsync();

		/// <summary>
		/// Raises the <see cref="E:Microsoft.AspNetCore.Components.Authorization.AuthenticationStateProvider.AuthenticationStateChanged" /> event.
		/// </summary>
		/// <param name="task">A <see cref="T:System.Threading.Tasks.Task" /> that supplies the updated <see cref="T:Microsoft.AspNetCore.Components.Authorization.AuthenticationState" />.</param>
		protected void NotifyAuthenticationStateChanged(Task<AuthenticationState> task)
		{
			throw null;
		}

		protected AuthenticationStateProvider()
		{
			throw null;
		}
	}
}
