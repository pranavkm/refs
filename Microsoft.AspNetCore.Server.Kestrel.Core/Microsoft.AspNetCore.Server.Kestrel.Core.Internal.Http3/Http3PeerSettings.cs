using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http3
{
	internal class Http3PeerSettings
	{
		internal const uint DefaultMaxFrameSize = 16384u;

		public static int MinAllowedMaxFrameSize
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			internal set
			{
				throw null;
			}
		}

		public Http3PeerSettings()
		{
			throw null;
		}
	}
}
