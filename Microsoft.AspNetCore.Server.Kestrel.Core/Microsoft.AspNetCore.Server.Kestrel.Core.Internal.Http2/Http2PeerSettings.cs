using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http2
{
	internal class Http2PeerSettings
	{
		public const uint DefaultHeaderTableSize = 4096u;

		public const bool DefaultEnablePush = true;

		public const uint DefaultMaxConcurrentStreams = uint.MaxValue;

		public const uint DefaultInitialWindowSize = 65535u;

		public const uint DefaultMaxFrameSize = 16384u;

		public const uint DefaultMaxHeaderListSize = uint.MaxValue;

		public const uint MaxWindowSize = 2147483647u;

		internal const int MinAllowedMaxFrameSize = 16384;

		internal const int MaxAllowedMaxFrameSize = 16777215;

		public uint HeaderTableSize
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public bool EnablePush
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public uint MaxConcurrentStreams
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public uint InitialWindowSize
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public uint MaxFrameSize
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public uint MaxHeaderListSize
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public void Update(IList<Http2PeerSetting> settings)
		{
			throw null;
		}

		internal IList<Http2PeerSetting> GetNonProtocolDefaults()
		{
			throw null;
		}

		public Http2PeerSettings()
		{
			throw null;
		}
	}
}
