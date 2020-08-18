using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http2
{
	internal class Http2Frame
	{
		public Http2ContinuationFrameFlags ContinuationFlags
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		public bool ContinuationEndHeaders
		{
			get
			{
				throw null;
			}
		}

		public int PayloadLength
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

		public Http2FrameType Type
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

		public byte Flags
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

		public int StreamId
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

		public Http2DataFrameFlags DataFlags
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		public bool DataEndStream
		{
			get
			{
				throw null;
			}
		}

		public bool DataHasPadding
		{
			get
			{
				throw null;
			}
		}

		public byte DataPadLength
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

		public int DataPayloadLength
		{
			get
			{
				throw null;
			}
		}

		public int GoAwayLastStreamId
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

		public Http2ErrorCode GoAwayErrorCode
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

		public Http2HeadersFrameFlags HeadersFlags
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		public bool HeadersEndHeaders
		{
			get
			{
				throw null;
			}
		}

		public bool HeadersEndStream
		{
			get
			{
				throw null;
			}
		}

		public bool HeadersHasPadding
		{
			get
			{
				throw null;
			}
		}

		public bool HeadersHasPriority
		{
			get
			{
				throw null;
			}
		}

		public byte HeadersPadLength
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

		public int HeadersStreamDependency
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

		public byte HeadersPriorityWeight
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

		public int HeadersPayloadLength
		{
			get
			{
				throw null;
			}
		}

		public Http2PingFrameFlags PingFlags
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		public bool PingAck
		{
			get
			{
				throw null;
			}
		}

		public int PriorityStreamDependency
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

		public bool PriorityIsExclusive
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

		public byte PriorityWeight
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

		public Http2ErrorCode RstStreamErrorCode
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

		public Http2SettingsFrameFlags SettingsFlags
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		public bool SettingsAck
		{
			get
			{
				throw null;
			}
		}

		public int WindowUpdateSizeIncrement
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

		public void PrepareContinuation(Http2ContinuationFrameFlags flags, int streamId)
		{
			throw null;
		}

		internal object ShowFlags()
		{
			throw null;
		}

		public override string ToString()
		{
			throw null;
		}

		public void PrepareData(int streamId, byte? padLength = null)
		{
			throw null;
		}

		public void PrepareGoAway(int lastStreamId, Http2ErrorCode errorCode)
		{
			throw null;
		}

		public void PrepareHeaders(Http2HeadersFrameFlags flags, int streamId)
		{
			throw null;
		}

		public void PreparePing(Http2PingFrameFlags flags)
		{
			throw null;
		}

		public void PreparePriority(int streamId, int streamDependency, bool exclusive, byte weight)
		{
			throw null;
		}

		public void PrepareRstStream(int streamId, Http2ErrorCode errorCode)
		{
			throw null;
		}

		public void PrepareSettings(Http2SettingsFrameFlags flags)
		{
			throw null;
		}

		public void PrepareWindowUpdate(int streamId, int sizeIncrement)
		{
			throw null;
		}

		public Http2Frame()
		{
			throw null;
		}
	}
}
