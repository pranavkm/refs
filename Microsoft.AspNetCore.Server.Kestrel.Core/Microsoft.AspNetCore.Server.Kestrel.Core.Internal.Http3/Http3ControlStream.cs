using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Abstractions;
using System.Diagnostics;
using System.IO.Pipelines;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http3
{
	internal abstract class Http3ControlStream : IThreadPoolWorkItem
	{
		private static class GracefulCloseInitiator
		{
			public const int None = 0;

			public const int Server = 1;

			public const int Client = 2;
		}

		public PipeReader Input
		{
			get
			{
				throw null;
			}
		}

		public Http3ControlStream(Http3Connection http3Connection, HttpConnectionContext context)
		{
			throw null;
		}

		public void Abort(ConnectionAbortedException ex)
		{
			throw null;
		}

		public void HandleReadDataRateTimeout()
		{
			throw null;
		}

		public void HandleRequestHeadersTimeout()
		{
			throw null;
		}

		public void OnInputOrOutputCompleted()
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CSendStreamIdAsync_003Ed__21))]
		[DebuggerStepThrough]
		internal ValueTask SendStreamIdAsync(long id)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CSendGoAway_003Ed__22))]
		[DebuggerStepThrough]
		internal ValueTask SendGoAway(long id)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CSendSettingsFrameAsync_003Ed__23))]
		[DebuggerStepThrough]
		internal ValueTask SendSettingsFrameAsync()
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CProcessRequestAsync_003Ed__25<>))]
		[DebuggerStepThrough]
		public Task ProcessRequestAsync<TContext>(IHttpApplication<TContext> application)
		{
			throw null;
		}

		public void StopProcessingNextRequest()
		{
			throw null;
		}

		public void StopProcessingNextRequest(bool serverInitiated)
		{
			throw null;
		}

		/// <summary>
		/// Used to kick off the request processing loop by derived classes.
		/// </summary>
		public abstract void Execute();
	}
	internal sealed class Http3ControlStream<TContext> : Http3ControlStream, IHostContextContainer<TContext>
	{
		TContext IHostContextContainer<TContext>.HostContext
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

		public Http3ControlStream(IHttpApplication<TContext> application, Http3Connection connection, HttpConnectionContext context)
		{
			throw null;
		}

		public override void Execute()
		{
			throw null;
		}
	}
}
