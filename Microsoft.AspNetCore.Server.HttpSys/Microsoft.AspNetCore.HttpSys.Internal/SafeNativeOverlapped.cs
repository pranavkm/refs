using System.Runtime.InteropServices;
using System.Threading;

namespace Microsoft.AspNetCore.HttpSys.Internal
{
	internal class SafeNativeOverlapped : SafeHandle
	{
		internal static readonly SafeNativeOverlapped Zero;

		public override bool IsInvalid
		{
			get
			{
				throw null;
			}
		}

		internal SafeNativeOverlapped()
		{
			throw null;
		}

		internal unsafe SafeNativeOverlapped(ThreadPoolBoundHandle boundHandle, NativeOverlapped* handle)
		{
			throw null;
		}

		public void ReinitializeNativeOverlapped()
		{
			throw null;
		}

		protected override bool ReleaseHandle()
		{
			throw null;
		}
	}
}
