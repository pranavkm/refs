using Microsoft.AspNetCore.Http;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Authentication
{
	/// <summary>
	/// Used to capture path info so redirects can be computed properly within an app.Map().
	/// </summary>
	public class AuthenticationFeature : IAuthenticationFeature
	{
		/// <summary>
		/// The original path base.
		/// </summary>
		public PathString OriginalPathBase
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
		/// The original path.
		/// </summary>
		public PathString OriginalPath
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

		public AuthenticationFeature()
		{
			throw null;
		}
	}
}
