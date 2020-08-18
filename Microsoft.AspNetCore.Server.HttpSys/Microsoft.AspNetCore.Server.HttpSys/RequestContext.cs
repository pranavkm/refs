using Microsoft.AspNetCore.HttpSys.Internal;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.HttpSys
{
	internal sealed class RequestContext : IDisposable, IThreadPoolWorkItem
	{
		internal MessagePump MessagePump
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		internal HttpSysListener Server
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		internal ILogger Logger
		{
			get
			{
				throw null;
			}
		}

		public Request Request
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public Response Response
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public WindowsPrincipal User
		{
			get
			{
				throw null;
			}
		}

		public CancellationToken DisconnectToken
		{
			get
			{
				throw null;
			}
		}

		public Guid TraceIdentifier
		{
			get
			{
				throw null;
			}
		}

		public bool IsUpgradableRequest
		{
			get
			{
				throw null;
			}
		}

		internal bool AllowSynchronousIO
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		internal RequestContext(HttpSysListener server, NativeRequestContext memoryBlob)
		{
			throw null;
		}

		public Task<Stream> UpgradeAsync()
		{
			throw null;
		}

		internal bool TryGetChannelBinding(ref ChannelBinding value)
		{
			throw null;
		}

		/// <summary>
		/// Flushes and completes the response.
		/// </summary>
		public void Dispose()
		{
			throw null;
		}

		/// <summary>
		/// Forcibly terminate and dispose the request, closing the connection if necessary.
		/// </summary>
		public void Abort()
		{
			throw null;
		}

		internal CancellationTokenRegistration RegisterForCancellation(CancellationToken cancellationToken)
		{
			throw null;
		}

		internal void ForceCancelRequest()
		{
			throw null;
		}

		internal void SetResetCode(int errorCode)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CExecute_003Ed__41))]
		[DebuggerStepThrough]
		public void Execute()
		{
			throw null;
		}
	}
}
