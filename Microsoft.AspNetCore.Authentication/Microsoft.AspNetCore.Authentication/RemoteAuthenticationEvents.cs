using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Authentication
{
	public class RemoteAuthenticationEvents
	{
		public Func<AccessDeniedContext, Task> OnAccessDenied
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

		public Func<RemoteFailureContext, Task> OnRemoteFailure
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

		public Func<TicketReceivedContext, Task> OnTicketReceived
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
		/// Invoked when an access denied error was returned by the remote server.
		/// </summary>
		public virtual Task AccessDenied(AccessDeniedContext context)
		{
			throw null;
		}

		/// <summary>
		/// Invoked when there is a remote failure.
		/// </summary>
		public virtual Task RemoteFailure(RemoteFailureContext context)
		{
			throw null;
		}

		/// <summary>
		/// Invoked after the remote ticket has been received.
		/// </summary>
		public virtual Task TicketReceived(TicketReceivedContext context)
		{
			throw null;
		}

		public RemoteAuthenticationEvents()
		{
			throw null;
		}
	}
}
