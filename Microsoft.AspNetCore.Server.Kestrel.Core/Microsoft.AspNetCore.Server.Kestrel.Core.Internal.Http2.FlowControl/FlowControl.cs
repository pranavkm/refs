using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http2.FlowControl
{
	internal struct FlowControl
	{
		public int Available
		{
			[CompilerGenerated]
			readonly get
			{
				throw null;
			}
		}

		public bool IsAborted
		{
			[CompilerGenerated]
			readonly get
			{
				throw null;
			}
		}

		public FlowControl(uint initialWindowSize)
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
