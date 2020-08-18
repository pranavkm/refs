using Microsoft.Win32.SafeHandles;

namespace Microsoft.AspNetCore.Server.HttpSys
{
	internal sealed class HttpRequestQueueV2Handle : SafeHandleZeroOrMinusOneIsInvalid
	{
		protected override bool ReleaseHandle()
		{
			throw null;
		}
	}
}
