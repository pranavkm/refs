using System.Net.WebSockets;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Http.Features
{
	public interface IHttpWebSocketFeature
	{
		/// <summary>
		/// Indicates if this is a WebSocket upgrade request.
		/// </summary>
		bool IsWebSocketRequest
		{
			get;
		}

		/// <summary>
		/// Attempts to upgrade the request to a <see cref="T:System.Net.WebSockets.WebSocket" />. Check <see cref="P:Microsoft.AspNetCore.Http.Features.IHttpWebSocketFeature.IsWebSocketRequest" />
		/// before invoking this.
		/// </summary>
		/// <param name="context"></param>
		/// <returns></returns>
		Task<WebSocket> AcceptAsync(WebSocketAcceptContext context);
	}
}
