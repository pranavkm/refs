using Microsoft.Win32.SafeHandles;
using System;

namespace Microsoft.AspNetCore.HttpSys.Internal
{
	internal sealed class SafeLocalMemHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		internal SafeLocalMemHandle()
		{
			throw null;
		}

		internal SafeLocalMemHandle(IntPtr existingHandle, bool ownsHandle)
		{
			throw null;
		}

		protected override bool ReleaseHandle()
		{
			throw null;
		}
	}
}
