using Microsoft.AspNetCore.Server.Kestrel.Core.Features;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http2.FlowControl;
using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure
{
	internal class TimeoutControl : ITimeoutControl, IConnectionTimeoutFeature
	{
		public TimeoutReason TimerReason
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		internal IDebugger Debugger
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

		public TimeoutControl(ITimeoutHandler timeoutHandler)
		{
			throw null;
		}

		internal void Initialize(long nowTicks)
		{
			throw null;
		}

		public void Tick(DateTimeOffset now)
		{
			throw null;
		}

		public void SetTimeout(long ticks, TimeoutReason timeoutReason)
		{
			throw null;
		}

		public void ResetTimeout(long ticks, TimeoutReason timeoutReason)
		{
			throw null;
		}

		public void CancelTimeout()
		{
			throw null;
		}

		public void InitializeHttp2(InputFlowControl connectionInputFlowControl)
		{
			throw null;
		}

		public void StartRequestBody(MinDataRate minRate)
		{
			throw null;
		}

		public void StopRequestBody()
		{
			throw null;
		}

		public void StopTimingRead()
		{
			throw null;
		}

		public void StartTimingRead()
		{
			throw null;
		}

		public void BytesRead(long count)
		{
			throw null;
		}

		public void StartTimingWrite()
		{
			throw null;
		}

		public void StopTimingWrite()
		{
			throw null;
		}

		public void BytesWrittenToBuffer(MinDataRate minRate, long count)
		{
			throw null;
		}

		void IConnectionTimeoutFeature.SetTimeout(TimeSpan timeSpan)
		{
			throw null;
		}

		void IConnectionTimeoutFeature.ResetTimeout(TimeSpan timeSpan)
		{
			throw null;
		}
	}
}
