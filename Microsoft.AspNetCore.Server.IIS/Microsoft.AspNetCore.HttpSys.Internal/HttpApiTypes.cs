using System;
using System.Runtime.InteropServices;
using System.Security.Authentication;

namespace Microsoft.AspNetCore.HttpSys.Internal
{
	internal static class HttpApiTypes
	{
		internal enum HTTP_API_VERSION
		{
			Invalid,
			Version10,
			Version20
		}

		internal enum HTTP_SERVER_PROPERTY
		{
			HttpServerAuthenticationProperty,
			HttpServerLoggingProperty,
			HttpServerQosProperty,
			HttpServerTimeoutsProperty,
			HttpServerQueueLengthProperty,
			HttpServerStateProperty,
			HttpServer503VerbosityProperty,
			HttpServerBindingProperty,
			HttpServerExtendedAuthenticationProperty,
			HttpServerListenEndpointProperty,
			HttpServerChannelBindProperty,
			HttpServerProtectionLevelProperty
		}

		internal enum HTTP_REQUEST_INFO_TYPE
		{
			HttpRequestInfoTypeAuth,
			HttpRequestInfoTypeChannelBind,
			HttpRequestInfoTypeSslProtocol,
			HttpRequestInfoTypeSslTokenBinding
		}

		internal enum HTTP_RESPONSE_INFO_TYPE
		{
			HttpResponseInfoTypeMultipleKnownHeaders,
			HttpResponseInfoTypeAuthenticationProperty,
			HttpResponseInfoTypeQosProperty
		}

		internal enum HTTP_REQUEST_PROPERTY
		{
			HttpRequestPropertyIsb,
			HttpRequestPropertyTcpInfoV0,
			HttpRequestPropertyQuicStats,
			HttpRequestPropertyTcpInfoV1,
			HttpRequestPropertySni,
			HttpRequestPropertyStreamError
		}

		internal enum HTTP_TIMEOUT_TYPE
		{
			EntityBody,
			DrainEntityBody,
			RequestQueue,
			IdleConnection,
			HeaderWait,
			MinSendRate
		}

		internal struct HTTP_REQUEST_PROPERTY_STREAM_ERROR
		{
			internal uint ErrorCode;
		}

		internal struct HTTP_VERSION
		{
			internal ushort MajorVersion;

			internal ushort MinorVersion;
		}

		internal struct HTTP_KNOWN_HEADER
		{
			internal ushort RawValueLength;

			internal unsafe byte* pRawValue;
		}

		[StructLayout(LayoutKind.Explicit)]
		internal struct HTTP_DATA_CHUNK
		{
			[FieldOffset(0)]
			internal HTTP_DATA_CHUNK_TYPE DataChunkType;

			[FieldOffset(8)]
			internal FromMemory fromMemory;

			[FieldOffset(8)]
			internal FromFileHandle fromFile;

			[FieldOffset(8)]
			internal Trailers trailers;
		}

		internal struct FromMemory
		{
			internal IntPtr pBuffer;

			internal uint BufferLength;
		}

		internal struct FromFileHandle
		{
			internal ulong offset;

			internal ulong count;

			internal IntPtr fileHandle;
		}

		internal struct Trailers
		{
			internal ushort trailerCount;

			internal IntPtr pTrailers;
		}

		internal struct HTTPAPI_VERSION
		{
			internal ushort HttpApiMajorVersion;

			internal ushort HttpApiMinorVersion;
		}

		internal struct HTTP_COOKED_URL
		{
			internal ushort FullUrlLength;

			internal ushort HostLength;

			internal ushort AbsPathLength;

			internal ushort QueryStringLength;

			internal unsafe ushort* pFullUrl;

			internal unsafe ushort* pHost;

			internal unsafe ushort* pAbsPath;

			internal unsafe ushort* pQueryString;
		}

		internal struct HTTP_CACHE_POLICY
		{
			internal HTTP_CACHE_POLICY_TYPE Policy;

