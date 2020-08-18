using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Authorization
{
	/// <summary>
	/// Encapsulates the result of <see cref="M:Microsoft.AspNetCore.Authorization.IAuthorizationService.AuthorizeAsync(System.Security.Claims.ClaimsPrincipal,System.Object,System.Collections.Generic.IEnumerable{Microsoft.AspNetCore.Authorization.IAuthorizationRequirement})" />.
	/// </summary>
	public class AuthorizationResult
	{
		/// <summary>
		/// True if authorization was successful.
		/// </summary>
		public bool Succeeded
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Contains information about why authorization failed.
		/// </summary>
		public AuthorizationFailure? Failure
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Returns a successful result.
		/// </summary>
		/// <returns>A successful result.</returns>
		public static AuthorizationResult Success()
		{
			throw null;
		}

		public static AuthorizationResult Failed(AuthorizationFailure failure)
		{
			throw null;
		}

		public static AuthorizationResult Failed()
		{
			throw null;
		}
	}
}
