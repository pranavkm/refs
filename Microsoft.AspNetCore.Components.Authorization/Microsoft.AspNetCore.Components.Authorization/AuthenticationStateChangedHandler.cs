using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Components.Authorization
{
	/// <summary>
	/// A handler for the <see cref="E:Microsoft.AspNetCore.Components.Authorization.AuthenticationStateProvider.AuthenticationStateChanged" /> event.
	/// </summary>
	/// <param name="task">A <see cref="T:System.Threading.Tasks.Task" /> that supplies the updated <see cref="T:Microsoft.AspNetCore.Components.Authorization.AuthenticationState" />.</param>
	public delegate void AuthenticationStateChangedHandler(Task<AuthenticationState> task);
}
