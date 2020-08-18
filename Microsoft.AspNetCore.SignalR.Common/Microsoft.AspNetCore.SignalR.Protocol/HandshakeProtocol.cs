using System;
using System.Buffers;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.AspNetCore.SignalR.Protocol
{
	/// <summary>
	/// A helper class for working with SignalR handshakes.
	/// </summary>
	public static class HandshakeProtocol
	{
		public static ReadOnlySpan<byte> GetSuccessfulHandshake(IHubProtocol protocol)
		{
			throw null;
		}

		/// <summary>
		/// Writes the serialized representation of a <see cref="T:Microsoft.AspNetCore.SignalR.Protocol.HandshakeRequestMessage" /> to the specified writer.
		/// </summary>
		/// <param name="requestMessage">The message to write.</param>
		/// <param name="output">The output writer.</param>
		public static void WriteRequestMessage(HandshakeRequestMessage requestMessage, IBufferWriter<byte> output)
		{
			throw null;
		}

		/// <summary>
		/// Writes the serialized representation of a <see cref="T:Microsoft.AspNetCore.SignalR.Protocol.HandshakeResponseMessage" /> to the specified writer.
		/// </summary>
		/// <param name="responseMessage">The message to write.</param>
		/// <param name="output">The output writer.</param>
		public static void WriteResponseMessage(HandshakeResponseMessage responseMessage, IBufferWriter<byte> output)
		{
			throw null;
		}

		/// <summary>
		/// Creates a new <see cref="T:Microsoft.AspNetCore.SignalR.Protocol.HandshakeResponseMessage" /> from the specified serialized representation.
		/// </summary>
		/// <param name="buffer">The serialized representation of the message.</param>
		/// <param name="responseMessage">When this method returns, contains the parsed message.</param>
		/// <returns>A value that is <c>true</c> if the <see cref="T:Microsoft.AspNetCore.SignalR.Protocol.HandshakeResponseMessage" /> was successfully parsed; otherwise, <c>false</c>.</returns>
		public static bool TryParseResponseMessage(ref ReadOnlySequence<byte> buffer, [NotNullWhen(true)] out HandshakeResponseMessage? responseMessage)
		{
			throw null;
		}

		/// <summary>
		/// Creates a new <see cref="T:Microsoft.AspNetCore.SignalR.Protocol.HandshakeRequestMessage" /> from the specified serialized representation.
		/// </summary>
		/// <param name="buffer">The serialized representation of the message.</param>
		/// <param name="requestMessage">When this method returns, contains the parsed message.</param>
		/// <returns>A value that is <c>true</c> if the <see cref="T:Microsoft.AspNetCore.SignalR.Protocol.HandshakeRequestMessage" /> was successfully parsed; otherwise, <c>false</c>.</returns>
		public static bool TryParseRequestMessage(ref ReadOnlySequence<byte> buffer, [NotNullWhen(true)] out HandshakeRequestMessage? requestMessage)
		{
			throw null;
		}
	}
}
