using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.WebSockets
{
	internal static class HandshakeHelpers
	{
		/// <summary>
		/// Gets request headers needed process the handshake on the server.
		/// </summary>
		public static readonly IEnumerable<string> NeededHeaders;

		public static bool CheckSupportedWebSocketRequest(string method, IEnumerable<KeyValuePair<string, string>> headers)
		{
			throw null;
		}

		public static void GenerateResponseHeaders(string key, string subProtocol, IHeaderDictionary headers)
		{
			throw null;
		}

		/// <summary>
		/// Validates the Sec-WebSocket-Key request header
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static bool IsRequestKeyValid(string value)
		{
			throw null;
		}

		public static string CreateResponseKey(string requestKey)
		{
			throw null;
		}
	}
}
