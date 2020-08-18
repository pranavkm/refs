using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http2
{
	internal sealed class Http2StreamErrorException : Exception
	{
		public int StreamId
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public Http2ErrorCode ErrorCode
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public Http2StreamErrorException(int streamId, string message, Http2ErrorCode errorCode)
		{
			throw null;
		}
	}
}
