using Microsoft.AspNetCore.Http;
using System;

namespace Microsoft.AspNetCore.Builder
{
	/// <summary>
	/// Extension methods for <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" />.
	/// </summary>
	public static class UseWhenExtensions
	{
		/// <summary>
		/// Conditionally creates a branch in the request pipeline that is rejoined to the main pipeline.
		/// </summary>
		/// <param name="app"></param>
		/// <param name="predicate">Invoked with the request environment to determine if the branch should be taken</param>
		/// <param name="configuration">Configures a branch to take</param>
		/// <returns></returns>
		public static IApplicationBuilder UseWhen(this IApplicationBuilder app, Func<HttpContext, bool> predicate, Action<IApplicationBuilder> configuration)
		{
			throw null;
		}
	}
}
