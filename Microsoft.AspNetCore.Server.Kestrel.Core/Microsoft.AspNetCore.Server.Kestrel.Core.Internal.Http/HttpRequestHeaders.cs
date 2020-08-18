using Microsoft.Extensions.Primitives;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http
{
	internal sealed class HttpRequestHeaders : HttpHeaders
	{
		private struct HeaderReferences
		{
			public StringValues _CacheControl;

			public StringValues _Connection;

			public StringValues _Date;

			public StringValues _GrpcEncoding;

			public StringValues _KeepAlive;

			public StringValues _Pragma;

			public StringValues _Trailer;

			public StringValues _TransferEncoding;

			public StringValues _Upgrade;

			public StringValues _Via;

			public StringValues _Warning;

			public StringValues _Allow;

			public StringValues _ContentType;

			public StringValues _ContentEncoding;

			public StringValues _ContentLanguage;

			public StringValues _ContentLocation;

			public StringValues _ContentMD5;

			public StringValues _ContentRange;

			public StringValues _Expires;

			public StringValues _LastModified;

			public StringValues _Authority;

			public StringValues _Method;

			public StringValues _Path;

			public StringValues _Scheme;

			public StringValues _Accept;

			public StringValues _AcceptCharset;

			public StringValues _AcceptEncoding;

			public StringValues _AcceptLanguage;

			public StringValues _Authorization;

			public StringValues _Cookie;

			public StringValues _Expect;

			public StringValues _From;

			public StringValues _GrpcAcceptEncoding;

			public StringValues _GrpcTimeout;

			public StringValues _Host;

			public StringValues _IfMatch;

			public StringValues _IfModifiedSince;

			public StringValues _IfNoneMatch;

			public StringValues _IfRange;

			public StringValues _IfUnmodifiedSince;

			public StringValues _MaxForwards;

			public StringValues _ProxyAuthorization;

			public StringValues _Referer;

			public StringValues _Range;

			public StringValues _TE;

			public StringValues _Translate;

			public StringValues _UserAgent;

			public StringValues _DNT;

			public StringValues _UpgradeInsecureRequests;

			public StringValues _RequestId;

			public StringValues _CorrelationContext;

			public StringValues _TraceParent;

			public StringValues _TraceState;

			public StringValues _Origin;

			public StringValues _AccessControlRequestMethod;

			public StringValues _AccessControlRequestHeaders;
		}

		public struct Enumerator : IEnumerator<KeyValuePair<string, StringValues>>, IEnumerator, IDisposable
		{
			private readonly HttpRequestHeaders _collection;

			private readonly long _bits;

			private int _next;

			private KeyValuePair<string, StringValues> _current;

			private KnownHeaderType _currentKnownType;

			private readonly bool _hasUnknown;

			private Dictionary<string, StringValues>.Enumerator _unknownEnumerator;

			public KeyValuePair<string, StringValues> Current
			{
				get
				{
					throw null;
				}
			}

			internal KnownHeaderType CurrentKnownType
			{
				get
				{
					throw null;
				}
			}

			object IEnumerator.Current
			{
				get
				{
					throw null;
				}
			}

			public bool MoveNext()
			{
				throw null;
			}

			internal Enumerator(HttpRequestHeaders collection)
			{
				throw null;
			}

			public void Dispose()
			{
				throw null;
			}

			public void Reset()
			{
				throw null;
			}
		}

		public bool HasConnection
		{
			get
			{
				throw null;
			}
		}

		public bool HasTransferEncoding
		{
			get
			{
				throw null;
			}
		}

		public int HostCount
		{
			get
			{
				throw null;
			}
		}

		public StringValues HeaderCacheControl
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

		public StringValues HeaderConnection
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

		public StringValues HeaderDate
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

		public StringValues HeaderGrpcEncoding
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

		public StringValues HeaderKeepAlive
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

		public StringValues HeaderPragma
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

		public StringValues HeaderTrailer
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

		public StringValues HeaderTransferEncoding
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

		public StringValues HeaderUpgrade
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

		public StringValues HeaderVia
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

		public StringValues HeaderWarning
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

		public StringValues HeaderAllow
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

		public StringValues HeaderContentType
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

		public StringValues HeaderContentEncoding
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

		public StringValues HeaderContentLanguage
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

		public StringValues HeaderContentLocation
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

		public StringValues HeaderContentMD5
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

		public StringValues HeaderContentRange
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

		public StringValues HeaderExpires
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

		public StringValues HeaderLastModified
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

		public StringValues HeaderAuthority
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

		public StringValues HeaderMethod
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

		public StringValues HeaderPath
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

		public StringValues HeaderScheme
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

		public StringValues HeaderAccept
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

		public StringValues HeaderAcceptCharset
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

		public StringValues HeaderAcceptEncoding
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

		public StringValues HeaderAcceptLanguage
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

		public StringValues HeaderAuthorization
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

		public StringValues HeaderCookie
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

		public StringValues HeaderExpect
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

		public StringValues HeaderFrom
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

		public StringValues HeaderGrpcAcceptEncoding
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

		public StringValues HeaderGrpcTimeout
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

		public StringValues HeaderHost
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

		public StringValues HeaderIfMatch
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

		public StringValues HeaderIfModifiedSince
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

		public StringValues HeaderIfNoneMatch
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

		public StringValues HeaderIfRange
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

		public StringValues HeaderIfUnmodifiedSince
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

		public StringValues HeaderMaxForwards
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

		public StringValues HeaderProxyAuthorization
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

		public StringValues HeaderReferer
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

		public StringValues HeaderRange
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

		public StringValues HeaderTE
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

		public StringValues HeaderTranslate
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

		public StringValues HeaderUserAgent
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

		public StringValues HeaderDNT
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

		public StringValues HeaderUpgradeInsecureRequests
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

		public StringValues HeaderRequestId
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

		public StringValues HeaderCorrelationContext
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

		public StringValues HeaderTraceParent
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

		public StringValues HeaderTraceState
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

		public StringValues HeaderOrigin
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

		public StringValues HeaderAccessControlRequestMethod
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

		public StringValues HeaderAccessControlRequestHeaders
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

		public StringValues HeaderContentLength
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

		public bool ReuseHeaderValues
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

		public Func<string, Encoding> EncodingSelector
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

		protected override int GetCountFast()
		{
			throw null;
		}

		protected override bool TryGetValueFast(string key, out StringValues value)
		{
			throw null;
		}

		protected override void SetValueFast(string key, StringValues value)
		{
			throw null;
		}

		protected override bool AddValueFast(string key, StringValues value)
		{
			throw null;
		}

		protected override bool RemoveFast(string key)
		{
			throw null;
		}

		protected override bool CopyToFast(KeyValuePair<string, StringValues>[] array, int arrayIndex)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		public void Append(ReadOnlySpan<byte> name, ReadOnlySpan<byte> value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		public bool TryHPackAppend(int index, ReadOnlySpan<byte> value)
		{
			throw null;
		}

		public HttpRequestHeaders(bool reuseHeaderValues = true, Func<string, Encoding> encodingSelector = null)
		{
			throw null;
		}

		public void OnHeadersComplete()
		{
			throw null;
		}

		protected override void ClearFast()
		{
			throw null;
		}

		public Enumerator GetEnumerator()
		{
			throw null;
		}

		protected override IEnumerator<KeyValuePair<string, StringValues>> GetEnumeratorFast()
		{
			throw null;
		}
	}
}
