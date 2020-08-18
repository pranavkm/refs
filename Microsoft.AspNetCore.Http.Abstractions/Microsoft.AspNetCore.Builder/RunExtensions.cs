using Microsoft.AspNetCore.Http;

namespace Microsoft.AspNetCore.Builder
{
	/// <summary>
	/// Extension methods for adding terminal middleware.
	/// </summary>
	public static class RunExtensions
	{
		/// <summary>
		/// Adds a terminal middleware delegate to the application's request pipeline.
		/// </summary>
		/// <param name="app">The <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" /> instance.</param>
		/// <param name="handler">A delegate that handles the request.</param>
		public static void Run(this IApplicationBuilder app, RequestDelegate handler)
		{
			throw null;
		}
	}
}
