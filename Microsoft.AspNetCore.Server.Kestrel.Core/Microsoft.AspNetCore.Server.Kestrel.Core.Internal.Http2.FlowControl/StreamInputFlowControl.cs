namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http2.FlowControl
{
	internal class StreamInputFlowControl
	{
		public StreamInputFlowControl(Http2Stream stream, Http2FrameWriter frameWriter, InputFlowControl connectionLevelFlowControl, uint initialWindowSize, uint minWindowSizeIncrement)
		{
			throw null;
		}

		public void Reset()
		{
			throw null;
		}

		public void Advance(int bytes)
		{
			throw null;
		}

		public void UpdateWindows(int bytes)
		{
			throw null;
		}

		public void StopWindowUpdates()
		{
			throw null;
		}

		public void Abort()
		{
			throw null;
		}
	}
}
