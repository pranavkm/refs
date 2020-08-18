namespace Microsoft.AspNetCore.SignalR
{
	/// <summary>
	/// A base class for SignalR hubs that use <c>dynamic</c> to represent client invocations.
	/// </summary>
	public abstract class DynamicHub : Hub
	{
		/// <summary>
		/// Gets or sets an object that can be used to invoke methods on the clients connected to this hub.
		/// </summary>
		public new DynamicHubClients Clients
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

		protected DynamicHub()
		{
			throw null;
		}
	}
}
