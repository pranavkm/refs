using System;
using System.Net.Http.HPack;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http2
{
	internal static class HPackHeaderWriter
	{
		/// <summary>
		/// Begin encoding headers in the first HEADERS frame.
		/// </summary>
		public static bool BeginEncodeHeaders(int statusCode, System.Net.Http.HPack.HPackEncoder hpackEncoder, Http2HeadersEnumerator headersEnumerator, Span<byte> buffer, out int length)
		{
			throw null;
		}

		/// <summary>
		/// Begin encoding headers in the first HEADERS frame.
		/// </summary>
		public static bool BeginEncodeHeaders(System.Net.Http.HPack.HPackEncoder hpackEncoder, Http2HeadersEnumerator headersEnumerator, Span<byte> buffer, out int length)
		{
			throw null;
		}

		/// <summary>
		/// Continue encoding headers in the next HEADERS frame. The enumerator should already have a current value.
		/// </summary>
		public static bool ContinueEncodeHeaders(System.Net.Http.HPack.HPackEncoder hpackEncoder, Http2HeadersEnumerator headersEnumerator, Span<byte> buffer, out int length)
		{
			throw null;
		}
	}
}
