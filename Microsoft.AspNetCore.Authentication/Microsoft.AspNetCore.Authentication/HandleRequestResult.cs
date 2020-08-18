using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Authentication
{
	/// <summary>
	/// Contains the result of an Authenticate call
	/// </summary>
	public class HandleRequestResult : AuthenticateResult
	{
		/// <summary>
		/// Indicates that stage of authentication was directly handled by
		/// user intervention and no further processing should be attempted.
		/// </summary>
		public bool Handled
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Indicates that the default authentication logic should be
		/// skipped and that the rest of the pipeline should be invoked.
		/// </summary>
		public bool Skipped
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Indicates that authentication was successful.
		/// </summary>
		/// <param name="ticket">The ticket representing the authentication result.</param>
		/// <returns>The result.</returns>
		public new static HandleRequestResult Success(AuthenticationTicket ticket)
		{
			throw null;
		}

		/// <summary>
		/// Indicates that there was a failure during authentication.
		/// </summary>
		/// <param name="failure">The failure exception.</param>
		/// <returns>The result.</returns>
		public new static HandleRequestResult Fail(Exception failure)
		{
			throw null;
		}

		/// <summary>
		/// Indicates that there was a failure during authentication.
		/// </summary>
		/// <param name="failure">The failure exception.</param>
		/// <param name="properties">Additional state values for the authentication session.</param>
		/// <returns>The result.</returns>
		public new static HandleRequestResult Fail(Exception failure, AuthenticationProperties properties)
		{
			throw null;
		}

		/// <summary>
		/// Indicates that there was a failure during authentication.
		/// </summary>
		/// <param name="failureMessage">The failure message.</param>
		/// <returns>The result.</returns>
		public new static HandleRequestResult Fail(string failureMessage)
		{
			throw null;
		}

		/// <summary>
		/// Indicates that there was a failure during authentication.
		/// </summary>
		/// <param name="failureMessage">The failure message.</param>
		/// <param name="properties">Additional state values for the authentication session.</param>
		/// <returns>The result.</returns>
		public new static HandleRequestResult Fail(string failureMessage, AuthenticationProperties properties)
		{
			throw null;
		}

		/// <summary>
		/// Discontinue all processing for this request and return to the client.
		/// The caller is responsible for generating the full response.
		/// </summary>
		/// <returns>The result.</returns>
		public static HandleRequestResult Handle()
		{
			throw null;
		}

		/// <summary>
		/// Discontinue processing the request in the current handler.
		/// </summary>
		/// <returns>The result.</returns>
		public static HandleRequestResult SkipHandler()
		{
			throw null;
		}

		public new static HandleRequestResult NoResult()
		{
			throw null;
		}

		public HandleRequestResult()
		{
			throw null;
		}
	}
}
