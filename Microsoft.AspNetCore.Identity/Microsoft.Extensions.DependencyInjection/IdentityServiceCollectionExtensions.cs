using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
	/// <summary>
	/// Contains extension methods to <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> for configuring identity services.
	/// </summary>
	public static class IdentityServiceCollectionExtensions
	{
		/// <summary>
		/// Adds the default identity system configuration for the specified User and Role types.
		/// </summary>
		/// <typeparam name="TUser">The type representing a User in the system.</typeparam>
		/// <typeparam name="TRole">The type representing a Role in the system.</typeparam>
		/// <param name="services">The services available in the application.</param>
		/// <returns>An <see cref="T:Microsoft.AspNetCore.Identity.IdentityBuilder" /> for creating and configuring the identity system.</returns>
		public static IdentityBuilder AddIdentity<TUser, TRole>(this IServiceCollection services) where TUser : class where TRole : class
		{
			throw null;
		}

		/// <summary>
		/// Adds and configures the identity system for the specified User and Role types.
		/// </summary>
		/// <typeparam name="TUser">The type representing a User in the system.</typeparam>
		/// <typeparam name="TRole">The type representing a Role in the system.</typeparam>
		/// <param name="services">The services available in the application.</param>
		/// <param name="setupAction">An action to configure the <see cref="T:Microsoft.AspNetCore.Identity.IdentityOptions" />.</param>
		/// <returns>An <see cref="T:Microsoft.AspNetCore.Identity.IdentityBuilder" /> for creating and configuring the identity system.</returns>
		public static IdentityBuilder AddIdentity<TUser, TRole>(this IServiceCollection services, Action<IdentityOptions> setupAction) where TUser : class where TRole : class
		{
			throw null;
		}

		/// <summary>
		/// Configures the application cookie.
		/// </summary>
		/// <param name="services">The services available in the application.</param>
		/// <param name="configure">An action to configure the <see cref="T:Microsoft.AspNetCore.Authentication.Cookies.CookieAuthenticationOptions" />.</param>
		/// <returns>The services.</returns>
		public static IServiceCollection ConfigureApplicationCookie(this IServiceCollection services, Action<CookieAuthenticationOptions> configure)
		{
			throw null;
		}

		/// <summary>
		/// Configure the external cookie.
		/// </summary>
		/// <param name="services">The services available in the application.</param>
		/// <param name="configure">An action to configure the <see cref="T:Microsoft.AspNetCore.Authentication.Cookies.CookieAuthenticationOptions" />.</param>
		/// <returns>The services.</returns>
		public static IServiceCollection ConfigureExternalCookie(this IServiceCollection services, Action<CookieAuthenticationOptions> configure)
		{
			throw null;
		}
	}
}
