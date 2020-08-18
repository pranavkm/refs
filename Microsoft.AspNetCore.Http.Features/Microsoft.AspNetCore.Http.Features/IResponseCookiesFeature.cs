namespace Microsoft.AspNetCore.Http.Features
{
	/// <summary>
	/// A helper for creating the response Set-Cookie header.
	/// </summary>
	public interface IResponseCookiesFeature
	{
		/// <summary>
		/// Gets the wrapper for the response Set-Cookie header.
		/// </summary>
		IResponseCookies Cookies
		{
			get;
		}
	}
}
