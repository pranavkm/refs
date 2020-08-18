using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Session
{
	public class DistributedSession : ISession
	{
		public bool IsAvailable
		{
			get
			{
				throw null;
			}
		}

		public string Id
		{
			get
			{
				throw null;
			}
		}

		public IEnumerable<string> Keys
		{
			get
			{
				throw null;
			}
		}

		public DistributedSession(IDistributedCache cache, string sessionKey, TimeSpan idleTimeout, TimeSpan ioTimeout, Func<bool> tryEstablishSession, ILoggerFactory loggerFactory, bool isNewSessionKey)
		{
			throw null;
		}

		public bool TryGetValue(string key, out byte[] value)
		{
			throw null;
		}

		public void Set(string key, byte[] value)
		{
			throw null;
		}

		public void Remove(string key)
		{
			throw null;
		}

		public void Clear()
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CLoadAsync_003Ed__30))]
		[DebuggerStepThrough]
		public Task LoadAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CCommitAsync_003Ed__31))]
		[DebuggerStepThrough]
		public Task CommitAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}
	}
}
