using Microsoft.Win32.SafeHandles;

namespace Microsoft.AspNetCore.Cryptography.SafeHandles
{
	/// <summary>
	/// Represents a handle returned by LocalAlloc.
	/// </summary>
	internal class LocalAllocHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		protected LocalAllocHandle()
		{
			throw null;
		}

		protected override bool ReleaseHandle()
		{
			throw null;
		}
	}
}
