namespace Microsoft.AspNetCore.Builder
{
	public static class ForwardedHeadersExtensions
	{
		/// <summary>
		/// Forwards proxied headers onto current request
		/// </summary>
		/// <param name="builder"></param>
		/// <returns></returns>
		public static IApplicationBuilder UseForwardedHeaders(this IApplicationBuilder builder)
		{
			throw null;
		}

		/// <summary>
		/// Forwards proxied headers onto current request
		/// </summary>
		/// <param name="builder"></param>
		/// <param name="options">Enables the different forwarding options.</param>
		/// <returns></returns>
		public static IApplicationBuilder UseForwardedHeaders(this IApplicationBuilder builder, ForwardedHeadersOptions options)
		{
			throw null;
		}
	}
}
