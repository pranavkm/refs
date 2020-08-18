namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http2.FlowControl
{
	internal abstract class AwaitableProvider
	{
		public abstract int ActiveCount
		{
			get;
		}

		public abstract ManualResetValueTaskSource<object> GetAwaitable();

		public abstract void CompleteCurrent();

		protected AwaitableProvider()
		{
			throw null;
		}
	}
}
