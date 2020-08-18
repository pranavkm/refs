using Microsoft.AspNetCore.Http;

namespace Microsoft.AspNetCore.Builder
{
	/// <summary>
	/// Extension methods for <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" />.
	/// </summary>
	public static class UsePathBaseExtensions
	{
		/// <summary>
		/// Adds a middleware that extracts the specified path base from request path and postpend it to the request path base.
		/// </summary>
		/// <param name="app">The <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" /> instance.</param>
		/// <param name="pathBase">The path base to extract.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" /> instance.</returns>
		public static IApplicationBuilder UsePathBase(this IApplicationBuilder app, PathString pathBase)
		{
			throw null;
		}
	}
}
