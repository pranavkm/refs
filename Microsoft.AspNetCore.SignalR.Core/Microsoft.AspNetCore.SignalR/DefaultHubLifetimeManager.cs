using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.SignalR
{
	/// <summary>
	/// A default in-memory lifetime manager abstraction for <see cref="T:Microsoft.AspNetCore.SignalR.Hub" /> instances.
	/// </summary>
	public class DefaultHubLifetimeManager<THub> : HubLifetimeManager<THub> where THub : Hub
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.SignalR.DefaultHubLifetimeManager`1" /> class.
		/// </summary>
		/// <param name="logger">The logger.</param>
		public DefaultHubLifetimeManager(ILogger<DefaultHubLifetimeManager<THub>> logger)
		{
			throw null;
		}

		/// <inheritdoc />
		public override Task AddToGroupAsync(string connectionId, string groupName, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		/// <inheritdoc />
		public override Task RemoveFromGroupAsync(string connectionId, string groupName, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		/// <inheritdoc />
		public override Task SendAllAsync(string methodName, object?[]? args, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		/// <inheritdoc />
		public override Task SendConnectionAsync(string connectionId, string methodName, object?[]? args, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		/// <inheritdoc />
		public override Task SendGroupAsync(string groupName, string methodName, object?[]? args, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		/// <inheritdoc />
		public override Task SendGroupsAsync(IReadOnlyList<string> groupNames, string methodName, object?[]? args, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		/// <inheritdoc />
		public override Task SendGroupExceptAsync(string groupName, string methodName, object?[]? args, IReadOnlyList<string> excludedConnectionIds, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		/// <inheritdoc />
		public override Task SendUserAsync(string userId, string methodName, object?[]? args, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		/// <inheritdoc />
		public override Task OnConnectedAsync(HubConnectionContext connection)
		{
			throw null;
		}

		/// <inheritdoc />
		public override Task OnDisconnectedAsync(HubConnectionContext connection)
		{
			throw null;
		}

		/// <inheritdoc />
		public override Task SendAllExceptAsync(string methodName, object?[]? args, IReadOnlyList<string> excludedConnectionIds, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		/// <inheritdoc />
		public override Task SendConnectionsAsync(IReadOnlyList<string> connectionIds, string methodName, object?[]? args, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		/// <inheritdoc />
		public override Task SendUsersAsync(IReadOnlyList<string> userIds, string methodName, object?[]? args, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}
	}
}
