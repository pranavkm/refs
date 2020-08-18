using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Http.Features.Authentication;
using Microsoft.AspNetCore.HttpSys.Internal;
using Microsoft.AspNetCore.Server.IIS.Core.IO;
using Microsoft.Extensions.Logging;
using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Pipelines;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.IIS.Core
{
	internal abstract class IISHttpContext : NativeRequestContext, IThreadPoolWorkItem, IDisposable, IFeatureCollection, IEnumerable<KeyValuePair<Type, object>>, IEnumerable, IHttpRequestFeature, IHttpResponseFeature, IHttpResponseBodyFeature, IHttpUpgradeFeature, IHttpRequestLifetimeFeature, IHttpAuthenticationFeature, IServerVariablesFeature, ITlsConnectionFeature, IHttpBodyControlFeature, IHttpMaxRequestBodySizeFeature, IHttpResponseTrailersFeature, IHttpResetFeature, IHttpConnectionFeature, IHttpRequestIdentifierFeature
	{
		private static class Log
		{
			public static void ConnectionDisconnect(ILogger logger, string connectionId)
			{
				throw null;
			}

			public static void ApplicationError(ILogger logger, string connectionId, string traceIdentifier, Exception ex)
			{
				throw null;
			}

			public static void UnexpectedError(ILogger logger, string className, Exception ex, [CallerMemberName] string methodName = null)
			{
				throw null;
			}

			public static void ConnectionBadRequest(ILogger logger, string connectionId, Microsoft.AspNetCore.Http.BadHttpRequestException ex)
			{
				throw null;
			}
		}

		protected readonly NativeSafeHandle _requestNativeHandle;

		protected Streams _streams;

		protected Stack<KeyValuePair<Func<object, Task>, object>> _onStarting;

		protected Stack<KeyValuePair<Func<object, Task>, object>> _onCompleted;

		protected Exception _applicationException;

		protected Microsoft.AspNetCore.Http.BadHttpRequestException _requestRejectedException;

		protected Task _readBodyTask;

		protected Task _writeBodyTask;

		protected Pipe _bodyInputPipe;

		protected OutputProducer _bodyOutput;

		protected volatile bool _requestAborted;

		public Version HttpVersion
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

		public string Method
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

		public bool HasResponseStarted
		{
			get
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

		public string RequestConnectionId
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

		public string TraceIdentifier
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

		public ClaimsPrincipal User
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

		internal WindowsPrincipal WindowsUser
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

		public PipeWriter ResponsePipeWrapper
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

		protected IAsyncIOEngine AsyncIO
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

		public IHeaderDictionary ResponseTrailers
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

		internal bool HasTrailers
		{
			get
			{
				throw null;
			}
		}

		internal HttpApiTypes.HTTP_VERB KnownMethod
		{
			[CompilerGenerated]
			get
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

		internal IISHttpServer Server
		{
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

		bool IHttpResponseFeature.HasStarted
		{
			get
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

		PipeWriter IHttpResponseBodyFeature.Writer
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

		ClaimsPrincipal IHttpAuthenticationFeature.User
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

		string IServerVariablesFeature.this[string variableName]
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

		X509Certificate2 ITlsConnectionFeature.ClientCertificate
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

		IHeaderDictionary IHttpResponseTrailersFeature.Trailers
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

		internal IISHttpContext(MemoryPool<byte> memoryPool, NativeSafeHandle pInProcessHandler, IISServerOptions options, IISHttpServer server, ILogger logger, bool useLatin1)
		{
			throw null;
		}

		protected void InitializeContext()
		{
			throw null;
		}

		protected Task ProduceEnd()
		{
			throw null;
		}

		public void SetResponseHeaders()
		{
			throw null;
		}

		public void SetResponseTrailers()
		{
			throw null;
		}

		public abstract Task<bool> ProcessRequestAsync();

		public void OnStarting(Func<object, Task> callback, object state)
		{
			throw null;
		}

		public void OnCompleted(Func<object, Task> callback, object state)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CFireOnStarting_003Ed__162))]
		[DebuggerStepThrough]
		protected Task FireOnStarting()
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CFireOnCompleted_003Ed__163))]
		[DebuggerStepThrough]
		protected Task FireOnCompleted()
		{
			throw null;
		}

		public void SetBadRequestState(Microsoft.AspNetCore.Http.BadHttpRequestException ex)
		{
			throw null;
		}

		protected void ReportApplicationError(Exception ex)
		{
			throw null;
		}

		public void PostCompletion(NativeMethods.REQUEST_NOTIFICATION_STATUS requestNotificationStatus)
		{
			throw null;
		}

		internal void OnAsyncCompletion(int hr, int bytes)
		{
			throw null;
		}

		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		public override void Dispose()
		{
			throw null;
		}

		public void Execute()
		{
			throw null;
		}

		public void ResetFeatureCollection()
		{
			throw null;
		}

		Task IHttpResponseBodyFeature.StartAsync(CancellationToken cancellationToken)
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

		TFeature IFeatureCollection.Get<TFeature>()
		{
			throw null;
		}

		void IFeatureCollection.Set<TFeature>(TFeature instance)
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

		[AsyncStateMachine(typeof(_003CMicrosoft_002DAspNetCore_002DHttp_002DFeatures_002DIHttpUpgradeFeature_002DUpgradeAsync_003Ed__253))]
		[DebuggerStepThrough]
		Task<Stream> IHttpUpgradeFeature.UpgradeAsync()
		{
			throw null;
		}

		Task<X509Certificate2> ITlsConnectionFeature.GetClientCertificateAsync(CancellationToken cancellationToken)
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

		internal IHttpResponseTrailersFeature GetResponseTrailersFeature()
		{
			throw null;
		}

		internal IHttpResetFeature GetResetFeature()
		{
			throw null;
		}

		void IHttpResetFeature.Reset(int errorCode)
		{
			throw null;
		}

		internal void SetResetCode(int errorCode)
		{
			throw null;
		}

		void IHttpResponseBodyFeature.DisableBuffering()
		{
			throw null;
		}

		internal object FastFeatureGet(Type key)
		{
			throw null;
		}

		internal void FastFeatureSet(Type key, object feature)
		{
			throw null;
		}

		void IHttpRequestLifetimeFeature.Abort()
		{
			throw null;
		}

		/// <summary>
		/// Reads data from the Input pipe to the user.
		/// </summary>
		/// <param name="memory"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		[AsyncStateMachine(typeof(_003CReadAsync_003Ed__356))]
		[DebuggerStepThrough]
		internal ValueTask<int> ReadAsync(Memory<byte> memory, CancellationToken cancellationToken)
		{
			throw null;
		}

		internal Task CopyToAsync(Stream destination, CancellationToken cancellationToken)
		{
			throw null;
		}

		/// <summary>
		/// Writes data to the output pipe.
		/// </summary>
		/// <param name="memory"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		internal Task WriteAsync(ReadOnlyMemory<byte> memory, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		/// <summary>
		/// Flushes the data in the output pipe
		/// </summary>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		internal Task FlushAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		internal void AbortIO(bool clientDisconnect)
		{
			throw null;
		}

		public void Abort(Exception reason)
		{
			throw null;
		}
	}
}
