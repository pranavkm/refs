using System;

namespace Microsoft.AspNetCore.Builder
{
	public static class ExceptionHandlerExtensions
	{
		/// <summary>
		/// Adds a middleware to the pipeline that will catch exceptions, log them, and re-execute the request in an alternate pipeline.
		/// The request will not be re-executed if the response has already started.
		/// </summary>
		/// <param name="app"></param>
		/// <returns></returns>
		public static IApplicationBuilder UseExceptionHandler(this IApplicationBuilder app)
		{
			throw null;
		}

		/// <summary>
		/// Adds a middleware to the pipeline that will catch exceptions, log them, reset the request path, and re-execute the request.
		/// The request will not be re-executed if the response has already started.
		/// </summary>
		/// <param name="app"></param>
		/// <param name="errorHandlingPath"></param>
		/// <returns></returns>
		public static IApplicationBuilder UseExceptionHandler(this IApplicationBuilder app, string errorHandlingPath)
		{
			throw null;
		}

		/// <summary>
		/// Adds a middleware to the pipeline that will catch exceptions, log them, and re-execute the request in an alternate pipeline.
		/// The request will not be re-executed if the response has already started.
		/// </summary>
		/// <param name="app"></param>
		/// <param name="configure"></param>
		/// <returns></returns>
		public static IApplicationBuilder UseExceptionHandler(this IApplicationBuilder app, Action<IApplicationBuilder> configure)
		{
			throw null;
		}

		/// <summary>
		/// Adds a middleware to the pipeline that will catch exceptions, log them, and re-execute the request in an alternate pipeline.
		/// The request will not be re-executed if the response has already started.
		/// </summary>
		/// <param name="app"></param>
		/// <param name="options"></param>
		/// <returns></returns>
		public static IApplicationBuilder UseExceptionHandler(this IApplicationBuilder app, ExceptionHandlerOptions options)
		{
			throw null;
		}
	}
}
