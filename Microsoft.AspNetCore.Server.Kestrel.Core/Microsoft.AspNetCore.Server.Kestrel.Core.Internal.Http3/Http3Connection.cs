using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http3.QPack;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http3
{
	internal class Http3Connection : IRequestProcessor, ITimeoutHandler
	{
		internal readonly Dictionary<long, Http3Stream> _streams;

		public DynamicTable DynamicTable
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

		public Http3ControlStream ControlStream
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

		public Http3ControlStream EncoderStream
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

		public Http3ControlStream DecoderStream
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

		internal long HighestStreamId
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		public Http3Connection(Http3ConnectionContext context)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CProcessRequestsAsync_003Ed__32<>))]
		[DebuggerStepThrough]
		public Task ProcessRequestsAsync<TContext>(IHttpApplication<TContext> httpApplication)
		{
			throw null;
		}

		internal void Initialize()
		{
			throw null;
		}

		public void StopProcessingNextRequest()
		{
			throw null;
		}

		public void OnConnectionClosed()
		{
			throw null;
		}

		public void Abort(ConnectionAbortedException ex)
		{
			throw null;
		}

		public void Tick()
		{
			throw null;
		}

		public void OnTimeout(TimeoutReason reason)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CInnerProcessRequestsAsync_003Ed__39<>))]
		[DebuggerStepThrough]
		internal Task InnerProcessRequestsAsync<TContext>(IHttpApplication<TContext> application)
		{
			throw null;
		}

		public void HandleRequestHeadersTimeout()
		{
			throw null;
		}

		public void HandleReadDataRateTimeout()
		{
			throw null;
		}

		public void OnInputOrOutputCompleted()
		{
			throw null;
		}

		public void Tick(DateTimeOffset now)
		{
			throw null;
		}

		public void ApplyMaxHeaderListSize(long value)
		{
			throw null;
		}

		internal void ApplyBlockedStream(long value)
		{
			throw null;
		}

		internal void ApplyMaxTableCapacity(long value)
		{
			throw null;
		}

		internal void RemoveStream(long streamId)
		{
			throw null;
		}
	}
}
