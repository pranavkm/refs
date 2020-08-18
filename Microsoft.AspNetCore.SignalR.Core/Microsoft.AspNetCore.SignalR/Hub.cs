using System;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.SignalR
{
	/// <summary>
	/// A base class for a SignalR hub.
	/// </summary>
	public abstract class Hub : IDisposable
	{
		/// <summary>
		/// Gets or sets an object that can be used to invoke methods on the clients connected to this hub.
		/// </summary>
		public IHubCallerClients Clients
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets the hub caller context.
		/// </summary>
		public HubCallerContext Context
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets the group manager.
		/// </summary>
		public IGroupManager Groups
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Called when a new connection is established with the hub.
		/// </summary>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task" /> that represents the asynchronous connect.</returns>
		public virtual Task OnConnectedAsync()
		{
			throw null;
		}

		/// <summary>
		/// Called when a connection with the hub is terminated.
		/// </summary>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task" /> that represents the asynchronous disconnect.</returns>
		public virtual Task OnDisconnectedAsync(Exception? exception)
		{
			throw null;
		}

		/// <summary>
		/// Releases all resources currently used by this <see cref="T:Microsoft.AspNetCore.SignalR.Hub" /> instance.
		/// </summary>
		/// <param name="disposing"><c>true</c> if this method is being invoked by the <see cref="M:Microsoft.AspNetCore.SignalR.Hub.Dispose" /> method,
		/// otherwise <c>false</c>.</param>
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		/// <inheritdoc />
		public void Dispose()
		{
			throw null;
		}

		protected Hub()
		{
			throw null;
		}
	}
	/// <summary>
	/// A base class for a strongly typed SignalR hub.
	/// </summary>
	/// <typeparam name="T">The type of client.</typeparam>
	public abstract class Hub<T> : Hub where T : class
	{
		/// <summary>
		/// Gets or sets a <typeparamref name="T" /> that can be used to invoke methods on the clients connected to this hub.
		/// </summary>
		public new IHubCallerClients<T> Clients
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		protected Hub()
		{
			throw null;
		}
	}
}
