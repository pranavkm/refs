using System.Buffers;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.WebSockets
{
	internal static class WebSocketExtensions
	{
		public static ValueTask SendAsync(this WebSocket webSocket, ReadOnlySequence<byte> buffer, WebSocketMessageType webSocketMessageType, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}
	}
}
