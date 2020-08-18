namespace Microsoft.AspNetCore.Builder
{
	/// <summary>
	/// Extension methods to add authentication capabilities to an HTTP application pipeline.
	/// </summary>
	public static class AuthAppBuilderExtensions
	{
		/// <summary>
		/// Adds the <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationMiddleware" /> to the specified <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" />, which enables authentication capabilities.
		/// </summary>
		/// <param name="app">The <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" /> to add the middleware to.</param>
		/// <returns>A reference to this instance after the operation has completed.</returns>
		public static IApplicationBuilder UseAuthentication(this IApplicationBuilder app)
		{
			throw null;
		}
	}
}