			internal uint SecondsToLive;
		}

		internal enum HTTP_CACHE_POLICY_TYPE
		{
			HttpCachePolicyNocache,
			HttpCachePolicyUserInvalidates,
			HttpCachePolicyTimeToLive
		}

		internal struct SOCKADDR
		{
			internal ushort sa_family;

			internal byte sa_data;

			internal byte sa_data_02;

			internal byte sa_data_03;

			internal byte sa_data_04;

			internal byte sa_data_05;

			internal byte sa_data_06;

			internal byte sa_data_07;

			internal byte sa_data_08;

			internal byte sa_data_09;

			internal byte sa_data_10;

			internal byte sa_data_11;

			internal byte sa_data_12;

			internal byte sa_data_13;

			internal byte sa_data_14;
		}

		internal struct HTTP_TRANSPORT_ADDRESS
		{
			internal unsafe SOCKADDR* pRemoteAddress;

			internal unsafe SOCKADDR* pLocalAddress;
		}

		internal struct HTTP_SSL_CLIENT_CERT_INFO
		{
			internal uint CertFlags;

			internal uint CertEncodedSize;

			internal unsafe byte* pCertEncoded;

			internal unsafe void* Token;

			internal byte CertDeniedByMapper;
		}

		internal enum HTTP_SERVICE_BINDING_TYPE : uint
		{
			HttpServiceBindingTypeNone,
			HttpServiceBindingTypeW,
			HttpServiceBindingTypeA
		}

		internal struct HTTP_SERVICE_BINDING_BASE
		{
			internal HTTP_SERVICE_BINDING_TYPE Type;
		}

		internal struct HTTP_REQUEST_CHANNEL_BIND_STATUS
		{
			internal IntPtr ServiceName;

			internal IntPtr ChannelToken;

			internal uint ChannelTokenSize;

			internal uint Flags;
		}

		internal struct HTTP_UNKNOWN_HEADER
		{
			internal ushort NameLength;

			internal ushort RawValueLength;

			internal unsafe byte* pName;

			internal unsafe byte* pRawValue;
		}

		internal struct HTTP_SSL_INFO
		{
			internal ushort ServerCertKeySize;

			internal ushort ConnectionKeySize;

			internal uint ServerCertIssuerSize;

			internal uint ServerCertSubjectSize;

			internal unsafe byte* pServerCertIssuer;

			internal unsafe byte* pServerCertSubject;

			internal unsafe HTTP_SSL_CLIENT_CERT_INFO* pClientCertInfo;

			internal uint SslClientCertNegotiated;
		}

		internal struct HTTP_RESPONSE_HEADERS
		{
			internal ushort UnknownHeaderCount;

			internal unsafe HTTP_UNKNOWN_HEADER* pUnknownHeaders;

			internal ushort TrailerCount;

			internal unsafe HTTP_UNKNOWN_HEADER* pTrailers;

			internal HTTP_KNOWN_HEADER KnownHeaders;

			internal HTTP_KNOWN_HEADER KnownHeaders_02;

			internal HTTP_KNOWN_HEADER KnownHeaders_03;

			internal HTTP_KNOWN_HEADER KnownHeaders_04;

			internal HTTP_KNOWN_HEADER KnownHeaders_05;

			internal HTTP_KNOWN_HEADER KnownHeaders_06;

			internal HTTP_KNOWN_HEADER KnownHeaders_07;

			internal HTTP_KNOWN_HEADER KnownHeaders_08;

			internal HTTP_KNOWN_HEADER KnownHeaders_09;

			internal HTTP_KNOWN_HEADER KnownHeaders_10;

			internal HTTP_KNOWN_HEADER KnownHeaders_11;

			internal HTTP_KNOWN_HEADER KnownHeaders_12;

			internal HTTP_KNOWN_HEADER KnownHeaders_13;

			internal HTTP_KNOWN_HEADER KnownHeaders_14;

			internal HTTP_KNOWN_HEADER KnownHeaders_15;

