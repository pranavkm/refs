using Microsoft.AspNetCore.Connections;

namespace Microsoft.AspNetCore.Http.Connections
{
	public static class HttpConnectionContextExtensions
	{
		/// <summary>
		/// Gets the <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> associated with the connection, if there is one.
		/// </summary>
		/// <param name="connection">The <see cref="T:Microsoft.AspNetCore.Connections.ConnectionContext" /> representing the connection.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> associated with the connection, or <see langword="null" /> if the connection is not HTTP-based.</returns>
		/// <remarks>
		/// SignalR connections can run on top of HTTP transports like WebSockets or Long Polling, or other non-HTTP transports. As a result,
		/// this method can sometimes return <see langword="null" /> depending on the configuration of your application.
		/// </remarks>
		public static HttpContext? GetHttpContext(this ConnectionContext connection)
		{
			throw null;
		}
	}
}
