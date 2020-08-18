using System;

namespace Microsoft.AspNetCore.Authentication
{
	/// <summary>
	/// Provides access to the normal system clock with precision in seconds.
	/// </summary>
	public class SystemClock : ISystemClock
	{
		/// <summary>
		/// Retrieves the current system time in UTC.
		/// </summary>
		public DateTimeOffset UtcNow
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
