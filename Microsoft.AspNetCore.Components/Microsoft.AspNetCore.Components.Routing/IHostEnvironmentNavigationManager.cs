namespace Microsoft.AspNetCore.Components.Routing
{
	/// <summary>
	/// An optional interface for <see cref="T:Microsoft.AspNetCore.Components.NavigationManager" /> implementations that must be initialized
	/// by the host.
	/// </summary>
	public interface IHostEnvironmentNavigationManager
	{
		/// <summary>
		/// Initializes the <see cref="T:Microsoft.AspNetCore.Components.NavigationManager" />.
		/// </summary>
		/// <param name="baseUri">The base URI.</param>
		/// <param name="uri">The absolute URI.</param>
		void Initialize(string baseUri, string uri);
	}
}
