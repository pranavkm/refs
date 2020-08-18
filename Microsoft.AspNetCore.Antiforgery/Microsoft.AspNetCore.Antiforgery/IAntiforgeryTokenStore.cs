using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Antiforgery
{
	internal interface IAntiforgeryTokenStore
	{
		string? GetCookieToken(HttpContext httpContext);

		/// <summary>
		/// Gets the cookie and request tokens from the request.
		/// </summary>
		/// <param name="httpContext">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> for the current request.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Antiforgery.AntiforgeryTokenSet" />.</returns>
		Task<AntiforgeryTokenSet> GetRequestTokensAsync(HttpContext httpContext);

		void SaveCookieToken(HttpContext httpContext, string token);
	}
}
