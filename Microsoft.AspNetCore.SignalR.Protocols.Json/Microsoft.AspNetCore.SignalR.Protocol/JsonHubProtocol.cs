using Microsoft.AspNetCore.Connections;
using Microsoft.Extensions.Options;
using System;
using System.Buffers;

namespace Microsoft.AspNetCore.SignalR.Protocol
{
	/// <summary>
	/// Implements the SignalR Hub Protocol using System.Text.Json.
	/// </summary>
	public sealed class JsonHubProtocol : IHubProtocol
	{
		/// <inheritdoc />
		public string Name
		{
			get
			{
				throw null;
			}
		}

		/// <inheritdoc />
		public int Version
		{
			get
			{
				throw null;
			}
		}

		/// <inheritdoc />
		public TransferFormat TransferFormat
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.SignalR.Protocol.JsonHubProtocol" /> class.
		/// </summary>
		public JsonHubProtocol()
		{
			throw null;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.SignalR.Protocol.JsonHubProtocol" /> class.
		/// </summary>
		/// <param name="options">The options used to initialize the protocol.</param>
		public JsonHubProtocol(IOptions<JsonHubProtocolOptions> options)
		{
			throw null;
		}

		/// <inheritdoc />
		public bool IsVersionSupported(int version)
		{
			throw null;
		}

		/// <inheritdoc />
		public bool TryParseMessage(ref ReadOnlySequence<byte> input, IInvocationBinder binder, out HubMessage message)
		{
			throw null;
		}

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
	}
}
