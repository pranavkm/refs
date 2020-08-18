using Microsoft.AspNetCore.Http;
using System;

namespace Microsoft.AspNetCore.Builder
{
	/// <summary>
	/// Extension methods for the <see cref="T:Microsoft.AspNetCore.Builder.Extensions.MapWhenMiddleware" />.
	/// </summary>
	public static class MapWhenExtensions
	{
		/// <summary>
		/// Branches the request pipeline based on the result of the given predicate.
		/// </summary>
		/// <param name="app"></param>
		/// <param name="predicate">Invoked with the request environment to determine if the branch should be taken</param>
		/// <param name="configuration">Configures a branch to take</param>
		/// <returns></returns>
		public static IApplicationBuilder MapWhen(this IApplicationBuilder app, Func<HttpContext, bool> predicate, Action<IApplicationBuilder> configuration)
		{
			throw null;
		}
	}
}
