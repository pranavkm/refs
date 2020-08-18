using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http2;
using Microsoft.Extensions.Logging;
using System;
using System.Net.Http.HPack;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure
{
	internal class KestrelTrace : IKestrelTrace, ILogger
	{
		protected readonly ILogger _logger;

		public KestrelTrace(ILogger logger)
		{
			throw null;
		}

		public virtual void ConnectionAccepted(string connectionId)
		{
			throw null;
		}

		public virtual void ConnectionStart(string connectionId)
		{
			throw null;
		}

		public virtual void ConnectionStop(string connectionId)
		{
			throw null;
		}

		public virtual void ConnectionPause(string connectionId)
		{
			throw null;
		}

		public virtual void ConnectionResume(string connectionId)
		{
			throw null;
		}

		public virtual void ConnectionKeepAlive(string connectionId)
		{
			throw null;
		}

		public virtual void ConnectionRejected(string connectionId)
		{
			throw null;
		}

		public virtual void ConnectionDisconnect(string connectionId)
		{
			throw null;
		}

		public virtual void ApplicationError(string connectionId, string traceIdentifier, Exception ex)
		{
			throw null;
		}

		public virtual void ConnectionHeadResponseBodyWrite(string connectionId, long count)
		{
			throw null;
		}

		public virtual void NotAllConnectionsClosedGracefully()
		{
			throw null;
		}

		public virtual void ConnectionBadRequest(string connectionId, Microsoft.AspNetCore.Http.BadHttpRequestException ex)
		{
			throw null;
		}

		public virtual void RequestProcessingError(string connectionId, Exception ex)
		{
			throw null;
		}

		public virtual void NotAllConnectionsAborted()
		{
			throw null;
		}

		public virtual void HeartbeatSlow(TimeSpan heartbeatDuration, TimeSpan interval, DateTimeOffset now)
		{
			throw null;
		}

		public virtual void ApplicationNeverCompleted(string connectionId)
		{
			throw null;
		}

		public virtual void RequestBodyStart(string connectionId, string traceIdentifier)
		{
			throw null;
		}

		public virtual void RequestBodyDone(string connectionId, string traceIdentifier)
		{
			throw null;
		}

		public virtual void RequestBodyMinimumDataRateNotSatisfied(string connectionId, string traceIdentifier, double rate)
		{
			throw null;
		}

		public virtual void RequestBodyNotEntirelyRead(string connectionId, string traceIdentifier)
		{
			throw null;
		}

		public virtual void RequestBodyDrainTimedOut(string connectionId, string traceIdentifier)
		{
			throw null;
		}

		public virtual void ResponseMinimumDataRateNotSatisfied(string connectionId, string traceIdentifier)
		{
			throw null;
		}

		public virtual void ApplicationAbortedConnection(string connectionId, string traceIdentifier)
		{
			throw null;
		}

		public virtual void Http2ConnectionError(string connectionId, Http2ConnectionErrorException ex)
		{
			throw null;
		}

		public virtual void Http2ConnectionClosing(string connectionId)
		{
			throw null;
		}

		public virtual void Http2ConnectionClosed(string connectionId, int highestOpenedStreamId)
		{
			throw null;
		}

		public virtual void Http2StreamError(string connectionId, Http2StreamErrorException ex)
		{
			throw null;
		}

		public void Http2StreamResetAbort(string traceIdentifier, Http2ErrorCode error, ConnectionAbortedException abortReason)
		{
			throw null;
		}

		public virtual void HPackDecodingError(string connectionId, int streamId, System.Net.Http.HPack.HPackDecodingException ex)
		{
			throw null;
		}

		public virtual void HPackEncodingError(string connectionId, int streamId, HPackEncodingException ex)
		{
			throw null;
		}

		public void Http2FrameReceived(string connectionId, Http2Frame frame)
		{
			throw null;
		}

		public void Http2FrameSending(string connectionId, Http2Frame frame)
		{
			throw null;
		}

		public void Http2MaxConcurrentStreamsReached(string connectionId)
		{
			throw null;
		}

		public virtual void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
		{
			throw null;
		}

		public virtual bool IsEnabled(LogLevel logLevel)
		{
			throw null;
		}

		public virtual IDisposable BeginScope<TState>(TState state)
		{
			throw null;
		}
	}
}
