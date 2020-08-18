using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.SignalR
{
	/// <summary>
	/// Represents a serialized message.
	/// </summary>
	public readonly struct SerializedMessage
	{
		/// <summary>
		/// Gets the protocol of the serialized message.
		/// </summary>
		public string ProtocolName
		{
			[System.Runtime.CompilerServices.NullableContext(1)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the serialized representation of the message.
		/// </summary>
		public ReadOnlyMemory<byte> Serialized
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.SignalR.SerializedMessage" /> class.
		/// </summary>
		/// <param name="protocolName">The protocol of the serialized message.</param>
		/// <param name="serialized">The serialized representation of the message.</param>
		public SerializedMessage(string protocolName, ReadOnlyMemory<byte> serialized)
		{
			throw null;
		}
	}
}
