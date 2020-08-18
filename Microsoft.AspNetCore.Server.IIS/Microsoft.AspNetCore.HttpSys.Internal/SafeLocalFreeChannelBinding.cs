using System.Security.Authentication.ExtendedProtection;

namespace Microsoft.AspNetCore.HttpSys.Internal
{
	internal class SafeLocalFreeChannelBinding : ChannelBinding
	{
		public override int Size
		{
			get
			{
				throw null;
			}
		}

		public override bool IsInvalid
		{
			get
			{
				throw null;
			}
		}

		public static SafeLocalFreeChannelBinding LocalAlloc(int cb)
		{
			throw null;
		}

		protected override bool ReleaseHandle()
		{
			throw null;
		}

		public SafeLocalFreeChannelBinding()
		{
			throw null;
		}
	}
}
