using System.Runtime.CompilerServices;
using System.Security.Claims;

namespace Microsoft.AspNetCore.Authentication
{
	/// <summary>
	/// Contains user identity information as well as additional authentication state.
	/// </summary>
	public class AuthenticationTicket
	{
		/// <summary>
		/// Gets the authentication type.
		/// </summary>
		public string AuthenticationScheme
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the claims-principal with authenticated user identities.
		/// </summary>
		public ClaimsPrincipal Principal
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Additional state values for the authentication session.
		/// </summary>
		public AuthenticationProperties Properties
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationTicket" /> class
		/// </summary>
		/// <param name="principal">the <see cref="T:System.Security.Claims.ClaimsPrincipal" /> that represents the authenticated user.</param>
		/// <param name="properties">additional properties that can be consumed by the user or runtime.</param>
		/// <param name="authenticationScheme">the authentication middleware that was responsible for this ticket.</param>
		public AuthenticationTicket(ClaimsPrincipal principal, AuthenticationProperties? properties, string authenticationScheme)
		{
			throw null;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationTicket" /> class
		/// </summary>
		/// <param name="principal">the <see cref="T:System.Security.Claims.ClaimsPrincipal" /> that represents the authenticated user.</param>
		/// <param name="authenticationScheme">the authentication middleware that was responsible for this ticket.</param>
		public AuthenticationTicket(ClaimsPrincipal principal, string authenticationScheme)
		{
			throw null;
		}

		/// <summary>
		/// Returns a copy of the ticket.
		/// Note: the claims principal will be cloned by calling Clone() on each of the Identities.
		/// </summary>
		/// <returns>A copy of the ticket</returns>
		public AuthenticationTicket Clone()
		{
			throw null;
		}
	}
}
