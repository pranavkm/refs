namespace Microsoft.AspNetCore.SignalR
{
	/// <summary>
	/// A provider abstraction for configuring the "User ID" for a connection.
	/// </summary>
	/// <remarks><see cref="T:Microsoft.AspNetCore.SignalR.IUserIdProvider" /> is used by <see cref="M:Microsoft.AspNetCore.SignalR.IHubClients`1.User(System.String)" /> to invoke connections associated with a user.</remarks>
	public interface IUserIdProvider
	{
		/// <summary>
		/// Gets the user ID for the specified connection.
		/// </summary>
		/// <param name="connection">The connection to get the user ID for.</param>
		/// <returns>The user ID for the specified connection.</returns>
		string? GetUserId(HubConnectionContext connection);
	}
}
