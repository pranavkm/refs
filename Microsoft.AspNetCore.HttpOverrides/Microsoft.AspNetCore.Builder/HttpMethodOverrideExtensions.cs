namespace Microsoft.AspNetCore.Builder
{
	public static class HttpMethodOverrideExtensions
	{
		/// <summary>
		/// Allows incoming POST request to override method type with type specified in header.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" /> instance this method extends.</param>
		public static IApplicationBuilder UseHttpMethodOverride(this IApplicationBuilder builder)
		{
			throw null;
		}

		/// <summary>
		/// Allows incoming POST request to override method type with type specified in form.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" /> instance this method extends.</param>
		/// <param name="options">The <see cref="T:Microsoft.AspNetCore.Builder.HttpMethodOverrideOptions" />.</param>
		public static IApplicationBuilder UseHttpMethodOverride(this IApplicationBuilder builder, HttpMethodOverrideOptions options)
		{
			throw null;
		}
	}
}
