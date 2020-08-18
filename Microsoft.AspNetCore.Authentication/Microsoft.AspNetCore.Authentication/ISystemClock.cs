using System;

namespace Microsoft.AspNetCore.Authentication
{
	/// <summary>
	/// Abstracts the system clock to facilitate testing.
	/// </summary>
	public interface ISystemClock
	{
		/// <summary>
		/// Retrieves the current system time in UTC.
		/// </summary>
		DateTimeOffset UtcNow
		{
			get;
		}
	}
}
