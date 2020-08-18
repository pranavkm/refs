namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http2.FlowControl
{
	internal class InputFlowControl
	{
		public bool IsAvailabilityLow
		{
			get
			{
				throw null;
			}
		}

		public InputFlowControl(uint initialWindowSize, uint minWindowSizeIncrement)
		{
			throw null;
		}

		public void Reset()
		{
			throw null;
		}

		public bool TryAdvance(int bytes)
		{
			throw null;
		}

		public bool TryUpdateWindow(int bytes, out int updateSize)
		{
			throw null;
		}

		public void StopWindowUpdates()
		{
			throw null;
		}

		public int Abort()
		{
			throw null;
		}
	}
}
