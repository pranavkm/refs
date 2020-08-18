using Microsoft.AspNetCore.HttpSys.Internal;
using Microsoft.Extensions.Logging;
using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Server.HttpSys
{
	internal class UrlGroup : IDisposable
	{
		internal ulong Id
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		internal UrlGroup(ServerSession serverSession, ILogger logger)
		{
			throw null;
		}

		internal void SetMaxConnections(long maxConnections)
		{
			throw null;
		}

		internal void SetProperty(HttpApiTypes.HTTP_SERVER_PROPERTY property, IntPtr info, uint infosize, bool throwOnError = true)
		{
			throw null;
		}

		internal void RegisterPrefix(string uriPrefix, int contextId)
		{
			throw null;
		}

		internal bool UnregisterPrefix(string uriPrefix)
		{
			throw null;
		}

		public void Dispose()
		{
			throw null;
		}
	}
}
