using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Logging;
using System;

namespace Microsoft.AspNetCore.Session
{
	public class DistributedSessionStore : ISessionStore
	{
		public DistributedSessionStore(IDistributedCache cache, ILoggerFactory loggerFactory)
		{
			throw null;
		}

		public ISession Create(string sessionKey, TimeSpan idleTimeout, TimeSpan ioTimeout, Func<bool> tryEstablishSession, bool isNewSessionKey)
		{
			throw null;
		}
	}
}
