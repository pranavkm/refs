using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Localization
{
	/// <summary>
	/// Determines the culture information for a request via the configured delegate.
	/// </summary>
	public class CustomRequestCultureProvider : RequestCultureProvider
	{
		/// <summary>
		/// Creates a new <see cref="T:Microsoft.AspNetCore.Localization.CustomRequestCultureProvider" /> using the specified delegate.
		/// </summary>
		/// <param name="provider">The provider delegate.</param>
		public CustomRequestCultureProvider(Func<HttpContext, Task<ProviderCultureResult>> provider)
		{
			throw null;
		}

		/// <inheritdoc />
		public override Task<ProviderCultureResult> DetermineProviderCultureResult(HttpContext httpContext)
		{
			throw null;
		}
	}
}
