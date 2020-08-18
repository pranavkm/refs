using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Authentication
{
	/// <summary>
	/// Used to configure authentication
	/// </summary>
	public class AuthenticationBuilder
	{
		private class EnsureSignInScheme<TOptions> : IPostConfigureOptions<TOptions> where TOptions : RemoteAuthenticationOptions
		{
			public EnsureSignInScheme(IOptions<AuthenticationOptions> authOptions)
			{
				throw null;
			}

			public void PostConfigure(string name, TOptions options)
			{
				throw null;
			}
		}

		/// <summary>
		/// The services being configured.
		/// </summary>
		public virtual IServiceCollection Services
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="services">The services being configured.</param>
		public AuthenticationBuilder(IServiceCollection services)
		{
			throw null;
		}

		/// <summary>
		/// Adds a <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationScheme" /> which can be used by <see cref="T:Microsoft.AspNetCore.Authentication.IAuthenticationService" />.
		/// </summary>
		/// <typeparam name="TOptions">The <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationSchemeOptions" /> type to configure the handler."/&gt;.</typeparam>
		/// <typeparam name="THandler">The <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationHandler`1" /> used to handle this scheme.</typeparam>
		/// <param name="authenticationScheme">The name of this scheme.</param>
		/// <param name="displayName">The display name of this scheme.</param>
		/// <param name="configureOptions">Used to configure the scheme options.</param>
		/// <returns>The builder.</returns>
		public virtual AuthenticationBuilder AddScheme<TOptions, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] THandler>(string authenticationScheme, string? displayName, Action<TOptions>? configureOptions) where TOptions : AuthenticationSchemeOptions, new()where THandler : AuthenticationHandler<TOptions>
		{
			throw null;
		}

		/// <summary>
		/// Adds a <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationScheme" /> which can be used by <see cref="T:Microsoft.AspNetCore.Authentication.IAuthenticationService" />.
		/// </summary>
		/// <typeparam name="TOptions">The <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationSchemeOptions" /> type to configure the handler."/&gt;.</typeparam>
		/// <typeparam name="THandler">The <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationHandler`1" /> used to handle this scheme.</typeparam>
		/// <param name="authenticationScheme">The name of this scheme.</param>
		/// <param name="configureOptions">Used to configure the scheme options.</param>
		/// <returns>The builder.</returns>
		public virtual AuthenticationBuilder AddScheme<TOptions, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] THandler>(string authenticationScheme, Action<TOptions>? configureOptions) where TOptions : AuthenticationSchemeOptions, new()where THandler : AuthenticationHandler<TOptions>
		{
			throw null;
		}

		/// <summary>
		/// Adds a <see cref="T:Microsoft.AspNetCore.Authentication.RemoteAuthenticationHandler`1" /> based <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationScheme" /> that supports remote authentication
		/// which can be used by <see cref="T:Microsoft.AspNetCore.Authentication.IAuthenticationService" />.
		/// </summary>
		/// <typeparam name="TOptions">The <see cref="T:Microsoft.AspNetCore.Authentication.RemoteAuthenticationOptions" /> type to configure the handler."/&gt;.</typeparam>
		/// <typeparam name="THandler">The <see cref="T:Microsoft.AspNetCore.Authentication.RemoteAuthenticationHandler`1" /> used to handle this scheme.</typeparam>
		/// <param name="authenticationScheme">The name of this scheme.</param>
		/// <param name="displayName">The display name of this scheme.</param>
		/// <param name="configureOptions">Used to configure the scheme options.</param>
		/// <returns>The builder.</returns>
		public virtual AuthenticationBuilder AddRemoteScheme<TOptions, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] THandler>(string authenticationScheme, string? displayName, Action<TOptions>? configureOptions) where TOptions : RemoteAuthenticationOptions, new()where THandler : RemoteAuthenticationHandler<TOptions>
		{
			throw null;
		}

		/// <summary>
		/// Adds a <see cref="T:Microsoft.AspNetCore.Authentication.PolicySchemeHandler" /> based authentication handler which can be used to 
		/// redirect to other authentication schemes.
		/// </summary>
		/// <param name="authenticationScheme">The name of this scheme.</param>
		/// <param name="displayName">The display name of this scheme.</param>
		/// <param name="configureOptions">Used to configure the scheme options.</param>
		/// <returns>The builder.</returns>
		public virtual AuthenticationBuilder AddPolicyScheme(string authenticationScheme, string? displayName, Action<PolicySchemeOptions> configureOptions)
		{
			throw null;
		}
	}
}
