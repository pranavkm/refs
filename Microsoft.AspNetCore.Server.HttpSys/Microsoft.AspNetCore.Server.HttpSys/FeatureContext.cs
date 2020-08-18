using Microsoft.AspNetCore.Connections.Features;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Http.Features.Authentication;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Pipelines;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.HttpSys
{
	internal class FeatureContext : IHttpRequestFeature, IHttpConnectionFeature, IHttpResponseFeature, IHttpResponseBodyFeature, ITlsConnectionFeature, ITlsHandshakeFeature, IHttpRequestLifetimeFeature, IHttpAuthenticationFeature, IHttpUpgradeFeature, IHttpRequestIdentifierFeature, IHttpMaxRequestBodySizeFeature, IHttpBodyControlFeature, IHttpSysRequestInfoFeature, IHttpResponseTrailersFeature, IHttpResetFeature
	{
		[Flags]
		private enum Fields
		{
			None = 0x0,
			Protocol = 0x1,
			RequestBody = 0x2,
			RequestAborted = 0x4,
			LocalIpAddress = 0x8,
			RemoteIpAddress = 0x10,
			LocalPort = 0x20,
			RemotePort = 0x40,
			ConnectionId = 0x80,
			ClientCertificate = 0x100,
			TraceIdentifier = 0x200
		}

		internal IFeatureCollection Features
		{
			get
			{
				throw null;
			}
		}

		internal object RequestContext
		{
			get
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

		bool IHttpResponseFeature.HasStarted
		{
			get
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

		bool IHttpUpgradeFeature.IsUpgradableRequest
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

		SslProtocols ITlsHandshakeFeature.Protocol
		{
			get
			{
				throw null;
			}
		}

		CipherAlgorithmType ITlsHandshakeFeature.CipherAlgorithm
		{
			get
			{
				throw null;
			}
		}

		int ITlsHandshakeFeature.CipherStrength
		{
			get
			{
				throw null;
			}
		}

		HashAlgorithmType ITlsHandshakeFeature.HashAlgorithm
		{
			get
			{
				throw null;
			}
		}

		int ITlsHandshakeFeature.HashStrength
		{
			get
			{
				throw null;
			}
		}

		ExchangeAlgorithmType ITlsHandshakeFeature.KeyExchangeAlgorithm
		{
			get
			{
				throw null;
			}
		}

		int ITlsHandshakeFeature.KeyExchangeStrength
		{
			get
			{
				throw null;
			}
		}

		IReadOnlyDictionary<int, ReadOnlyMemory<byte>> IHttpSysRequestInfoFeature.RequestInfo
		{
			get
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

		internal FeatureContext(RequestContext requestContext)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CMicrosoft_002DAspNetCore_002DHttp_002DFeatures_002DITlsConnectionFeature_002DGetClientCertificateAsync_003Ed__88))]
		[DebuggerStepThrough]
		Task<X509Certificate2> ITlsConnectionFeature.GetClientCertificateAsync(CancellationToken cancellationToken)
		{
			throw null;
		}

		internal ITlsConnectionFeature GetTlsConnectionFeature()
		{
			throw null;
		}

		internal ITlsHandshakeFeature GetTlsHandshakeFeature()
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

		void IHttpResponseBodyFeature.DisableBuffering()
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

		[AsyncStateMachine(typeof(_003CMicrosoft_002DAspNetCore_002DHttp_002DFeatures_002DIHttpResponseBodyFeature_002DSendFileAsync_003Ed__114))]
		[DebuggerStepThrough]
		Task IHttpResponseBodyFeature.SendFileAsync(string path, long offset, long? length, CancellationToken cancellation)
		{
			throw null;
		}

		Task IHttpResponseBodyFeature.StartAsync(CancellationToken cancellation)
		{
			throw null;
		}

		Task IHttpResponseBodyFeature.CompleteAsync()
		{
			throw null;
		}

		void IHttpResetFeature.Reset(int errorCode)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CCompleteAsync_003Ed__118))]
		[DebuggerStepThrough]
		internal Task CompleteAsync()
		{
			throw null;
		}

		void IHttpRequestLifetimeFeature.Abort()
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CMicrosoft_002DAspNetCore_002DHttp_002DFeatures_002DIHttpUpgradeFeature_002DUpgradeAsync_003Ed__125))]
		[DebuggerStepThrough]
		Task<Stream> IHttpUpgradeFeature.UpgradeAsync()
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003COnResponseStart_003Ed__159))]
		[DebuggerStepThrough]
		internal Task OnResponseStart()
		{
			throw null;
		}

		internal Task OnCompleted()
		{
			throw null;
		}
	}
}