			internal HTTP_KNOWN_HEADER KnownHeaders_16;

			internal HTTP_KNOWN_HEADER KnownHeaders_17;

			internal HTTP_KNOWN_HEADER KnownHeaders_18;

			internal HTTP_KNOWN_HEADER KnownHeaders_19;

			internal HTTP_KNOWN_HEADER KnownHeaders_20;

			internal HTTP_KNOWN_HEADER KnownHeaders_21;

			internal HTTP_KNOWN_HEADER KnownHeaders_22;

			internal HTTP_KNOWN_HEADER KnownHeaders_23;

			internal HTTP_KNOWN_HEADER KnownHeaders_24;

			internal HTTP_KNOWN_HEADER KnownHeaders_25;

			internal HTTP_KNOWN_HEADER KnownHeaders_26;

			internal HTTP_KNOWN_HEADER KnownHeaders_27;

			internal HTTP_KNOWN_HEADER KnownHeaders_28;

			internal HTTP_KNOWN_HEADER KnownHeaders_29;

			internal HTTP_KNOWN_HEADER KnownHeaders_30;
		}

		internal struct HTTP_REQUEST_HEADERS
		{
			internal ushort UnknownHeaderCount;

			internal unsafe HTTP_UNKNOWN_HEADER* pUnknownHeaders;

			internal ushort TrailerCount;

			internal unsafe HTTP_UNKNOWN_HEADER* pTrailers;

			internal HTTP_KNOWN_HEADER KnownHeaders;

			internal HTTP_KNOWN_HEADER KnownHeaders_02;

			internal HTTP_KNOWN_HEADER KnownHeaders_03;

			internal HTTP_KNOWN_HEADER KnownHeaders_04;

			internal HTTP_KNOWN_HEADER KnownHeaders_05;

			internal HTTP_KNOWN_HEADER KnownHeaders_06;

			internal HTTP_KNOWN_HEADER KnownHeaders_07;

			internal HTTP_KNOWN_HEADER KnownHeaders_08;

			internal HTTP_KNOWN_HEADER KnownHeaders_09;

			internal HTTP_KNOWN_HEADER KnownHeaders_10;

			internal HTTP_KNOWN_HEADER KnownHeaders_11;

			internal HTTP_KNOWN_HEADER KnownHeaders_12;

			internal HTTP_KNOWN_HEADER KnownHeaders_13;

			internal HTTP_KNOWN_HEADER KnownHeaders_14;

			internal HTTP_KNOWN_HEADER KnownHeaders_15;

			internal HTTP_KNOWN_HEADER KnownHeaders_16;

			internal HTTP_KNOWN_HEADER KnownHeaders_17;

			internal HTTP_KNOWN_HEADER KnownHeaders_18;

			internal HTTP_KNOWN_HEADER KnownHeaders_19;

			internal HTTP_KNOWN_HEADER KnownHeaders_20;

			internal HTTP_KNOWN_HEADER KnownHeaders_21;

			internal HTTP_KNOWN_HEADER KnownHeaders_22;

			internal HTTP_KNOWN_HEADER KnownHeaders_23;

			internal HTTP_KNOWN_HEADER KnownHeaders_24;

			internal HTTP_KNOWN_HEADER KnownHeaders_25;

			internal HTTP_KNOWN_HEADER KnownHeaders_26;

			internal HTTP_KNOWN_HEADER KnownHeaders_27;

			internal HTTP_KNOWN_HEADER KnownHeaders_28;

			internal HTTP_KNOWN_HEADER KnownHeaders_29;

			internal HTTP_KNOWN_HEADER KnownHeaders_30;

			internal HTTP_KNOWN_HEADER KnownHeaders_31;

			internal HTTP_KNOWN_HEADER KnownHeaders_32;

			internal HTTP_KNOWN_HEADER KnownHeaders_33;

			internal HTTP_KNOWN_HEADER KnownHeaders_34;

			internal HTTP_KNOWN_HEADER KnownHeaders_35;

