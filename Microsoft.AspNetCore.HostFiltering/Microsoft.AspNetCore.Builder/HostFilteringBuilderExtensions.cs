namespace Microsoft.AspNetCore.Builder
{
	/// <summary>
	/// Extension methods for the HostFiltering middleware.
	/// </summary>
	public static class HostFilteringBuilderExtensions
	{
		/// <summary>
		/// Adds middleware for filtering requests by allowed host headers. Invalid requests will be rejected with a
		/// 400 status code.
		/// </summary>
		/// <param name="app">The <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" /> instance this method extends.</param>
		/// <returns>The original <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" />.</returns>
		public static IApplicationBuilder UseHostFiltering(this IApplicationBuilder app)
		{
			throw null;
		}
	}
}
