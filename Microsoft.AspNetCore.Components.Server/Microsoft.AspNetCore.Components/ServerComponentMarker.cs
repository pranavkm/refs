using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components
{
	internal struct ServerComponentMarker
	{
		public const string ServerMarkerType = "server";

		public int? Sequence
		{
			[CompilerGenerated]
			readonly get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public string Type
		{
			[CompilerGenerated]
			readonly get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public string PrerenderId
		{
			[CompilerGenerated]
			readonly get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public string Descriptor
		{
			[CompilerGenerated]
			readonly get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public static ServerComponentMarker Prerendered(int sequence, string descriptor)
		{
			throw null;
		}

		public static ServerComponentMarker NonPrerendered(int sequence, string descriptor)
		{
			throw null;
		}

		public ServerComponentMarker GetEndRecord()
		{
			throw null;
		}
	}
}
