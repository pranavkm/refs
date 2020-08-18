using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Identity
{
	/// <summary>
	/// Options for <see cref="T:Microsoft.AspNetCore.Identity.ISecurityStampValidator" />.
	/// </summary>
	public class SecurityStampValidatorOptions
	{
		/// <summary>
		/// Gets or sets the <see cref="T:System.TimeSpan" /> after which security stamps are re-validated. Defaults to 30 minutes.
		/// </summary>
		/// <value>
		/// The <see cref="T:System.TimeSpan" /> after which security stamps are re-validated.
		/// </value>
		public TimeSpan ValidationInterval
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
		/// Invoked when the default security stamp validator replaces the user's ClaimsPrincipal in the cookie.
		/// </summary>
		public Func<SecurityStampRefreshingPrincipalContext, Task> OnRefreshingPrincipal
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

		public SecurityStampValidatorOptions()
		{
			throw null;
		}
	}
}
