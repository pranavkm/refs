namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http2.FlowControl
{
	/// <summary>
	/// Provider returns multiple awaitables. Awaitables are completed FIFO.
	/// </summary>
	internal class MultipleAwaitableProvider : AwaitableProvider
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

		public MultipleAwaitableProvider()
		{
			throw null;
		}
	}
}
