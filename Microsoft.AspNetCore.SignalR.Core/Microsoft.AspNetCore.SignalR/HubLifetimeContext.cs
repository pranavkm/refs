using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.SignalR
{
	/// <summary>
	/// Context for the hub lifetime events <see cref="M:Microsoft.AspNetCore.SignalR.Hub.OnConnectedAsync" /> and <see cref="M:Microsoft.AspNetCore.SignalR.Hub.OnDisconnectedAsync(System.Exception)" />.
	/// </summary>
	public sealed class HubLifetimeContext
	{
		/// <summary>
		/// Gets the context for the active Hub connection and caller.
		/// </summary>
		public HubCallerContext Context
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the Hub instance.
		/// </summary>
		public Hub Hub
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// The <see cref="T:System.IServiceProvider" /> specific to the scope of this Hub method invocation.
		/// </summary>
		public IServiceProvider ServiceProvider
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Instantiates a new instance of the <see cref="T:Microsoft.AspNetCore.SignalR.HubLifetimeContext" /> class.
		/// </summary>
		/// <param name="context">Context for the active Hub connection and caller.</param>
		/// <param name="serviceProvider">The <see cref="T:System.IServiceProvider" /> specific to the scope of this Hub method invocation.</param>
		/// <param name="hub">The instance of the Hub.</param>
		public HubLifetimeContext(HubCallerContext context, IServiceProvider serviceProvider, Hub hub)
		{
			throw null;
		}
	}
}
