using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.SignalR.Protocol
{
	public class CompletionMessage : HubInvocationMessage
	{
		public string? Error
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public object? Result
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public bool HasResult
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public CompletionMessage(string invocationId, string? error, object? result, bool hasResult)
		{
			throw null;
		}

		public override string ToString()
		{
			throw null;
		}

		public static CompletionMessage WithError(string invocationId, string error)
		{
			throw null;
		}

		public static CompletionMessage WithResult(string invocationId, object payload)
		{
			throw null;
		}

		public static CompletionMessage Empty(string invocationId)
		{
			throw null;
		}
	}
}
