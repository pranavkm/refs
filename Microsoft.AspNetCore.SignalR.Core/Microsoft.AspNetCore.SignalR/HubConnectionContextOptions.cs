using Microsoft.AspNetCore.Internal;
using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.SignalR
{
	/// <summary>
	/// Options used to configure <see cref="T:Microsoft.AspNetCore.SignalR.HubConnectionContext" />.
	/// </summary>
	public class HubConnectionContextOptions
	{
		/// <summary>
		/// Gets or sets the interval used to send keep alive pings to connected clients.
		/// </summary>
		public TimeSpan KeepAliveInterval
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
		/// Gets or sets the time window clients have to send a message before the server closes the connection.
		/// </summary>
		public TimeSpan ClientTimeoutInterval
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
		/// Gets or sets the max buffer size for client upload streams.
		/// </summary>
		public int StreamBufferCapacity
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
		/// Gets or sets the maximum message size the client can send.
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

		internal ISystemClock SystemClock
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

		public HubConnectionContextOptions()
		{
			throw null;
		}
	}
}
