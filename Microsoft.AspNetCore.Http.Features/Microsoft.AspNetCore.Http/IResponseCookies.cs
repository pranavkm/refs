namespace Microsoft.AspNetCore.Http
{
	/// <summary>
	/// A wrapper for the response Set-Cookie header.
	/// </summary>
	public interface IResponseCookies
	{
		/// <summary>
		/// Add a new cookie and value.
		/// </summary>
		/// <param name="key">Name of the new cookie.</param>
		/// <param name="value">Value of the new cookie.</param>
		void Append(string key, string value);

		/// <summary>
		/// Add a new cookie.
		/// </summary>
		/// <param name="key">Name of the new cookie.</param>
		/// <param name="value">Value of the new cookie.</param>
		/// <param name="options"><see cref="T:Microsoft.AspNetCore.Http.CookieOptions" /> included in the new cookie setting.</param>
		void Append(string key, string value, CookieOptions options);

		/// <summary>
		/// Sets an expired cookie.
		/// </summary>
		/// <param name="key">Name of the cookie to expire.</param>
		void Delete(string key);

		/// <summary>
		/// Sets an expired cookie.
		/// </summary>
		/// <param name="key">Name of the cookie to expire.</param>
		/// <param name="options">
		/// <see cref="T:Microsoft.AspNetCore.Http.CookieOptions" /> used to discriminate the particular cookie to expire. The
		/// <see cref="P:Microsoft.AspNetCore.Http.CookieOptions.Domain" /> and <see cref="P:Microsoft.AspNetCore.Http.CookieOptions.Path" /> values are especially important.
		/// </param>
		void Delete(string key, CookieOptions options);
	}
}
