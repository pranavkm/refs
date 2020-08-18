using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.SignalR.Protocol
{
	/// <summary>
	/// A base class for hub messages representing an invocation.
	/// </summary>
	public abstract class HubMethodInvocationMessage : HubInvocationMessage
	{
		/// <summary>
		/// Gets the target method name.
		/// </summary>
		public string Target
		{
			[System.Runtime.CompilerServices.NullableContext(1)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the target method arguments.
		/// </summary>
		public object?[]? Arguments
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// The target methods stream IDs.
		/// </summary>
		public string[]? StreamIds
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.SignalR.Protocol.HubMethodInvocationMessage" /> class.
		/// </summary>
		/// <param name="invocationId">The invocation ID.</param>
		/// <param name="target">The target method name.</param>
		/// <param name="arguments">The target method arguments.</param>
		/// <param name="streamIds">The target methods stream IDs.</param>
		protected HubMethodInvocationMessage(string? invocationId, string target, object?[]? arguments, string[]? streamIds)
		{
			throw null;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.SignalR.Protocol.HubMethodInvocationMessage" /> class.
		/// </summary>
		/// <param name="invocationId">The invocation ID.</param>
		/// <param name="target">The target method name.</param>
		/// <param name="arguments">The target method arguments.</param>
		protected HubMethodInvocationMessage(string? invocationId, string target, object?[]? arguments)
		{
			throw null;
		}
	}
}
