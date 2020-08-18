using Microsoft.AspNetCore.Http.Connections;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
	/// <summary>
	/// Extension methods for <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.
	/// </summary>
	public static class ConnectionsDependencyInjectionExtensions
	{
		/// <summary>
		/// Adds required services for ASP.NET Core Connection Handlers to the specified <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.
		/// </summary>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> to add services to.</param>
		/// <returns>The same instance of the <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> for chaining.</returns>
		public static IServiceCollection AddConnections(this IServiceCollection services)
		{
			throw null;
		}

		/// <summary>
		/// Adds required services for ASP.NET Core Connection Handlers to the specified <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.
		/// </summary>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> to add services to.</param>
		/// <param name="options">A callback to configure  <see cref="T:Microsoft.AspNetCore.Http.Connections.ConnectionOptions" /></param>
		/// <returns>The same instance of the <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> for chaining.</returns>
		public static IServiceCollection AddConnections(this IServiceCollection services, Action<ConnectionOptions> options)
		{
			throw null;
		}
	}
}
