namespace Microsoft.AspNetCore.SignalR
{
	/// <summary>
	/// A context abstraction for a hub.
	/// </summary>
	public interface IHubContext<THub> where THub : Hub
	{
		/// <summary>
		/// Gets a <see cref="T:Microsoft.AspNetCore.SignalR.IHubClients" /> that can be used to invoke methods on clients connected to the hub.
		/// </summary>
		IHubClients Clients
		{
			get;
		}

		/// <summary>
		/// Gets a <see cref="T:Microsoft.AspNetCore.SignalR.IGroupManager" /> that can be used to add and remove connections to named groups.
		/// </summary>
		IGroupManager Groups
		{
			get;
		}
	}
	/// <summary>
	/// A context abstraction for a hub.
	/// </summary>
	public interface IHubContext<THub, T> where THub : Hub<T> where T : class
	{
		/// <summary>
		/// Gets a <see cref="T:Microsoft.AspNetCore.SignalR.IHubClients`1" /> that can be used to invoke methods on clients connected to the hub.
		/// </summary>
		IHubClients<T> Clients
		{
			get;
		}

		/// <summary>
		/// Gets a <see cref="T:Microsoft.AspNetCore.SignalR.IGroupManager" /> that can be used to add and remove connections to named groups.
		/// </summary>
		IGroupManager Groups
		{
			get;
		}
	}
}
