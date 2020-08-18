using Microsoft.Win32.SafeHandles;

namespace Microsoft.AspNetCore.HttpSys.Internal
{
	internal sealed class HeapAllocHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		protected override bool ReleaseHandle()
		{
			throw null;
		}
	}
}
