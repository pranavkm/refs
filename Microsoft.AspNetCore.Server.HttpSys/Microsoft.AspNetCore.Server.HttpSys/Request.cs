using Microsoft.AspNetCore.HttpSys.Internal;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.HttpSys
{
	internal sealed class Request
	{
		internal ulong UConnectionId
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public long ConnectionId
		{
			get
			{
				throw null;
			}
		}

		internal ulong RequestId
		{
			[CompilerGenerated]
			get
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
		}

		public long? ContentLength
		{
			get
			{
				throw null;
			}
		}

		public RequestHeaders Headers
		{
			[CompilerGenerated]
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

		internal bool IsHeadMethod
		{
			get
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
		}

		public Stream Body
		{
			get
			{
				throw null;
			}
		}

		public bool HasRequestBodyStarted
		{
			get
			{
				throw null;
			}
		}

		public long? MaxRequestBodySize
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

		public string PathBase
		{
			[CompilerGenerated]
			get
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
		}

		public bool IsHttps
		{
			get
			{
				throw null;
			}
		}

		public string RawUrl
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public Version ProtocolVersion
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public bool HasEntityBody
		{
			get
			{
				throw null;
			}
		}

		public IPAddress RemoteIpAddress
		{
			get
			{
				throw null;
			}
		}

		public IPAddress LocalIpAddress
		{
			get
			{
				throw null;
			}
		}

		public int RemotePort
		{
			get
			{
				throw null;
			}
		}

		public int LocalPort
		{
			get
			{
				throw null;
			}
		}

		public string Scheme
		{
			get
			{
				throw null;
			}
		}

		internal bool IsUpgradable
		{
			get
			{
				throw null;
			}
		}

		internal WindowsPrincipal User
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public SslProtocols Protocol
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public CipherAlgorithmType CipherAlgorithm
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public int CipherStrength
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public HashAlgorithmType HashAlgorithm
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public int HashStrength
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public ExchangeAlgorithmType KeyExchangeAlgorithm
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public int KeyExchangeStrength
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public IReadOnlyDictionary<int, ReadOnlyMemory<byte>> RequestInfo
		{
			get
			{
				throw null;
			}
		}

		public X509Certificate2 ClientCertificate
		{
			get
			{
				throw null;
			}
		}

		internal Request(RequestContext requestContext, NativeRequestContext nativeRequestContext)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CGetClientCertificateAsync_003Ed__116))]
		[DebuggerStepThrough]
		public Task<X509Certificate2> GetClientCertificateAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		internal uint GetChunks(ref int dataChunkIndex, ref uint dataChunkOffset, byte[] buffer, int offset, int size)
		{
			throw null;
		}

		internal void Dispose()
		{
			throw null;
		}

		internal void SwitchToOpaqueMode()
		{
			throw null;
		}
	}
}
