using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure;
using System;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http
{
	/// <summary>
	/// Manages the generation of the date header value.
	/// </summary>
	internal class DateHeaderValueManager : IHeartbeatHandler
	{
		public class DateHeaderValues
		{
			public byte[] Bytes;

			public string String;

			public DateHeaderValues()
			{
				throw null;
			}
		}

		/// <summary>
		/// Returns a value representing the current server date/time for use in the HTTP "Date" response header
		/// in accordance with http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.18
		/// </summary>
		/// <returns>The value in string and byte[] format.</returns>
		public DateHeaderValues GetDateHeaderValues()
		{
			throw null;
		}

		public void OnHeartbeat(DateTimeOffset now)
		{
			throw null;
		}

		public DateHeaderValueManager()
		{
			throw null;
		}
	}
}
