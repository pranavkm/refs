using Microsoft.Win32.SafeHandles;

namespace Microsoft.AspNetCore.Server.HttpSys
{
	internal sealed class HttpServerSessionHandle : CriticalHandleZeroOrMinusOneIsInvalid
	{
		internal HttpServerSessionHandle(ulong id)
		{
			throw null;
		}

		internal ulong DangerousGetServerSessionId()
		{
			throw null;
		}

		protected override bool ReleaseHandle()
		{
			throw null;
		}
	}
}
