using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Server.HttpSys
{
	/// <summary>
	/// Exposes the Http.Sys authentication configurations.
	/// </summary>
	public sealed class AuthenticationManager
	{
		/// <summary>
		/// When attaching to an existing queue this setting must match the one used to create the queue.
		/// </summary>
		public AuthenticationSchemes Schemes
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Indicates if anonymous requests will be surfaced to the application or challenged by the server.
		/// The default value is true.
		/// </summary>
		public bool AllowAnonymous
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// If true the server should set HttpContext.User. If false the server will only provide an
		/// identity when explicitly requested by the AuthenticationScheme. The default is true.
		/// </summary>
		public bool AutomaticAuthentication
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
		/// Sets the display name shown to users on login pages. The default is null.
		/// </summary> 
		public string AuthenticationDisplayName
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

		internal AuthenticationManager()
		{
			throw null;
		}

		internal void SetUrlGroupSecurity(UrlGroup urlGroup)
		{
			throw null;
		}

		internal static IList<string> GenerateChallenges(AuthenticationSchemes authSchemes)
		{
			throw null;
		}

		internal void SetAuthenticationChallenge(RequestContext context)
		{
			throw null;
		}
	}
}
