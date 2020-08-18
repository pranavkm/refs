using System.Runtime.CompilerServices;
using System.Security.Claims;

namespace Microsoft.AspNetCore.Identity
{
	/// <summary>
	/// Used to pass information during the SecurityStamp validation event.
	/// </summary>
	public class SecurityStampRefreshingPrincipalContext
	{
		/// <summary>
		/// The principal contained in the current cookie.
		/// </summary>
		public ClaimsPrincipal CurrentPrincipal
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
		/// The new principal which should replace the current.
		/// </summary>
		public ClaimsPrincipal NewPrincipal
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

		public SecurityStampRefreshingPrincipalContext()
		{
			throw null;
		}
	}
}
