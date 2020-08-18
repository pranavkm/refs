namespace Microsoft.AspNetCore.SignalR
{
	/// <summary>
	/// A <see cref="T:Microsoft.AspNetCore.SignalR.Hub" /> activator abstraction.
	/// </summary>
	/// <typeparam name="THub">The hub type.</typeparam>
	public interface IHubActivator<THub> where THub : Hub
	{
		/// <summary>
		/// Creates a hub.
		/// </summary>
		/// <returns>The created hub.</returns>
		THub Create();

		/// <summary>
		/// Releases the specified hub.
		/// </summary>
		/// <param name="hub">The hub to release.</param>
		void Release(THub hub);
	}
}
