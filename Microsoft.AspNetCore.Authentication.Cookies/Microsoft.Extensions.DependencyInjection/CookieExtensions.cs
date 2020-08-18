using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
	public static class CookieExtensions
	{
		public static AuthenticationBuilder AddCookie(this AuthenticationBuilder builder)
		{
			throw null;
		}

		public static AuthenticationBuilder AddCookie(this AuthenticationBuilder builder, string authenticationScheme)
		{
			throw null;
		}

		public static AuthenticationBuilder AddCookie(this AuthenticationBuilder builder, Action<CookieAuthenticationOptions>? configureOptions)
		{
			throw null;
		}

		public static AuthenticationBuilder AddCookie(this AuthenticationBuilder builder, string authenticationScheme, Action<CookieAuthenticationOptions>? configureOptions)
		{
			throw null;
		}

		public static AuthenticationBuilder AddCookie(this AuthenticationBuilder builder, string authenticationScheme, string? displayName, Action<CookieAuthenticationOptions>? configureOptions)
		{
			throw null;
		}
	}
}
