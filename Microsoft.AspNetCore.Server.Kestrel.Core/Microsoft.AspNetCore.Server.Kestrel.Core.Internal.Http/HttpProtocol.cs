using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Pipelines;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http
{
	internal abstract class HttpProtocol : IHttpResponseControl, IHttpRequestFeature, IHttpResponseFeature, IHttpResponseBodyFeature, IRequestBodyPipeFeature, IHttpUpgradeFeature, IHttpConnectionFeature, IHttpRequestLifetimeFeature, IHttpRequestIdentifierFeature, IHttpRequestTrailersFeature, IHttpBodyControlFeature, IHttpMaxRequestBodySizeFeature, IEndpointFeature, IRouteValuesFeature, IFeatureCollection, IEnumerable<KeyValuePair<Type, object>>, IEnumerable
	{
		internal const string SchemeHttp = "http";

		internal const string SchemeHttps = "https";

		protected BodyControl _bodyControl;

		protected volatile bool _connectionAborted;

		protected RequestProcessingStatus _requestProcessingStatus;

		protected volatile bool _keepAlive;

		protected Exception _applicationException;

		protected HttpVersion _httpVersion;

		protected string _methodText;

		public IHttpResponseControl HttpResponseControl
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

		public ServiceContext ServiceContext
		{
			get
			{
				throw null;
			}
		}

		public ITimeoutControl TimeoutControl
		{
			get
			{
				throw null;
			}
		}

		public IFeatureCollection ConnectionFeatures
		{
			get
			{
				throw null;
			}
		}

		public IHttpOutputProducer Output
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

		protected IKestrelTrace Log
		{
			get
			{
				throw null;
			}
		}

		protected KestrelServerOptions ServerOptions
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

		protected string ConnectionId
		{
			get
			{
				throw null;
			}
		}

		public string ConnectionIdFeature
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

		public bool HasStartedConsumingRequestBody
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

		public long? MaxRequestBodySize
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

		public MinDataRate MinRequestBodyDataRate
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

		public bool AllowSynchronousIO
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

		/// <summary>
		/// The request id. <seealso cref="P:Microsoft.AspNetCore.Http.HttpContext.TraceIdentifier" />
		/// </summary>
		public string TraceIdentifier
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

		public bool IsUpgradableRequest
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public bool IsUpgraded
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

		public IPAddress RemoteIpAddress
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

		public int RemotePort
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

		public IPAddress LocalIpAddress
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

		public int LocalPort
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

		public string Scheme
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

		public HttpMethod Method
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

		public string MethodText
		{
			get
			{
				throw null;
			}
		}

		public string PathBase
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

		public string Path
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

		public string QueryString
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

		public string RawTarget
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

		public string HttpVersion
		{
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
				throw null;
			}
		}

		public IHeaderDictionary RequestHeaders
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

		public IHeaderDictionary RequestTrailers
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public bool RequestTrailersAvailable
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

		public Stream RequestBody
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

		public PipeReader RequestBodyPipeReader
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

		public HttpResponseTrailers ResponseTrailers
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

		public int StatusCode
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

		public string ReasonPhrase
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

		public IHeaderDictionary ResponseHeaders
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

		public Stream ResponseBody
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

		public PipeWriter ResponseBodyPipeWriter
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

		public CancellationToken RequestAborted
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

		public bool HasResponseStarted
		{
			get
			{
				throw null;
			}
		}

		public bool HasFlushedHeaders
		{
			get
			{
				throw null;
			}
		}

		public bool HasResponseCompleted
		{
			get
			{
				throw null;
			}
		}

		protected HttpRequestHeaders HttpRequestHeaders
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

		protected HttpResponseHeaders HttpResponseHeaders
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		string IHttpRequestFeature.Protocol
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

		string IHttpRequestFeature.Scheme
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

		string IHttpRequestFeature.Method
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

		string IHttpRequestFeature.PathBase
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

		string IHttpRequestFeature.Path
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

		string IHttpRequestFeature.QueryString
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

		string IHttpRequestFeature.RawTarget
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

		IHeaderDictionary IHttpRequestFeature.Headers
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

		Stream IHttpRequestFeature.Body
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

		PipeReader IRequestBodyPipeFeature.Reader
		{
			get
			{
				throw null;
			}
		}

		bool IHttpRequestTrailersFeature.Available
		{
			get
			{
				throw null;
			}
		}

		IHeaderDictionary IHttpRequestTrailersFeature.Trailers
		{
			get
			{
				throw null;
			}
		}

		int IHttpResponseFeature.StatusCode
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

		string IHttpResponseFeature.ReasonPhrase
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

		IHeaderDictionary IHttpResponseFeature.Headers
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

		CancellationToken IHttpRequestLifetimeFeature.RequestAborted
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

		bool IHttpResponseFeature.HasStarted
		{
			get
			{
				throw null;
			}
		}

		bool IHttpUpgradeFeature.IsUpgradableRequest
		{
			get
			{
				throw null;
			}
		}

		IPAddress IHttpConnectionFeature.RemoteIpAddress
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

		IPAddress IHttpConnectionFeature.LocalIpAddress
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

		int IHttpConnectionFeature.RemotePort
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

		int IHttpConnectionFeature.LocalPort
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

		string IHttpConnectionFeature.ConnectionId
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

		string IHttpRequestIdentifierFeature.TraceIdentifier
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

		bool IHttpBodyControlFeature.AllowSynchronousIO
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

		bool IHttpMaxRequestBodySizeFeature.IsReadOnly
		{
			get
			{
				throw null;
			}
		}

		long? IHttpMaxRequestBodySizeFeature.MaxRequestBodySize
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

		Stream IHttpResponseFeature.Body
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

		PipeWriter IHttpResponseBodyFeature.Writer
		{
			get
			{
				throw null;
			}
		}

		Endpoint IEndpointFeature.Endpoint
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

		RouteValueDictionary IRouteValuesFeature.RouteValues
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

		Stream IHttpResponseBodyFeature.Stream
		{
			get
			{
				throw null;
			}
		}

		bool IFeatureCollection.IsReadOnly
		{
			get
			{
				throw null;
			}
		}

		int IFeatureCollection.Revision
		{
			get
			{
				throw null;
			}
		}

		object IFeatureCollection.this[Type key]
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

		public void Initialize(HttpConnectionContext context)
		{
			throw null;
		}

		public void InitializeBodyControl(MessageBody messageBody)
		{
			throw null;
		}

		internal void ResetState()
		{
			throw null;
		}

		public void Reset()
		{
			throw null;
		}

		protected abstract void OnReset();

		protected abstract void ApplicationAbort();

		protected virtual void OnRequestProcessingEnding()
		{
			throw null;
		}

		protected virtual void OnRequestProcessingEnded()
		{
			throw null;
		}

		protected virtual void BeginRequestProcessing()
		{
			throw null;
		}

		protected virtual void OnErrorAfterResponseStarted()
		{
			throw null;
		}

		protected virtual bool BeginRead(out ValueTask<ReadResult> awaitable)
		{
			throw null;
		}

		protected abstract string CreateRequestId();

		protected abstract MessageBody CreateMessageBody();

		protected abstract bool TryParseRequest(ReadResult result, out bool endConnection);

		protected void CancelRequestAbortedToken()
		{
			throw null;
		}

		protected void PoisonBody(Exception abortReason)
		{
			throw null;
		}

		public virtual void OnHeader(ReadOnlySpan<byte> name, ReadOnlySpan<byte> value)
		{
			throw null;
		}

		public virtual void OnHeader(int index, bool indexOnly, ReadOnlySpan<byte> name, ReadOnlySpan<byte> value)
		{
			throw null;
		}

		public void OnTrailer(ReadOnlySpan<byte> name, ReadOnlySpan<byte> value)
		{
			throw null;
		}

		public void OnHeadersComplete()
		{
			throw null;
		}

		public void OnTrailersComplete()
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CProcessRequestsAsync_003Ed__222<>))]
		[DebuggerStepThrough]
		public Task ProcessRequestsAsync<TContext>(IHttpApplication<TContext> application)
		{
			throw null;
		}

		public void OnStarting(Func<object, Task> callback, object state)
		{
			throw null;
		}

		public void OnCompleted(Func<object, Task> callback, object state)
		{
			throw null;
		}

		protected Task FireOnStarting()
		{
			throw null;
		}

		protected Task FireOnCompleted()
		{
			throw null;
		}

		protected bool VerifyResponseContentLength(out Exception ex)
		{
			throw null;
		}

		public void ProduceContinue()
		{
			throw null;
		}

		public Task InitializeResponseAsync(int firstWriteByteCount)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[AsyncStateMachine(typeof(_003CInitializeResponseAwaited_003Ed__235))]
		[DebuggerStepThrough]
		public Task InitializeResponseAwaited(Task startingTask, int firstWriteByteCount)
		{
			throw null;
		}

		protected Task TryProduceInvalidRequestResponse()
		{
			throw null;
		}

		protected Task ProduceEnd()
		{
			throw null;
		}

		public void HandleNonBodyResponseWrite()
		{
			throw null;
		}

		[System.Diagnostics.StackTraceHidden]
		public void ThrowRequestTargetRejected(Span<byte> target)
		{
			throw null;
		}

		public void SetBadRequestState(Microsoft.AspNetCore.Http.BadHttpRequestException ex)
		{
			throw null;
		}

		public void ReportApplicationError(Exception ex)
		{
			throw null;
		}

		public void Advance(int bytes)
		{
			throw null;
		}

		public Memory<byte> GetMemory(int sizeHint = 0)
		{
			throw null;
		}

		public Span<byte> GetSpan(int sizeHint = 0)
		{
			throw null;
		}

		public ValueTask<FlushResult> FlushPipeAsync(CancellationToken cancellationToken)
		{
			throw null;
		}

		public void CancelPendingFlush()
		{
			throw null;
		}

		public Task CompleteAsync(Exception exception = null)
		{
			throw null;
		}

		public ValueTask<FlushResult> WritePipeAsync(ReadOnlyMemory<byte> data, CancellationToken cancellationToken)
		{
			throw null;
		}

		public Task FlushAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		public Task WriteAsync(ReadOnlyMemory<byte> data, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CWriteAsyncAwaited_003Ed__272))]
		[DebuggerStepThrough]
		public ValueTask<FlushResult> WriteAsyncAwaited(Task initializeTask, ReadOnlyMemory<byte> data, CancellationToken cancellationToken)
		{
			throw null;
		}

		protected void ResetHttp1Features()
		{
			throw null;
		}

		protected void ResetHttp2Features()
		{
			throw null;
		}

		void IHttpResponseFeature.OnStarting(Func<object, Task> callback, object state)
		{
			throw null;
		}

		void IHttpResponseFeature.OnCompleted(Func<object, Task> callback, object state)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CMicrosoft_002DAspNetCore_002DHttp_002DFeatures_002DIHttpUpgradeFeature_002DUpgradeAsync_003Ed__365))]
		[DebuggerStepThrough]
		Task<Stream> IHttpUpgradeFeature.UpgradeAsync()
		{
			throw null;
		}

		void IHttpRequestLifetimeFeature.Abort()
		{
			throw null;
		}

		Task IHttpResponseBodyFeature.StartAsync(CancellationToken cancellationToken)
		{
			throw null;
		}

		void IHttpResponseBodyFeature.DisableBuffering()
		{
			throw null;
		}

		Task IHttpResponseBodyFeature.SendFileAsync(string path, long offset, long? count, CancellationToken cancellation)
		{
			throw null;
		}

		Task IHttpResponseBodyFeature.CompleteAsync()
		{
			throw null;
		}

		internal void ResetFeatureCollection()
		{
			throw null;
		}

		TFeature IFeatureCollection.Get<TFeature>()
		{
			throw null;
		}

		void IFeatureCollection.Set<TFeature>(TFeature feature)
		{
			throw null;
		}

		IEnumerator<KeyValuePair<Type, object>> IEnumerable<KeyValuePair<Type, object>>.GetEnumerator()
		{
			throw null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw null;
		}

		protected HttpProtocol()
		{
			throw null;
		}
	}
}
