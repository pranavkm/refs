using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.SignalR.Protocol
{
	/// <summary>
	/// A hub message representing a non-streaming invocation.
	/// </summary>
	public class InvocationMessage : HubMethodInvocationMessage
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.SignalR.Protocol.InvocationMessage" /> class.
		/// </summary>
		/// <param name="target">The target method name.</param>
		/// <param name="arguments">The target method arguments.</param>
		public InvocationMessage(string target, object?[]? arguments)
		{
			throw null;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.SignalR.Protocol.InvocationMessage" /> class.
		/// </summary>
		/// <param name="invocationId">The invocation ID.</param>
		/// <param name="target">The target method name.</param>
		/// <param name="arguments">The target method arguments.</param>
		[System.Runtime.CompilerServices.NullableContext(2)]
		public InvocationMessage(string? invocationId, string target, object?[]? arguments)
		{
			throw null;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.SignalR.Protocol.InvocationMessage" /> class.
		/// </summary>
		/// <param name="invocationId">The invocation ID.</param>
		/// <param name="target">The target method name.</param>
		/// <param name="arguments">The target method arguments.</param>
		/// <param name="streamIds">The target methods stream IDs.</param>
		[System.Runtime.CompilerServices.NullableContext(2)]
		public InvocationMessage(string? invocationId, string target, object?[]? arguments, string[]? streamIds)
		{
			throw null;
		}

		/// <inheritdoc />
		public override string ToString()
		{
			throw null;
		}
	}
}
