using Microsoft.AspNetCore.Http;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Authentication
{
	/// <summary>
	/// Provides context information to handler providers.
	/// </summary>
	public class TicketReceivedContext : RemoteAuthenticationContext<RemoteAuthenticationOptions>
	{
		public string? ReturnUri
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
		public TicketReceivedContext(HttpContext context, AuthenticationScheme scheme, RemoteAuthenticationOptions options, AuthenticationTicket ticket)
		{
			throw null;
		}
	}
}
