using Microsoft.AspNetCore.Builder;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
	/// <summary>
	/// Extension methods for the exception handler middleware.
	/// </summary>
	public static class ExceptionHandlerServiceCollectionExtensions
	{
		/// <summary>
		/// Adds services and options for the exception handler middleware.
		/// </summary>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> for adding services.</param>
		/// <param name="configureOptions">A delegate to configure the <see cref="T:Microsoft.AspNetCore.Builder.ExceptionHandlerOptions" />.</param>
		/// <returns></returns>
		public static IServiceCollection AddExceptionHandler(this IServiceCollection services, Action<ExceptionHandlerOptions> configureOptions)
		{
			throw null;
		}

		/// <summary>
		/// Adds services and options for the exception handler middleware.
		/// </summary>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> for adding services.</param>
		/// <param name="configureOptions">A delegate to configure the <see cref="T:Microsoft.AspNetCore.Builder.ExceptionHandlerOptions" />.</param>
		/// <returns></returns>
		public static IServiceCollection AddExceptionHandler<TService>(this IServiceCollection services, Action<ExceptionHandlerOptions, TService> configureOptions) where TService : class
		{
			throw null;
		}
	}
}
