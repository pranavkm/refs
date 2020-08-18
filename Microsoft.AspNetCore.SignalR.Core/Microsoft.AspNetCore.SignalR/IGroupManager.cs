using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.SignalR
{
	/// <summary>
	/// A manager abstraction for adding and removing connections from groups.
	/// </summary>
	public interface IGroupManager
	{
		/// <summary>
		/// Adds a connection to the specified group.
		/// </summary>
		/// <param name="connectionId">The connection ID to add to a group.</param>
		/// <param name="groupName">The group name.</param>
		/// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="P:System.Threading.CancellationToken.None" />.</param>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task" /> that represents the asynchronous add.</returns>
		Task AddToGroupAsync(string connectionId, string groupName, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Removes a connection from the specified group.
		/// </summary>
		/// <param name="connectionId">The connection ID to remove from a group.</param>
		/// <param name="groupName">The group name.</param>
		/// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="P:System.Threading.CancellationToken.None" />.</param>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task" /> that represents the asynchronous remove.</returns>
		Task RemoveFromGroupAsync(string connectionId, string groupName, CancellationToken cancellationToken = default(CancellationToken));
	}
}
