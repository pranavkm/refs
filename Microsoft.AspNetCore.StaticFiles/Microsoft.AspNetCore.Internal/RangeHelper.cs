using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Headers;
using Microsoft.Extensions.Logging;
using Microsoft.Net.Http.Headers;

namespace Microsoft.AspNetCore.Internal
{
	/// <summary>
	/// Provides a parser for the Range Header in an <see cref="P:Microsoft.AspNetCore.Http.HttpContext.Request" />.
	/// </summary>
	internal static class RangeHelper
	{
		/// <summary>
		/// Returns the normalized form of the requested range if the Range Header in the <see cref="P:Microsoft.AspNetCore.Http.HttpContext.Request" /> is valid.
		/// </summary>
		/// <param name="context">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> associated with the request.</param>
		/// <param name="requestHeaders">The <see cref="T:Microsoft.AspNetCore.Http.Headers.RequestHeaders" /> associated with the given <paramref name="context" />.</param>
		/// <param name="length">The total length of the file representation requested.</param>
		/// <param name="logger">The <see cref="T:Microsoft.Extensions.Logging.ILogger" />.</param>
		/// <returns>A boolean value which represents if the <paramref name="requestHeaders" /> contain a single valid 
		/// range request. A <see cref="T:Microsoft.Net.Http.Headers.RangeItemHeaderValue" /> which represents the normalized form of the 
		/// range parsed from the <paramref name="requestHeaders" /> or <c>null</c> if it cannot be normalized.</returns>
		/// <remark>If the Range header exists but cannot be parsed correctly, or if the provided length is 0, then the range request cannot be satisfied (status 416). 
		/// This results in (<c>true</c>,<c>null</c>) return values.</remark>
		public static (bool isRangeRequest, RangeItemHeaderValue range) ParseRange(HttpContext context, RequestHeaders requestHeaders, long length, ILogger logger)
		{
			throw null;
		}

		internal static RangeItemHeaderValue NormalizeRange(RangeItemHeaderValue range, long length)
		{
			throw null;
		}
	}
}
