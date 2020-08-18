using Microsoft.AspNetCore.Http;
using System;

namespace Microsoft.AspNetCore.Builder
{
	/// <summary>
	/// Extension methods for the <see cref="T:Microsoft.AspNetCore.Builder.Extensions.MapMiddleware" />.
	/// </summary>
	public static class MapExtensions
	{
		/// <summary>
		/// Branches the request pipeline based on matches of the given request path. If the request path starts with
		/// the given path, the branch is executed.
		/// </summary>
		/// <param name="app">The <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" /> instance.</param>
		/// <param name="pathMatch">The request path to match.</param>
		/// <param name="configuration">The branch to take for positive path matches.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" /> instance.</returns>
		public static IApplicationBuilder Map(this IApplicationBuilder app, PathString pathMatch, Action<IApplicationBuilder> configuration)
		{
			throw null;
		}

		/// <summary>
		/// Branches the request pipeline based on matches of the given request path. If the request path starts with
		/// the given path, the branch is executed.
		/// </summary>
		/// <param name="app">The <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" /> instance.</param>
		/// <param name="pathMatch">The request path to match.</param>
		/// <param name="preserveMatchedPathSegment">if false, matched path would be removed from Request.Path and added to Request.PathBase.</param>
		/// <param name="configuration">The branch to take for positive path matches.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" /> instance.</returns>
		public static IApplicationBuilder Map(this IApplicationBuilder app, PathString pathMatch, bool preserveMatchedPathSegment, Action<IApplicationBuilder> configuration)
		{
			throw null;
		}
	}
}
