namespace Microsoft.AspNetCore.Http
{
	/// <summary>
	/// A wrapper for the response Set-Cookie header.
	/// </summary>
	internal class ResponseCookies : IResponseCookies
	{
		internal const string EnableCookieNameEncoding = "Microsoft.AspNetCore.Http.EnableCookieNameEncoding";

		internal bool _enableCookieNameEncoding;

		/// <summary>
		/// Create a new wrapper.
		/// </summary>
		/// <param name="headers">The <see cref="T:Microsoft.AspNetCore.Http.IHeaderDictionary" /> for the response.</param>
		public ResponseCookies(IHeaderDictionary headers)
		{
			throw null;
		}

		/// <inheritdoc />
		public void Append(string key, string value)
		{
			throw null;
		}

		/// <inheritdoc />
		public void Append(string key, string value, CookieOptions options)
		{
			throw null;
		}

		/// <inheritdoc />
		public void Delete(string key)
		{
			throw null;
		}

		/// <inheritdoc />
		public void Delete(string key, CookieOptions options)
		{
			throw null;
		}
	}
}
