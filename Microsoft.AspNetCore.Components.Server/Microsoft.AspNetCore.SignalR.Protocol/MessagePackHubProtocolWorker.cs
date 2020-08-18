using MessagePack;
using System;
using System.Buffers;

namespace Microsoft.AspNetCore.SignalR.Protocol
{
	/// <summary>
	/// Implements support for MessagePackHubProtocol. This code is shared between SignalR and Blazor.
	/// </summary>
	internal abstract class MessagePackHubProtocolWorker
	{
		public bool TryParseMessage(ref ReadOnlySequence<byte> input, IInvocationBinder binder, out HubMessage message)
		{
			throw null;
		}

		protected abstract object DeserializeObject(ref MessagePackReader reader, Type type, string field);

		/// <inheritdoc />
		public void WriteMessage(HubMessage message, IBufferWriter<byte> output)
		{
			throw null;
		}

		/// <inheritdoc />
		public ReadOnlyMemory<byte> GetMessageBytes(HubMessage message)
		{
			throw null;
		}

		protected abstract void Serialize(ref MessagePackWriter writer, Type type, object value);

		protected string ReadString(ref MessagePackReader reader, string field)
		{
			throw null;
		}

		protected MessagePackHubProtocolWorker()
		{
			throw null;
		}
	}
}
