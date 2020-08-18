using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Sources;

namespace Microsoft.AspNetCore.Server.IIS.Core
{
	internal class NativeSafeHandle : SafeHandle, IValueTaskSource<object>
	{
		public override bool IsInvalid
		{
			get
			{
				throw null;
			}
		}

		public short Version
		{
			get
			{
				throw null;
			}
		}

		public NativeSafeHandle(IntPtr handle)
		{
			throw null;
		}

		protected override bool ReleaseHandle()
		{
			throw null;
		}

		public object GetResult(short token)
		{
			throw null;
		}

		public ValueTaskSourceStatus GetStatus(short token)
		{
			throw null;
		}

		public void OnCompleted(Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags)
		{
			throw null;
		}
	}
}
