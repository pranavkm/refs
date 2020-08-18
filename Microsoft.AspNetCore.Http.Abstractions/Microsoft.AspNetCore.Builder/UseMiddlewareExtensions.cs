using System;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.AspNetCore.Builder
{
	/// <summary>
	/// Extension methods for adding typed middleware.
	/// </summary>
	public static class UseMiddlewareExtensions
	{
		internal const string InvokeMethodName = "Invoke";

		internal const string InvokeAsyncMethodName = "InvokeAsync";

		/// <summary>
		/// Adds a middleware type to the application's request pipeline.
		/// </summary>
		/// <typeparam name="TMiddleware">The middleware type.</typeparam>
		/// <param name="app">The <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" /> instance.</param>
		/// <param name="args">The arguments to pass to the middleware type instance's constructor.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" /> instance.</returns>
		public static IApplicationBuilder UseMiddleware<[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)11)] TMiddleware>(this IApplicationBuilder app, params object[] args)
		{
			throw null;
		}

		/// <summary>
		/// Adds a middleware type to the application's request pipeline.
		/// </summary>
		/// <param name="app">The <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" /> instance.</param>
		/// <param name="middleware">The middleware type.</param>
		/// <param name="args">The arguments to pass to the middleware type instance's constructor.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" /> instance.</returns>
		public static IApplicationBuilder UseMiddleware(this IApplicationBuilder app, [DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)11)] Type middleware, params object[] args)
		{
			throw null;
		}
	}
}
