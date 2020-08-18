using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Authentication
{
	public class AuthenticationOptions
	{
		/// <summary>
		/// Returns the schemes in the order they were added (important for request handling priority)
		/// </summary>
		public IEnumerable<AuthenticationSchemeBuilder> Schemes
		{
			[System.Runtime.CompilerServices.NullableContext(1)]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Maps schemes by name.
		/// </summary>
		public IDictionary<string, AuthenticationSchemeBuilder> SchemeMap
		{
			[System.Runtime.CompilerServices.NullableContext(1)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Used as the fallback default scheme for all the other defaults.
		/// </summary>
		public string? DefaultScheme
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Used as the default scheme by <see cref="M:Microsoft.AspNetCore.Authentication.IAuthenticationService.AuthenticateAsync(Microsoft.AspNetCore.Http.HttpContext,System.String)" />.
		/// </summary>
		public string? DefaultAuthenticateScheme
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Used as the default scheme by <see cref="M:Microsoft.AspNetCore.Authentication.IAuthenticationService.SignInAsync(Microsoft.AspNetCore.Http.HttpContext,System.String,System.Security.Claims.ClaimsPrincipal,Microsoft.AspNetCore.Authentication.AuthenticationProperties)" />.
		/// </summary>
		public string? DefaultSignInScheme
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Used as the default scheme by <see cref="M:Microsoft.AspNetCore.Authentication.IAuthenticationService.SignOutAsync(Microsoft.AspNetCore.Http.HttpContext,System.String,Microsoft.AspNetCore.Authentication.AuthenticationProperties)" />.
		/// </summary>
		public string? DefaultSignOutScheme
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Used as the default scheme by <see cref="M:Microsoft.AspNetCore.Authentication.IAuthenticationService.ChallengeAsync(Microsoft.AspNetCore.Http.HttpContext,System.String,Microsoft.AspNetCore.Authentication.AuthenticationProperties)" />.
		/// </summary>
		public string? DefaultChallengeScheme
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Used as the default scheme by <see cref="M:Microsoft.AspNetCore.Authentication.IAuthenticationService.ForbidAsync(Microsoft.AspNetCore.Http.HttpContext,System.String,Microsoft.AspNetCore.Authentication.AuthenticationProperties)" />.
		/// </summary>
		public string? DefaultForbidScheme
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// If true, SignIn should throw if attempted with a ClaimsPrincipal.Identity.IsAuthenticated = false.
		/// </summary>
		public bool RequireAuthenticatedSignIn
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Adds an <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationScheme" />.
		/// </summary>
		/// <param name="name">The name of the scheme being added.</param>
		/// <param name="configureBuilder">Configures the scheme.</param>
		public void AddScheme(string name, Action<AuthenticationSchemeBuilder> configureBuilder)
		{
			throw null;
		}

		/// <summary>
		/// Adds an <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationScheme" />.
		/// </summary>
		/// <typeparam name="THandler">The <see cref="T:Microsoft.AspNetCore.Authentication.IAuthenticationHandler" /> responsible for the scheme.</typeparam>
		/// <param name="name">The name of the scheme being added.</param>
		/// <param name="displayName">The display name for the scheme.</param>
		public void AddScheme<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] THandler>(string name, string displayName) where THandler : IAuthenticationHandler
		{
			throw null;
		}

		public AuthenticationOptions()
		{
			throw null;
		}
	}
}
