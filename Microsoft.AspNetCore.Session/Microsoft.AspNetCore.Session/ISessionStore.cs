using Microsoft.AspNetCore.Http;
using System;

namespace Microsoft.AspNetCore.Session
{
	public interface ISessionStore
	{
		ISession Create(string sessionKey, TimeSpan idleTimeout, TimeSpan ioTimeout, Func<bool> tryEstablishSession, bool isNewSessionKey);
	}
}
