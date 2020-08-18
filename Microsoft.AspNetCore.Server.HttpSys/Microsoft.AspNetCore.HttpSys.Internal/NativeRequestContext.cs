using Microsoft.Extensions.Primitives;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;

namespace Microsoft.AspNetCore.HttpSys.Internal
{
	internal class NativeRequestContext : IDisposable
	{
		internal SafeNativeOverlapped NativeOverlapped
		{
			get
			{
				throw null;
			}
		}

		internal unsafe HttpApiTypes.HTTP_REQUEST* NativeRequest
		{
			get
			{
				throw null;
			}
		}

		internal unsafe HttpApiTypes.HTTP_REQUEST_V2* NativeRequestV2
		{
			get
			{
				throw null;
			}
		}

		internal ulong RequestId
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

		internal ulong ConnectionId
		{
			get
			{
				throw null;
			}
		}

		internal HttpApiTypes.HTTP_VERB VerbId
		{
			get
			{
				throw null;
			}
		}

		internal ulong UrlContext
		{
			get
			{
				throw null;
			}
		}

		internal ushort UnknownHeaderCount
		{
			get
			{
				throw null;
			}
		}

		internal SslStatus SslStatus
		{
			get
			{
				throw null;
			}
		}

		internal bool IsHttp2
		{
			get
			{
				throw null;
			}
		}

		internal uint Size
		{
			get
			{
				throw null;
			}
		}

		internal NativeRequestContext(SafeNativeOverlapped nativeOverlapped, MemoryPool<byte> memoryPool, uint? bufferSize, ulong requestId)
		{
			throw null;
		}

		internal unsafe NativeRequestContext(HttpApiTypes.HTTP_REQUEST* request, bool useLatin1)
		{
			throw null;
		}

		internal void ReleasePins()
		{
			throw null;
		}

		public virtual void Dispose()
		{
			throw null;
		}

		internal string GetVerb()
		{
			throw null;
		}

		internal string GetRawUrl()
		{
			throw null;
		}

		internal Span<byte> GetRawUrlInBytes()
		{
			throw null;
		}

		internal CookedUrl GetCookedUrl()
		{
			throw null;
		}

		internal Version GetVersion()
		{
			throw null;
		}

		internal bool CheckAuthenticated()
		{
			throw null;
		}

		internal WindowsPrincipal GetUser()
		{
			throw null;
		}

		internal HttpApiTypes.HTTP_SSL_PROTOCOL_INFO GetTlsHandshake()
		{
			throw null;
		}

		internal string GetKnownHeader(HttpSysRequestHeader header)
		{
			throw null;
		}

		internal void GetUnknownHeaders(IDictionary<string, StringValues> unknownHeaders)
		{
			throw null;
		}

		internal SocketAddress GetRemoteEndPoint()
		{
			throw null;
		}

		internal SocketAddress GetLocalEndPoint()
		{
			throw null;
		}

		internal uint GetChunks(ref int dataChunkIndex, ref uint dataChunkOffset, byte[] buffer, int offset, int size)
		{
			throw null;
		}

		internal IReadOnlyDictionary<int, ReadOnlyMemory<byte>> GetRequestInfo()
		{
			throw null;
		}

		internal X509Certificate2 GetClientCertificate()
		{
			throw null;
		}
	}
}
