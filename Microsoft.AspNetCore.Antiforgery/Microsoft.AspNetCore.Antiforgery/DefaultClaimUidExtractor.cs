using Microsoft.Extensions.ObjectPool;
using System.Collections.Generic;
using System.Security.Claims;

namespace Microsoft.AspNetCore.Antiforgery
{
	/// <summary>
	/// Default implementation of <see cref="T:Microsoft.AspNetCore.Antiforgery.IClaimUidExtractor" />.
	/// </summary>
	internal class DefaultClaimUidExtractor : IClaimUidExtractor
	{
		public DefaultClaimUidExtractor(ObjectPool<AntiforgerySerializationContext> pool)
		{
			throw null;
		}

		/// <inheritdoc />
		public string? ExtractClaimUid(ClaimsPrincipal claimsPrincipal)
		{
			throw null;
		}

		public static IList<string>? GetUniqueIdentifierParameters(IEnumerable<ClaimsIdentity> claimsIdentities)
		{
			throw null;
		}
	}
}
