using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Antiforgery
{
	/// <summary>
	/// The antiforgery token pair (cookie and request token) for a request.
	/// </summary>
	public class AntiforgeryTokenSet
	{
		/// <summary>
		/// Gets the request token.
		/// </summary>
		public string? RequestToken
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the name of the form field used for the request token.
		/// </summary>
		public string FormFieldName
		{
			[System.Runtime.CompilerServices.NullableContext(1)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the name of the header used for the request token.
		/// </summary>
		public string? HeaderName
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the cookie token.
		/// </summary>
		public string? CookieToken
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates the antiforgery token pair (cookie and request token) for a request.
		/// </summary>
		/// <param name="requestToken">The token that is supplied in the request.</param>
		/// <param name="cookieToken">The token that is supplied in the request cookie.</param>
		/// <param name="formFieldName">The name of the form field used for the request token.</param>
		/// <param name="headerName">The name of the header used for the request token.</param>
		public AntiforgeryTokenSet(string? requestToken, string? cookieToken, string formFieldName, string? headerName)
		{
			throw null;
		}
	}
}
