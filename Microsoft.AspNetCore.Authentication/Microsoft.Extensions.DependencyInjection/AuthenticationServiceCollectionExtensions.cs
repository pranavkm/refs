using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
	/// <summary>
	/// Extension methods for setting up authentication services in an <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.
	/// </summary>
	public static class AuthenticationServiceCollectionExtensions
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

		public static AuthenticationBuilder AddAuthentication(this IServiceCollection services)
		{
			throw null;
		}

		public static AuthenticationBuilder AddAuthentication(this IServiceCollection services, string defaultScheme)
		{
			throw null;
		}

		public static AuthenticationBuilder AddAuthentication(this IServiceCollection services, Action<AuthenticationOptions> configureOptions)
		{
			throw null;
		}
	}
}
