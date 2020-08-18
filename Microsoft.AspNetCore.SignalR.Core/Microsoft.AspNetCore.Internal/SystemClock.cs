using System;

namespace Microsoft.AspNetCore.Internal
{
	/// <summary>
	/// Provides access to the normal system clock.
	/// </summary>
	internal class SystemClock : ISystemClock
	{
		/// <summary>
		/// Retrieves the current UTC system time.
		/// </summary>
		public DateTimeOffset UtcNow
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Retrieves ticks for the current UTC system time.
		/// </summary>
		public long UtcNowTicks
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Retrieves the current UTC system time.
		/// </summary>
		public DateTimeOffset UtcNowUnsynchronized
		{
			get
			{
				throw null;
			}
		}

		public SystemClock()
		{
			throw null;
		}
	}
}
