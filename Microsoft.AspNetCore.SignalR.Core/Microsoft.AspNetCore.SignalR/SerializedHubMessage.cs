using Microsoft.AspNetCore.SignalR.Protocol;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.SignalR
{
	/// <summary>
	/// Represents a serialization cache for a single message.
	/// </summary>
	public class SerializedHubMessage
	{
		/// <summary>
		/// Gets the hub message for the serialization cache.
		/// </summary>
		public HubMessage? Message
		{
			[System.Runtime.CompilerServices.NullableContext(2)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.SignalR.SerializedHubMessage" /> class.
		/// </summary>
		/// <param name="messages">A collection of already serialized messages to cache.</param>
		[System.Runtime.CompilerServices.NullableContext(1)]
		public SerializedHubMessage(IReadOnlyList<SerializedMessage> messages)
		{
			throw null;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.SignalR.SerializedHubMessage" /> class.
		/// </summary>
		/// <param name="message">The hub message for the cache. This will be serialized with an <see cref="T:Microsoft.AspNetCore.SignalR.Protocol.IHubProtocol" /> in <see cref="M:Microsoft.AspNetCore.SignalR.SerializedHubMessage.GetSerializedMessage(Microsoft.AspNetCore.SignalR.Protocol.IHubProtocol)" /> to get the message's serialized representation.</param>
		[System.Runtime.CompilerServices.NullableContext(1)]
		public SerializedHubMessage(HubMessage message)
		{
			throw null;
		}

		/// <summary>
		/// Gets the serialized representation of the <see cref="T:Microsoft.AspNetCore.SignalR.Protocol.HubMessage" /> using the specified <see cref="T:Microsoft.AspNetCore.SignalR.Protocol.IHubProtocol" />.
		/// </summary>
		/// <param name="protocol">The protocol used to create the serialized representation.</param>
		/// <returns>The serialized representation of the <see cref="T:Microsoft.AspNetCore.SignalR.Protocol.HubMessage" />.</returns>
		public ReadOnlyMemory<byte> GetSerializedMessage(IHubProtocol protocol)
		{
			throw null;
		}

		internal IReadOnlyList<SerializedMessage> GetAllSerializations()
		{
			throw null;
		}
	}
}
