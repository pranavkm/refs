using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure;
using System;
using System.IO.Pipelines;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http
{
	internal abstract class MessageBody
	{
		protected bool _timingEnabled;

		protected bool _backpressure;

		protected long _alreadyTimedBytes;

		protected long _examinedUnconsumedBytes;

		public static MessageBody ZeroContentLengthClose
		{
			get
			{
				throw null;
			}
		}

		public static MessageBody ZeroContentLengthKeepAlive
		{
			get
			{
				throw null;
			}
		}

		public bool RequestKeepAlive
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			protected set
			{
				throw null;
			}
		}

		public bool RequestUpgrade
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			protected set
			{
				throw null;
			}
		}

		public virtual bool IsEmpty
		{
			get
			{
				throw null;
			}
		}

		protected IKestrelTrace Log
		{
			get
			{
				throw null;
			}
		}

		protected MessageBody(HttpProtocol context)
		{
			throw null;
		}

		public abstract void AdvanceTo(SequencePosition consumed);

		public abstract void AdvanceTo(SequencePosition consumed, SequencePosition examined);

		public abstract bool TryRead(out ReadResult readResult);

		public abstract void Complete(Exception exception);

		public abstract void CancelPendingRead();

		public abstract ValueTask<ReadResult> ReadAsync(CancellationToken cancellationToken = default(CancellationToken));

		public virtual Task ConsumeAsync()
		{
			throw null;
		}

		public virtual Task StopAsync()
		{
			throw null;
		}

		protected virtual Task OnConsumeAsync()
		{
			throw null;
		}

		protected virtual Task OnStopAsync()
		{
			throw null;
		}

		public virtual void Reset()
		{
			throw null;
		}

		protected void TryProduceContinue()
		{
			throw null;
		}

		protected void TryStart()
		{
			throw null;
		}

		protected void TryStop()
		{
			throw null;
		}

		protected virtual void OnReadStarting()
		{
			throw null;
		}

		protected virtual void OnReadStarted()
		{
			throw null;
		}

		protected void AddAndCheckObservedBytes(long observedBytes)
		{
			throw null;
		}

		protected ValueTask<ReadResult> StartTimingReadAsync(ValueTask<ReadResult> readAwaitable, CancellationToken cancellationToken)
		{
			throw null;
		}

		protected void CountBytesRead(long bytesInReadResult)
		{
			throw null;
		}

		protected void StopTimingRead(long bytesInReadResult)
		{
			throw null;
		}

		protected long TrackConsumedAndExaminedBytes(ReadResult readResult, SequencePosition consumed, SequencePosition examined)
		{
			throw null;
		}
	}
}
