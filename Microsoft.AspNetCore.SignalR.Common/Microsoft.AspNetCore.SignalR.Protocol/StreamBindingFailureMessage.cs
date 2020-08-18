using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

namespace Microsoft.AspNetCore.SignalR.Protocol
{
	/// <summary>
	/// Represents a failure to bind arguments for a StreamDataMessage. This does not represent an actual
	/// message that is sent on the wire, it is returned by <see cref="M:Microsoft.AspNetCore.SignalR.Protocol.IHubProtocol.TryParseMessage(System.Buffers.ReadOnlySequence{System.Byte}@,Microsoft.AspNetCore.SignalR.IInvocationBinder,Microsoft.AspNetCore.SignalR.Protocol.HubMessage@)" />
	/// to indicate that a binding failure occurred when parsing a StreamDataMessage. The stream ID is associated
	/// so that the error can be sent to the relevant hub method.
	/// </summary>
	public class StreamBindingFailureMessage : HubMessage
	{
		/// <summary>
		/// Gets the id of the relevant stream
		/// </summary>
		public string Id
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the exception thrown during binding.
		/// </summary>
		public ExceptionDispatchInfo BindingFailure
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.SignalR.Protocol.InvocationBindingFailureMessage" /> class.
		/// </summary>
		/// <param name="id">The stream ID.</param>
		/// <param name="bindingFailure">The exception thrown during binding.</param>
		public StreamBindingFailureMessage(string id, ExceptionDispatchInfo bindingFailure)
		{
			throw null;
		}
	}
}
