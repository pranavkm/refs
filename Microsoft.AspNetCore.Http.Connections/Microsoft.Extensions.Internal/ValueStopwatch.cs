using System;

namespace Microsoft.Extensions.Internal
{
	internal struct ValueStopwatch
	{
		private static readonly double TimestampToTicks;

		private long _startTimestamp;

		public bool IsActive
		{
			get
			{
				throw null;
			}
		}

		public static ValueStopwatch StartNew()
		{
			throw null;
		}

		public TimeSpan GetElapsedTime()
		{
			throw null;
		}
	}
}