			internal HTTP_KNOWN_HEADER KnownHeaders_36;

			internal HTTP_KNOWN_HEADER KnownHeaders_37;

			internal HTTP_KNOWN_HEADER KnownHeaders_38;

			internal HTTP_KNOWN_HEADER KnownHeaders_39;

			internal HTTP_KNOWN_HEADER KnownHeaders_40;

			internal HTTP_KNOWN_HEADER KnownHeaders_41;
		}

		internal enum HTTP_VERB
		{
			HttpVerbUnparsed,
			HttpVerbUnknown,
			HttpVerbInvalid,
			HttpVerbOPTIONS,
			HttpVerbGET,
			HttpVerbHEAD,
			HttpVerbPOST,
			HttpVerbPUT,
			HttpVerbDELETE,
			HttpVerbTRACE,
			HttpVerbCONNECT,
			HttpVerbTRACK,
			HttpVerbMOVE,
			HttpVerbCOPY,
			HttpVerbPROPFIND,
			HttpVerbPROPPATCH,
			HttpVerbMKCOL,
			HttpVerbLOCK,
			HttpVerbUNLOCK,
			HttpVerbSEARCH,
			HttpVerbMaximum
		}

		internal enum HTTP_DATA_CHUNK_TYPE
		{
			HttpDataChunkFromMemory,
			HttpDataChunkFromFileHandle,
			HttpDataChunkFromFragmentCache,
			HttpDataChunkFromFragmentCacheEx,
			HttpDataChunkTrailers,
			HttpDataChunkMaximum
		}

		internal struct HTTP_RESPONSE_INFO
		{
			internal HTTP_RESPONSE_INFO_TYPE Type;

			internal uint Length;

			internal unsafe HTTP_MULTIPLE_KNOWN_HEADERS* pInfo;
		}

		internal struct HTTP_RESPONSE
		{
			internal uint Flags;

			internal HTTP_VERSION Version;

			internal ushort StatusCode;

			internal ushort ReasonLength;

			internal unsafe byte* pReason;

			internal HTTP_RESPONSE_HEADERS Headers;

			internal ushort EntityChunkCount;

			internal unsafe HTTP_DATA_CHUNK* pEntityChunks;
		}

		internal struct HTTP_RESPONSE_V2
		{
			internal HTTP_RESPONSE Response_V1;

			internal ushort ResponseInfoCount;

			internal unsafe HTTP_RESPONSE_INFO* pResponseInfo;
		}

		internal enum HTTP_RESPONSE_INFO_FLAGS : uint
		{
			None,
			PreserveOrder
		}

		internal struct HTTP_MULTIPLE_KNOWN_HEADERS
		{
			internal HTTP_RESPONSE_HEADER_ID.Enum HeaderId;

			internal HTTP_RESPONSE_INFO_FLAGS Flags;

			internal ushort KnownHeaderCount;

			internal unsafe HTTP_KNOWN_HEADER* KnownHeaders;
		}

		internal struct HTTP_REQUEST_AUTH_INFO
		{
			internal HTTP_AUTH_STATUS AuthStatus;

			internal uint SecStatus;

			internal uint Flags;

			internal HTTP_REQUEST_AUTH_TYPE AuthType;

			internal IntPtr AccessToken;

			internal uint ContextAttributes;

			internal uint PackedContextLength;

			internal uint PackedContextType;

			internal IntPtr PackedContext;

			internal uint MutualAuthDataLength;

			internal unsafe char* pMutualAuthData;
		}

		internal struct HTTP_SSL_PROTOCOL_INFO
		{
			internal SslProtocols Protocol;

			internal CipherAlgorithmType CipherType;

			internal uint CipherStrength;

			internal HashAlgorithmType HashType;

			internal uint HashStrength;

			internal ExchangeAlgorithmType KeyExchangeType;

			internal uint KeyExchangeStrength;
		}

		internal struct HTTP_REQUEST_INFO
		{
			internal HTTP_REQUEST_INFO_TYPE InfoType;

