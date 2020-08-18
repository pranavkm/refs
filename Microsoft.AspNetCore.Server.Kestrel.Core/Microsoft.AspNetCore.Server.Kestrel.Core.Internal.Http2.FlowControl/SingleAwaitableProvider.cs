namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http2.FlowControl
{
	/// <summary>
	/// Provider has a single awaitable.
	/// </summary>
	internal class SingleAwaitableProvider : AwaitableProvider
	{
		public override int ActiveCount
		{
			get
			{
				throw null;
			}
		}

		public override void CompleteCurrent()
		{
			throw null;
		}

		public override ManualResetValueTaskSource<object> GetAwaitable()
		{
			throw null;
		}

		public SingleAwaitableProvider()
		{
			throw null;
		}
	}
}
