using Microsoft.AspNetCore.Http;
using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Authentication
{
	/// <summary>
	/// Provides failure context information to handler providers.
	/// </summary>
	public class RemoteFailureContext : HandleRequestContext<RemoteAuthenticationOptions>
	{
		/// <summary>
		/// User friendly error message for the error.
		/// </summary>
		public Exception? Failure
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
			set
			{
				throw null;
			}
		}

		[System.Runtime.CompilerServices.NullableContext(1)]
		public RemoteFailureContext(HttpContext context, AuthenticationScheme scheme, RemoteAuthenticationOptions options, Exception failure)
		{
			throw null;
		}
	}
}
