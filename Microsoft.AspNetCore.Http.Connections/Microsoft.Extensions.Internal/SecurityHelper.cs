using System.Security.Claims;

namespace Microsoft.Extensions.Internal
{
	/// <summary>
	/// Helper code used when implementing authentication middleware
	/// </summary>
	internal static class SecurityHelper
	{
		/// <summary>
		/// Add all ClaimsIdentities from an additional ClaimPrincipal to the ClaimsPrincipal
		/// Merges a new claims principal, placing all new identities first, and eliminating
		/// any empty unauthenticated identities from context.User
		/// </summary>
		/// <param name="existingPrincipal">The <see cref="T:System.Security.Claims.ClaimsPrincipal" /> containing existing <see cref="T:System.Security.Claims.ClaimsIdentity" />.</param>
		/// <param name="additionalPrincipal">The <see cref="T:System.Security.Claims.ClaimsPrincipal" /> containing <see cref="T:System.Security.Claims.ClaimsIdentity" /> to be added.</param>
		public static ClaimsPrincipal MergeUserPrincipal(ClaimsPrincipal? existingPrincipal, ClaimsPrincipal? additionalPrincipal)
		{
			throw null;
		}
	}
}