			internal uint InfoLength;

			internal unsafe void* pInfo;
		}

		[Flags]
		internal enum HTTP_REQUEST_FLAGS
		{
			None = 0x0,
			MoreEntityBodyExists = 0x1,
			IPRouted = 0x2,
			Http2 = 0x4
		}

		internal struct HTTP_REQUEST
		{
			internal HTTP_REQUEST_FLAGS Flags;

			internal ulong ConnectionId;

			internal ulong RequestId;

			internal ulong UrlContext;

			internal HTTP_VERSION Version;

			internal HTTP_VERB Verb;

			internal ushort UnknownVerbLength;

			internal ushort RawUrlLength;

			internal unsafe byte* pUnknownVerb;

			internal unsafe byte* pRawUrl;

			internal HTTP_COOKED_URL CookedUrl;

			internal HTTP_TRANSPORT_ADDRESS Address;

			internal HTTP_REQUEST_HEADERS Headers;

			internal ulong BytesReceived;

			internal ushort EntityChunkCount;

			internal unsafe HTTP_DATA_CHUNK* pEntityChunks;

			internal ulong RawConnectionId;

			internal unsafe HTTP_SSL_INFO* pSslInfo;
		}

		internal struct HTTP_REQUEST_V2
		{
			internal HTTP_REQUEST Request;

			internal ushort RequestInfoCount;

			internal unsafe HTTP_REQUEST_INFO* pRequestInfo;
		}

		internal enum HTTP_AUTH_STATUS
		{
			HttpAuthStatusSuccess,
			HttpAuthStatusNotAuthenticated,
			HttpAuthStatusFailure
		}

		internal enum HTTP_REQUEST_AUTH_TYPE
		{
			HttpRequestAuthTypeNone,
			HttpRequestAuthTypeBasic,
			HttpRequestAuthTypeDigest,
			HttpRequestAuthTypeNTLM,
			HttpRequestAuthTypeNegotiate,
			HttpRequestAuthTypeKerberos
		}

		internal enum HTTP_QOS_SETTING_TYPE
		{
			HttpQosSettingTypeBandwidth,
			HttpQosSettingTypeConnectionLimit,
			HttpQosSettingTypeFlowRate
		}

		internal struct HTTP_SERVER_AUTHENTICATION_INFO
		{
			internal HTTP_FLAGS Flags;

			internal HTTP_AUTH_TYPES AuthSchemes;

			internal bool ReceiveMutualAuth;

			internal bool ReceiveContextHandle;

			internal bool DisableNTLMCredentialCaching;

			internal ulong ExFlags;

			private HTTP_SERVER_AUTHENTICATION_DIGEST_PARAMS DigestParams;

			private HTTP_SERVER_AUTHENTICATION_BASIC_PARAMS BasicParams;
		}

		internal struct HTTP_SERVER_AUTHENTICATION_DIGEST_PARAMS
		{
			internal ushort DomainNameLength;

			internal unsafe char* DomainName;

			internal ushort RealmLength;

			internal unsafe char* Realm;
		}

		internal struct HTTP_SERVER_AUTHENTICATION_BASIC_PARAMS
		{
			private ushort RealmLength;

			private unsafe char* Realm;
		}

		internal struct HTTP_REQUEST_TOKEN_BINDING_INFO
		{
			public unsafe byte* TokenBinding;

			public uint TokenBindingSize;

			public unsafe byte* TlsUnique;

			public uint TlsUniqueSize;

			public unsafe char* KeyType;
		}

		internal struct HTTP_TIMEOUT_LIMIT_INFO
		{
			internal HTTP_FLAGS Flags;

			internal ushort EntityBody;

			internal ushort DrainEntityBody;

			internal ushort RequestQueue;

			internal ushort IdleConnection;

			internal ushort HeaderWait;

			internal uint MinSendRate;
		}

		internal struct HTTP_BINDING_INFO
		{
			internal HTTP_FLAGS Flags;

			internal IntPtr RequestQueueHandle;
		}

