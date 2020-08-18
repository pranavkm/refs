namespace Microsoft.AspNetCore.Builder
{
	/// <summary>
	/// Extension methods to add authorization capabilities to an HTTP application pipeline.
	/// </summary>
	public static class AuthorizationAppBuilderExtensions
	{
		/// <summary>
		/// Adds the <see cref="T:Microsoft.AspNetCore.Authorization.AuthorizationMiddleware" /> to the specified <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" />, which enables authorization capabilities.
		/// </summary>
		/// <param name="app">The <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" /> to add the middleware to.</param>
		/// <returns>A reference to this instance after the operation has completed.</returns>
		public static IApplicationBuilder UseAuthorization(this IApplicationBuilder app)
		{
			throw null;
		}
	}
}
