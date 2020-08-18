using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Security.Claims;

namespace Microsoft.AspNetCore.Authentication
{
	/// <summary>
	/// Contains the result of an Authenticate call
	/// </summary>
	public class AuthenticateResult
	{
		/// <summary>
		/// If a ticket was produced, authenticate was successful.
		/// </summary>
		[MemberNotNullWhen(true, "Ticket")]
		public bool Succeeded
		{
			[MemberNotNullWhen(true, "Ticket")]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// The authentication ticket.
		/// </summary>
		public AuthenticationTicket? Ticket
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			protected set
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the claims-principal with authenticated user identities.
		/// </summary>
		public ClaimsPrincipal? Principal
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Additional state values for the authentication session.
		/// </summary>
		public AuthenticationProperties? Properties
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			protected set
			{
				throw null;
			}
		}

		/// <summary>
		/// Holds failure information from the authentication.
		/// </summary>
		public Exception? Failure
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			protected set
			{
				throw null;
			}
		}

		/// <summary>
		/// Indicates that there was no information returned for this authentication scheme.
		/// </summary>
		public bool None
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			protected set
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates a new <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticateResult" /> instance.
		/// </summary>
		protected AuthenticateResult()
		{
			throw null;
		}

		/// <summary>
		/// Create a new deep copy of the result
		/// </summary>
		/// <returns>A copy of the result</returns>
		public AuthenticateResult Clone()
		{
			throw null;
		}

		/// <summary>
		/// Indicates that authentication was successful.
		/// </summary>
		/// <param name="ticket">The ticket representing the authentication result.</param>
		/// <returns>The result.</returns>
		public static AuthenticateResult Success(AuthenticationTicket ticket)
		{
			throw null;
		}

		/// <summary>
		/// Indicates that there was no information returned for this authentication scheme.
		/// </summary>
		/// <returns>The result.</returns>
		public static AuthenticateResult NoResult()
		{
			throw null;
		}

		/// <summary>
		/// Indicates that there was a failure during authentication.
		/// </summary>
		/// <param name="failure">The failure exception.</param>
		/// <returns>The result.</returns>
		public static AuthenticateResult Fail(Exception? failure)
		{
			throw null;
		}

		/// <summary>
		/// Indicates that there was a failure during authentication.
		/// </summary>
		/// <param name="failure">The failure exception.</param>
		/// <param name="properties">Additional state values for the authentication session.</param>
		/// <returns>The result.</returns>
		public static AuthenticateResult Fail(Exception? failure, AuthenticationProperties? properties)
		{
			throw null;
		}

		/// <summary>
		/// Indicates that there was a failure during authentication.
		/// </summary>
		/// <param name="failureMessage">The failure message.</param>
		/// <returns>The result.</returns>
		public static AuthenticateResult Fail(string? failureMessage)
		{
			throw null;
		}

		/// <summary>
		/// Indicates that there was a failure during authentication.
		/// </summary>
		/// <param name="failureMessage">The failure message.</param>
		/// <param name="properties">Additional state values for the authentication session.</param>
		/// <returns>The result.</returns>
		public static AuthenticateResult Fail(string? failureMessage, AuthenticationProperties? properties)
		{
			throw null;
		}
	}
}
