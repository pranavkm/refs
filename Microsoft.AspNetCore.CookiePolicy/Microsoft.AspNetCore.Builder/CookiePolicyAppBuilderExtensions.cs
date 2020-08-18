namespace Microsoft.AspNetCore.Builder
{
	/// <summary>
	/// Extension methods to add cookie policy capabilities to an HTTP application pipeline.
	/// </summary>
	public static class CookiePolicyAppBuilderExtensions
	{
		/// <summary>
		/// Adds the <see cref="T:Microsoft.AspNetCore.CookiePolicy.CookiePolicyMiddleware" /> handler to the specified <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" />, which enables cookie policy capabilities.
		/// </summary>
		/// <param name="app">The <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" /> to add the handler to.</param>
		/// <returns>A reference to this instance after the operation has completed.</returns>
		public static IApplicationBuilder UseCookiePolicy(this IApplicationBuilder app)
		{
			throw null;
		}

		/// <summary>
		/// Adds the <see cref="T:Microsoft.AspNetCore.CookiePolicy.CookiePolicyMiddleware" /> handler to the specified <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" />, which enables cookie policy capabilities.
		/// </summary>
		/// <param name="app">The <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" /> to add the handler to.</param>
		/// <param name="options">A <see cref="T:Microsoft.AspNetCore.Builder.CookiePolicyOptions" /> that specifies options for the handler.</param>
		/// <returns>A reference to this instance after the operation has completed.</returns>
		public static IApplicationBuilder UseCookiePolicy(this IApplicationBuilder app, CookiePolicyOptions options)
		{
			throw null;
		}
	}
}
