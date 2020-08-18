using Microsoft.AspNetCore.Http;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Authentication.Cookies
{
	/// <summary>
	/// This handles cookies that are limited by per cookie length. It breaks down long cookies for responses, and reassembles them
	/// from requests.
	/// </summary>
	public class ChunkingCookieManager : ICookieManager
	{
		/// <summary>
		/// The default maximum size of characters in a cookie to send back to the client.
		/// </summary>
		public const int DefaultChunkSize = 4050;

		/// <summary>
		/// The maximum size of cookie to send back to the client. If a cookie exceeds this size it will be broken down into multiple
		/// cookies. Set this value to null to disable this behavior. The default is 4090 characters, which is supported by all
		/// common browsers.
		///
		/// Note that browsers may also have limits on the total size of all cookies per domain, and on the number of cookies per domain.
		/// </summary>
		public int? ChunkSize
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Throw if not all chunks of a cookie are available on a request for re-assembly.
		/// </summary>
		public bool ThrowForPartialCookies
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public ChunkingCookieManager()
		{
			throw null;
		}

		/// <summary>
		/// Get the reassembled cookie. Non chunked cookies are returned normally.
		/// Cookies with missing chunks just have their "chunks-XX" header returned.
		/// </summary>
		/// <param name="context"></param>
		/// <param name="key"></param>
		/// <returns>The reassembled cookie, if any, or null.</returns>
		public string? GetRequestCookie(HttpContext context, string key)
		{
			throw null;
		}

		/// <summary>
		/// Appends a new response cookie to the Set-Cookie header. If the cookie is larger than the given size limit
		/// then it will be broken down into multiple cookies as follows:
		/// Set-Cookie: CookieName=chunks-3; path=/
		/// Set-Cookie: CookieNameC1=Segment1; path=/
		/// Set-Cookie: CookieNameC2=Segment2; path=/
		/// Set-Cookie: CookieNameC3=Segment3; path=/
		/// </summary>
		/// <param name="context"></param>
		/// <param name="key"></param>
		/// <param name="value"></param>
		/// <param name="options"></param>
		public void AppendResponseCookie(HttpContext context, string key, string? value, CookieOptions options)
		{
			throw null;
		}

		/// <summary>
		/// Deletes the cookie with the given key by setting an expired state. If a matching chunked cookie exists on
		/// the request, delete each chunk.
		/// </summary>
		/// <param name="context"></param>
		/// <param name="key"></param>
		/// <param name="options"></param>
		public void DeleteCookie(HttpContext context, string key, CookieOptions options)
		{
			throw null;
		}
	}
}
