namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http2.FlowControl
{
	internal class OutputFlowControl
	{
		public int Available
		{
			get
			{
				throw null;
			}
		}

		public bool IsAborted
		{
			get
			{
				throw null;
			}
		}

		public ManualResetValueTaskSource<object> AvailabilityAwaitable
		{
			get
			{
				throw null;
			}
		}

		public OutputFlowControl(AwaitableProvider awaitableProvider, uint initialWindowSize)
		{
			throw null;
		}

		public void Reset(uint initialWindowSize)
		{
			throw null;
		}

		public void Advance(int bytes)
		{
			throw null;
		}

		public bool TryUpdateWindow(int bytes)
		{
			throw null;
		}

		public void Abort()
		{
			throw null;
		}
	}
}
