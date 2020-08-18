namespace Microsoft.AspNetCore.Http
{
	public static class ResponseExtensions
	{
		public static void Clear(this HttpResponse response)
		{
			throw null;
		}

		/// <summary>
		/// Returns a redirect response (HTTP 301, HTTP 302, HTTP 307 or HTTP 308) to the client.
		/// </summary>
		/// <param name="response">The <see cref="T:Microsoft.AspNetCore.Http.HttpResponse" /> to redirect.</param>
		/// <param name="location">The URL to redirect the client to. This must be properly encoded for use in http headers where only ASCII characters are allowed.</param>
		/// <param name="permanent"><c>True</c> if the redirect is permanent (301 or 308), otherwise <c>false</c> (302 or 307).</param>
		/// <param name="preserveMethod"><c>True</c> if the redirect needs to reuse the method and body (308 or 307), otherwise <c>false</c> (301 or 302).</param>
		public static void Redirect(this HttpResponse response, string location, bool permanent, bool preserveMethod)
		{
			throw null;
		}
	}
}
