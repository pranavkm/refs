using Microsoft.AspNetCore.Http;

namespace Microsoft.AspNetCore.Authentication.Cookies
{
	/// <summary>
	/// Default values related to cookie-based authentication handler
	/// </summary>
	public static class CookieAuthenticationDefaults
	{
		/// <summary>
		/// The default value used for CookieAuthenticationOptions.AuthenticationScheme
		/// </summary>
		public const string AuthenticationScheme = "Cookies";

		/// <summary>
		/// The prefix used to provide a default CookieAuthenticationOptions.CookieName
		/// </summary>
		public static readonly string CookiePrefix;

		/// <summary>
		/// The default value used by CookieAuthenticationMiddleware for the
		/// CookieAuthenticationOptions.LoginPath
		/// </summary>
		public static readonly PathString LoginPath;

		/// <summary>
		/// The default value used by CookieAuthenticationMiddleware for the
		/// CookieAuthenticationOptions.LogoutPath
		/// </summary>
		public static readonly PathString LogoutPath;

		/// <summary>
		/// The default value used by CookieAuthenticationMiddleware for the
		/// CookieAuthenticationOptions.AccessDeniedPath
		/// </summary>
		public static readonly PathString AccessDeniedPath;

		/// <summary>
		/// The default value of the CookieAuthenticationOptions.ReturnUrlParameter
		/// </summary>
		public static readonly string ReturnUrlParameter;
	}
}
