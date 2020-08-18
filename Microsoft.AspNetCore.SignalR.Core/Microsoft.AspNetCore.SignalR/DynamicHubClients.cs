using System.Collections.Generic;

namespace Microsoft.AspNetCore.SignalR
{
	/// <summary>
	/// A class that provides <c>dynamic</c> access to connections, including the one that sent the current invocation.
	/// </summary>
	public class DynamicHubClients
	{
		/// <summary>
		/// Gets an object that can be used to invoke methods on all clients connected to the hub.
		/// </summary>
		/// <returns>An object that can be used to invoke methods on the specified user.</returns>
		public dynamic All
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets an object that can be used to invoke methods on the connection which triggered the current invocation.
		/// </summary>
		public dynamic Caller
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets an object that can be used to invoke methods on connections other than the caller.
		/// </summary>
		public dynamic Others
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.SignalR.DynamicHubClients" /> class.
		/// </summary>
		/// <param name="clients">A wrapped <see cref="T:Microsoft.AspNetCore.SignalR.IHubCallerClients" /> that is used to invoke methods.</param>
		public DynamicHubClients(IHubCallerClients clients)
		{
			throw null;
		}

		/// <summary>
		/// Gets an object that can be used to invoke methods on all clients connected to the hub excluding the specified connections.
		/// </summary>
		/// <param name="excludedConnectionIds">A collection of connection IDs to exclude.</param>
		/// <returns>An object that can be used to invoke methods on the specified user.</returns>
		public dynamic AllExcept(IReadOnlyList<string> excludedConnectionIds)
		{
			throw null;
		}

		/// <summary>
		/// Gets an object that can be used to invoke methods on the specified connection.
		/// </summary>
		/// <param name="connectionId">The connection ID.</param>
		/// <returns>An object that can be used to invoke methods.</returns>
		public dynamic Client(string connectionId)
		{
			throw null;
		}

		/// <summary>
		/// Gets an object that can be used to invoke methods on the specified connections.
		/// </summary>
		/// <param name="connectionIds">The connection IDs.</param>
		/// <returns>An object that can be used to invoke methods.</returns>
		public dynamic Clients(IReadOnlyList<string> connectionIds)
		{
			throw null;
		}

		/// <summary>
		/// Gets an object that can be used to invoke methods on all connections in the specified group.
		/// </summary>
		/// <param name="groupName">The group name.</param>
		/// <returns>An object that can be used to invoke methods.</returns>
		public dynamic Group(string groupName)
		{
			throw null;
		}

		/// <summary>
		/// Gets an object that can be used to invoke methods on all connections in all of the specified groups.
		/// </summary>
		/// <param name="groupNames">The group names.</param>
		/// <returns>An object that can be used to invoke methods on the specified user.</returns>
		public dynamic Groups(IReadOnlyList<string> groupNames)
		{
			throw null;
		}

		/// <summary>
		/// Gets an object that can be used to invoke methods on all connections in the specified group excluding the specified connections.
		/// </summary>
		/// <param name="groupName">The group name.</param>
		/// <param name="excludedConnectionIds">A collection of connection IDs to exclude.</param>
		/// <returns>An object that can be used to invoke methods.</returns>
		public dynamic GroupExcept(string groupName, IReadOnlyList<string> excludedConnectionIds)
		{
			throw null;
		}

		/// <summary>
		/// Gets an object that can be used to invoke methods on connections in a group other than the caller.
		/// </summary>
		/// <returns>An object that can be used to invoke methods.</returns>
		public dynamic OthersInGroup(string groupName)
		{
			throw null;
		}

		/// <summary>
		/// Gets an object that can be used to invoke methods on all connections associated with the specified user.
		/// </summary>
		/// <param name="userId">The user ID.</param>
		/// <returns>An object that can be used to invoke methods.</returns>
		public dynamic User(string userId)
		{
			throw null;
		}

		/// <summary>
		/// Gets an object that can be used to invoke methods on all connections associated with all of the specified users.
		/// </summary>
		/// <param name="userIds">The user IDs.</param>
		/// <returns>An object that can be used to invoke methods.</returns>
		public dynamic Users(IReadOnlyList<string> userIds)
		{
			throw null;
		}
	}
}
