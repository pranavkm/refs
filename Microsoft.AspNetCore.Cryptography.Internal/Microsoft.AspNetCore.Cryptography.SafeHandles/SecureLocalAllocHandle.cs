using System;

namespace Microsoft.AspNetCore.Cryptography.SafeHandles
{
	/// <summary>
	/// Represents a handle returned by LocalAlloc.
	/// The memory will be zeroed out before it's freed.
	/// </summary>
	internal sealed class SecureLocalAllocHandle : LocalAllocHandle
	{
		public IntPtr Length
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Allocates some amount of memory using LocalAlloc.
		/// </summary>
		public static SecureLocalAllocHandle Allocate(IntPtr cb)
		{
			throw null;
		}

		public SecureLocalAllocHandle Duplicate()
		{
			throw null;
		}

		protected override bool ReleaseHandle()
		{
			throw null;
		}
	}
}
