using Microsoft.AspNetCore.Authentication;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
	/// <summary>
	/// Extension methods for setting up authentication services in an <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.
	/// </summary>
	public static class AuthenticationCoreServiceCollectionExtensions
	{
		/// <summary>
		/// Add core authentication services needed for <see cref="T:Microsoft.AspNetCore.Authentication.IAuthenticationService" />.
		/// </summary>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.</param>
		/// <returns>The service collection.</returns>
		public static IServiceCollection AddAuthenticationCore(this IServiceCollection services)
		{
			throw null;
		}

		/// <summary>
		/// Add core authentication services needed for <see cref="T:Microsoft.AspNetCore.Authentication.IAuthenticationService" />.
		/// </summary>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.</param>
		/// <param name="configureOptions">Used to configure the <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationOptions" />.</param>
		/// <returns>The service collection.</returns>
		public static IServiceCollection AddAuthenticationCore(this IServiceCollection services, Action<AuthenticationOptions> configureOptions)
		{
			throw null;
		}
	}
}
