using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Localization
{
	/// <summary>
	/// Represents a provider for determining the culture information of an <see cref="T:Microsoft.AspNetCore.Http.HttpRequest" />.
	/// </summary>
	public interface IRequestCultureProvider
	{
		/// <summary>
		/// Implements the provider to determine the culture of the given request.
		/// </summary>
		/// <param name="httpContext">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> for the request.</param>
		/// <returns>
		///     The determined <see cref="T:Microsoft.AspNetCore.Localization.ProviderCultureResult" />.
		///     Returns <c>null</c> if the provider couldn't determine a <see cref="T:Microsoft.AspNetCore.Localization.ProviderCultureResult" />.
		/// </returns>
		Task<ProviderCultureResult> DetermineProviderCultureResult(HttpContext httpContext);
	}
}
