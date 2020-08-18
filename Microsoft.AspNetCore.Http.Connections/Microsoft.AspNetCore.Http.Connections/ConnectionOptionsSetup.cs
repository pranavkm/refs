using Microsoft.Extensions.Options;
using System;

namespace Microsoft.AspNetCore.Http.Connections
{
	public class ConnectionOptionsSetup : IConfigureOptions<ConnectionOptions>
	{
		public static TimeSpan DefaultDisconectTimeout;

		public void Configure(ConnectionOptions options)
		{
			throw null;
		}

		public ConnectionOptionsSetup()
		{
			throw null;
		}
	}
}
