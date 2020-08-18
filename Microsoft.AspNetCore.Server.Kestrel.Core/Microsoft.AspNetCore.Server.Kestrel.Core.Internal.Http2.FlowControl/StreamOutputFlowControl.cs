using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http2.FlowControl
{
	internal class StreamOutputFlowControl
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

		public StreamOutputFlowControl(OutputFlowControl connectionLevelFlowControl, uint initialWindowSize)
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

		public int AdvanceUpToAndWait(long bytes, out ValueTask<object> availabilityTask)
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
