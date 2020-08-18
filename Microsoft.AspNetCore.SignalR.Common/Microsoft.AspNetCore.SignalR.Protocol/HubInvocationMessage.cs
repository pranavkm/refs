using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.SignalR.Protocol
{
	/// <summary>
	/// A base class for hub messages related to a specific invocation.
	/// </summary>
	public abstract class HubInvocationMessage : HubMessage
	{
		/// <summary>
		/// Gets or sets a name/value collection of headers.
		/// </summary>
		public IDictionary<string, string>? Headers
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
		/// Gets the invocation ID.
		/// </summary>
		public string? InvocationId
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.SignalR.Protocol.HubInvocationMessage" /> class.
		/// </summary>
		/// <param name="invocationId">The invocation ID.</param>
		protected HubInvocationMessage(string? invocationId)
		{
			throw null;
		}
	}
}