		internal struct HTTP_CONNECTION_LIMIT_INFO
		{
			internal HTTP_FLAGS Flags;

			internal uint MaxConnections;
		}

		internal struct HTTP_QOS_SETTING_INFO
		{
			internal HTTP_QOS_SETTING_TYPE QosType;

			internal IntPtr QosSetting;
		}

		[Flags]
		internal enum HTTP_FLAGS : uint
		{
			NONE = 0x0u,
			HTTP_RECEIVE_REQUEST_FLAG_COPY_BODY = 0x1u,
			HTTP_RECEIVE_SECURE_CHANNEL_TOKEN = 0x1u,
			HTTP_SEND_RESPONSE_FLAG_DISCONNECT = 0x1u,
			HTTP_SEND_RESPONSE_FLAG_MORE_DATA = 0x2u,
			HTTP_SEND_RESPONSE_FLAG_BUFFER_DATA = 0x4u,
			HTTP_SEND_RESPONSE_FLAG_RAW_HEADER = 0x4u,
			HTTP_SEND_REQUEST_FLAG_MORE_DATA = 0x1u,
			HTTP_PROPERTY_FLAG_PRESENT = 0x1u,
			HTTP_INITIALIZE_SERVER = 0x1u,
			HTTP_INITIALIZE_CBT = 0x4u,
			HTTP_SEND_RESPONSE_FLAG_OPAQUE = 0x40u,
			HTTP_SEND_RESPONSE_FLAG_GOAWAY = 0x100u
		}

		[Flags]
		internal enum HTTP_AUTH_TYPES : uint
		{
			NONE = 0x0u,
			HTTP_AUTH_ENABLE_BASIC = 0x1u,
			HTTP_AUTH_ENABLE_DIGEST = 0x2u,
			HTTP_AUTH_ENABLE_NTLM = 0x4u,
			HTTP_AUTH_ENABLE_NEGOTIATE = 0x8u,
			HTTP_AUTH_ENABLE_KERBEROS = 0x10u
		}

		[Flags]
		internal enum HTTP_CREATE_REQUEST_QUEUE_FLAG : uint
		{
			None = 0x0u,
			OpenExisting = 0x1u,
			Controller = 0x2u
		}

		internal static class HTTP_RESPONSE_HEADER_ID
		{
			internal enum Enum
			{
				HttpHeaderCacheControl = 0,
				HttpHeaderConnection = 1,
				HttpHeaderDate = 2,
				HttpHeaderKeepAlive = 3,
				HttpHeaderPragma = 4,
				HttpHeaderTrailer = 5,
				HttpHeaderTransferEncoding = 6,
				HttpHeaderUpgrade = 7,
				HttpHeaderVia = 8,
				HttpHeaderWarning = 9,
				HttpHeaderAllow = 10,
				HttpHeaderContentLength = 11,
				HttpHeaderContentType = 12,
				HttpHeaderContentEncoding = 13,
				HttpHeaderContentLanguage = 14,
				HttpHeaderContentLocation = 0xF,
				HttpHeaderContentMd5 = 0x10,
				HttpHeaderContentRange = 17,
				HttpHeaderExpires = 18,
				HttpHeaderLastModified = 19,
				HttpHeaderAcceptRanges = 20,
				HttpHeaderAge = 21,
				HttpHeaderEtag = 22,
				HttpHeaderLocation = 23,
				HttpHeaderProxyAuthenticate = 24,
				HttpHeaderRetryAfter = 25,
				HttpHeaderServer = 26,
				HttpHeaderSetCookie = 27,
				HttpHeaderVary = 28,
				HttpHeaderWwwAuthenticate = 29,
				HttpHeaderResponseMaximum = 30,
				HttpHeaderMaximum = 41
			}

			internal static int IndexOfKnownHeader(string HeaderName)
			{
				throw null;
			}
		}

		internal const int MaxTimeout = 6;

		internal static readonly string[] HttpVerbs;
	}
}
