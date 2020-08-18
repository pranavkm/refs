namespace Microsoft.AspNetCore.SignalR
{
	/// <summary>
	/// A clients caller abstraction for a hub.
	/// </summary>
	public interface IHubCallerClients : IHubCallerClients<IClientProxy>, IHubClients<IClientProxy>
	{
	}
	/// <summary>
	/// An abstraction that provides access to client connections, including the one that sent the current invocation.
	/// </summary>
	/// <typeparam name="T">The client caller type.</typeparam>
	public interface IHubCallerClients<T> : IHubClients<T>
	{
		/// <summary>
		/// Gets a caller to the connection which triggered the current invocation.
		/// </summary>
		T Caller
		{
			get;
		}

		/// <summary>
		/// Gets a caller to all connections except the one which triggered the current invocation.
		/// </summary>
		T Others
		{
			get;
		}

		/// <summary>
		/// Gets a caller to all connections in the specified group, except the one which triggered the current invocation.
		/// </summary>
		/// <returns>A client caller.</returns>
		T OthersInGroup(string groupName);
	}
}
