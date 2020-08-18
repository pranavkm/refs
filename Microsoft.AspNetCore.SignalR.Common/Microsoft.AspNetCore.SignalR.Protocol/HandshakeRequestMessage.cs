using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.SignalR.Protocol
{
	/// <summary>
	/// A handshake request message.
	/// </summary>
	public class HandshakeRequestMessage : HubMessage
	{
		/// <summary>
		/// Gets the requested protocol name.
		/// </summary>
		public string Protocol
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the requested protocol version.
		/// </summary>
		public int Version
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.SignalR.Protocol.HandshakeRequestMessage" /> class.
		/// </summary>
		/// <param name="protocol">The requested protocol name.</param>
		/// <param name="version">The requested protocol version.</param>
		public HandshakeRequestMessage(string protocol, int version)
		{
			throw null;
		}
	}
}
