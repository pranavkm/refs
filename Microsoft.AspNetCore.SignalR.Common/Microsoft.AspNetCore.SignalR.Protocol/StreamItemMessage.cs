using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.SignalR.Protocol
{
	public class StreamItemMessage : HubInvocationMessage
	{
		public object? Item
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		[System.Runtime.CompilerServices.NullableContext(1)]
		public StreamItemMessage(string invocationId, object? item)
		{
			throw null;
		}

		public override string ToString()
		{
			throw null;
		}
	}
}
