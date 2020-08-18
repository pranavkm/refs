using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Components.Routing
{
	/// <summary>
	/// Contract to setup navigation interception on the client.
	/// </summary>
	public interface INavigationInterception
	{
		/// <summary>
		/// Enables navigation interception on the client.
		/// </summary>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task" /> that represents the asynchronous operation.</returns>
		Task EnableNavigationInterceptionAsync();
	}
}
