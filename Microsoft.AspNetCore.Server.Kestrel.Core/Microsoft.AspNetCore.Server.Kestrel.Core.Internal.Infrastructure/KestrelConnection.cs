using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Connections.Features;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure
{
	internal abstract class KestrelConnection : IConnectionHeartbeatFeature, IConnectionCompleteFeature, IConnectionLifetimeNotificationFeature
	{
		protected readonly long _id;

		protected readonly ServiceContext _serviceContext;

		protected readonly TransportConnectionManager _transportConnectionManager;

		protected IKestrelTrace Logger
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public CancellationToken ConnectionClosedRequested
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

		public Task ExecutionTask
		{
			get
			{
				throw null;
			}
		}

		public abstract BaseConnectionContext TransportConnection
		{
			get;
		}

		public KestrelConnection(long id, ServiceContext serviceContext, TransportConnectionManager transportConnectionManager, IKestrelTrace logger)
		{
			throw null;
		}

		public void TickHeartbeat()
		{
			throw null;
		}

		public void OnHeartbeat(Action<object> action, object state)
		{
			throw null;
		}

		void IConnectionCompleteFeature.OnCompleted(Func<object, Task> callback, object state)
		{
			throw null;
		}

		public Task FireOnCompletedAsync()
		{
			throw null;
		}

		public void RequestClose()
		{
			throw null;
		}

		public void Complete()
		{
			throw null;
		}

		protected IDisposable BeginConnectionScope(BaseConnectionContext connectionContext)
		{
			throw null;
		}
	}
	internal class KestrelConnection<T> : KestrelConnection, IThreadPoolWorkItem where T : BaseConnectionContext
	{
		public override BaseConnectionContext TransportConnection
		{
			get
			{
				throw null;
			}
		}

		public KestrelConnection(long id, ServiceContext serviceContext, TransportConnectionManager transportConnectionManager, Func<T, Task> connectionDelegate, T connectionContext, IKestrelTrace logger)
		{
			throw null;
		}

		void IThreadPoolWorkItem.Execute()
		{
			throw null;
		}

		[AsyncStateMachine(typeof(KestrelConnection<>._003CExecuteAsync_003Ed__6))]
		[DebuggerStepThrough]
		internal Task ExecuteAsync()
		{
			throw null;
		}
	}
}
