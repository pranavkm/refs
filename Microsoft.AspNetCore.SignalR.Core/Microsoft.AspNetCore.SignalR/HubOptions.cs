using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.SignalR
{
	/// <summary>
	/// Options used to configure hub instances.
	/// </summary>
	public class HubOptions
	{
		/// <summary>
		/// Gets or sets the interval used by the server to timeout incoming handshake requests by clients. The default timeout is 15 seconds.
		/// </summary>
		public TimeSpan? HandshakeTimeout
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets the interval used by the server to send keep alive pings to connected clients. The default interval is 15 seconds.
		/// </summary>
		public TimeSpan? KeepAliveInterval
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets the time window clients have to send a message before the server closes the connection. The default timeout is 30 seconds.
		/// </summary>
		public TimeSpan? ClientTimeoutInterval
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets a collection of supported hub protocol names.
		/// </summary>
		public IList<string>? SupportedProtocols
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets the maximum message size of a single incoming hub message. The default is 32KB.
		/// </summary>
		public long? MaximumReceiveMessageSize
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether detailed error messages are sent to the client.
		/// Detailed error messages include details from exceptions thrown on the server.
		/// </summary>
		public bool? EnableDetailedErrors
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets the max buffer size for client upload streams. The default size is 10.
		/// </summary>
		public int? StreamBufferCapacity
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		internal List<IHubFilter>? HubFilters
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public HubOptions()
		{
			throw null;
		}
	}
	/// <summary>
	/// Options used to configure the specified hub type instances. These options override globally set options.
	/// </summary>
	/// <typeparam name="THub">The hub type to configure.</typeparam>
	public class HubOptions<THub> : HubOptions where THub : Hub
	{
		internal bool UserHasSetValues
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public HubOptions()
		{
			throw null;
		}
	}
}
