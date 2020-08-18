namespace Microsoft.Extensions.DependencyInjection
{
	/// <summary>
	/// Extension methods for configuring HttpContext services.
	/// </summary>
	public static class HttpServiceCollectionExtensions
	{
		/// <summary>
		/// Adds a default implementation for the <see cref="T:Microsoft.AspNetCore.Http.IHttpContextAccessor" /> service.
		/// </summary>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.</param>
		/// <returns>The service collection.</returns>
		public static IServiceCollection AddHttpContextAccessor(this IServiceCollection services)
		{
			throw null;
		}
	}
}
