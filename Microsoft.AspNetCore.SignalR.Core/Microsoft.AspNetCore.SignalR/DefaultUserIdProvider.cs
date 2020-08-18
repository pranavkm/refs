namespace Microsoft.AspNetCore.SignalR
{
	/// <summary>
	/// The default provider for getting the user ID from a connection.
	/// This provider gets the user ID from the connection's <see cref="P:Microsoft.AspNetCore.SignalR.HubConnectionContext.User" /> name identifier claim.
	/// </summary>
	public class DefaultUserIdProvider : IUserIdProvider
	{
		/// <inheritdoc />
		public virtual string? GetUserId(HubConnectionContext connection)
		{
			throw null;
		}

		public DefaultUserIdProvider()
		{
			throw null;
		}
	}
}
