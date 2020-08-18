namespace Microsoft.AspNetCore.SignalR.Protocol
{
	/// <summary>
	/// A hub message representing a streaming invocation.
	/// </summary>
	public class StreamInvocationMessage : HubMethodInvocationMessage
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.SignalR.Protocol.StreamInvocationMessage" /> class.
		/// </summary>
		/// <param name="invocationId">The invocation ID.</param>
		/// <param name="target">The target method name.</param>
		/// <param name="arguments">The target method arguments.</param>
		public StreamInvocationMessage(string invocationId, string target, object[] arguments)
		{
			throw null;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.SignalR.Protocol.StreamInvocationMessage" /> class.
		/// </summary>
		/// <param name="invocationId">The invocation ID.</param>
		/// <param name="target">The target method name.</param>
		/// <param name="arguments">The target method arguments.</param>
		/// <param name="streamIds">The target methods stream IDs.</param>
		public StreamInvocationMessage(string invocationId, string target, object[] arguments, string[] streamIds)
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
