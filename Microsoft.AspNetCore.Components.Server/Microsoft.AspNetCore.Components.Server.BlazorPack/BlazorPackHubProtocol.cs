using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.SignalR.Internal;
using Microsoft.AspNetCore.SignalR.Protocol;
using System;
using System.Buffers;

namespace Microsoft.AspNetCore.Components.Server.BlazorPack
{
	/// <summary>
	/// Implements the SignalR Hub Protocol using MessagePack with limited type support.
	/// </summary>
	[NonDefaultHubProtocol]
	internal sealed class BlazorPackHubProtocol : IHubProtocol
	{
		internal const string ProtocolName = "blazorpack";

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

		public ReadOnlyMemory<byte> GetMessageBytes(HubMessage message)
		{
			throw null;
		}

		public BlazorPackHubProtocol()
		{
			throw null;
		}
	}
}
