using Microsoft.AspNetCore.HttpSys.Internal;
using Microsoft.Extensions.Logging;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.HttpSys
{
	/// <summary>
	/// An HTTP server wrapping the Http.Sys APIs that accepts requests.
	/// </summary>
	internal class HttpSysListener : IDisposable
	{
		internal enum State
		{
			Stopped,
			Started,
			Disposed
		}

		internal static readonly bool SkipIOCPCallbackOnSuccess;

		internal MemoryPool<byte> MemoryPool
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		internal ILogger Logger
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		internal UrlGroup UrlGroup
		{
			get
			{
				throw null;
			}
		}

		internal RequestQueue RequestQueue
		{
			get
			{
				throw null;
			}
		}

		internal DisconnectListener DisconnectListener
		{
			get
			{
				throw null;
			}
		}

		public HttpSysOptions Options
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public bool IsListening
		{
			get
			{
				throw null;
			}
		}

		public HttpSysListener(HttpSysOptions options, ILoggerFactory loggerFactory)
		{
			throw null;
		}

		/// <summary>
		/// Start accepting incoming requests.
		/// </summary>
		public void Start()
		{
			throw null;
		}

		/// <summary>
		/// Stop the server and clean up.
		/// </summary>
		public void Dispose()
		{
			throw null;
		}

		/// <summary>
		/// Accept a request from the incoming request queue.
		/// </summary>
		public Task<RequestContext> AcceptAsync()
		{
			throw null;
		}

		internal bool ValidateRequest(NativeRequestContext requestMemory)
		{
			throw null;
		}

		internal bool ValidateAuth(NativeRequestContext requestMemory)
		{
			throw null;
		}

		internal void SendError(ulong requestId, int httpStatusCode, IList<string> authChallenges = null)
		{
			throw null;
		}
	}
}
