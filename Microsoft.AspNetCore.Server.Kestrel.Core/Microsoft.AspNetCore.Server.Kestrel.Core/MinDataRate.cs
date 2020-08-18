using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Server.Kestrel.Core
{
	public class MinDataRate
	{
		/// <summary>
		/// The minimum rate in bytes/second at which data should be processed.
		/// </summary>
		public double BytesPerSecond
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// The amount of time to delay enforcement of <see cref="T:Microsoft.AspNetCore.Server.Kestrel.Core.MinDataRate" />,
		/// starting at the time data is first read or written.
		/// </summary>
		public TimeSpan GracePeriod
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates a new instance of <see cref="T:Microsoft.AspNetCore.Server.Kestrel.Core.MinDataRate" />.
		/// </summary>
		/// <param name="bytesPerSecond">The minimum rate in bytes/second at which data should be processed.</param>
		/// <param name="gracePeriod">The amount of time to delay enforcement of <paramref name="bytesPerSecond" />,
		/// starting at the time data is first read or written.</param>
		public MinDataRate(double bytesPerSecond, TimeSpan gracePeriod)
		{
			throw null;
		}
	}
}
