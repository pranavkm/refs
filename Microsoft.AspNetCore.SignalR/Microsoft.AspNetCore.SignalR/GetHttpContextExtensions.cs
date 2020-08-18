using Microsoft.AspNetCore.Http;

namespace Microsoft.AspNetCore.SignalR
{
	/// <summary>
	/// Extension methods for accessing <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> from a hub context.
	/// </summary>
	public static class GetHttpContextExtensions
	{
		/// <summary>
		/// Gets <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> from the specified connection, or <c>null</c> if the connection is not associated with an HTTP request.
		/// </summary>
		/// <param name="connection">The connection.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> for the connection, or <c>null</c> if the connection is not associated with an HTTP request.</returns>
		public static HttpContext GetHttpContext(this HubCallerContext connection)
		{
			throw null;
		}

		/// <summary>
		/// Gets <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> from the specified connection, or <c>null</c> if the connection is not associated with an HTTP request.
		/// </summary>
		/// <param name="connection">The connection.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> for the connection, or <c>null</c> if the connection is not associated with an HTTP request.</returns>
		public static HttpContext GetHttpContext(this HubConnectionContext connection)
		{
			throw null;
		}
	}
}
