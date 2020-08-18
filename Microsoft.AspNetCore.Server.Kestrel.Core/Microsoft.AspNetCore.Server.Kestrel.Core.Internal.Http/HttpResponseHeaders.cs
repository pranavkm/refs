using Microsoft.Extensions.Primitives;
using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.IO.Pipelines;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http
{
	internal sealed class HttpResponseHeaders : HttpHeaders
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

			public StringValues _AcceptRanges;

			public StringValues _Age;

			public StringValues _AltSvc;

			public StringValues _ETag;

			public StringValues _Location;

			public StringValues _ProxyAuthenticate;

			public StringValues _RetryAfter;

			public StringValues _Server;

			public StringValues _SetCookie;

			public StringValues _Vary;

			public StringValues _WWWAuthenticate;

			public StringValues _AccessControlAllowCredentials;

			public StringValues _AccessControlAllowHeaders;

			public StringValues _AccessControlAllowMethods;

			public StringValues _AccessControlAllowOrigin;

			public StringValues _AccessControlExposeHeaders;

			public StringValues _AccessControlMaxAge;

			public byte[] _rawConnection;

			public byte[] _rawDate;

			public byte[] _rawTransferEncoding;

			public byte[] _rawServer;
		}

		public struct Enumerator : IEnumerator<KeyValuePair<string, StringValues>>, IEnumerator, IDisposable
		{
			private readonly HttpResponseHeaders _collection;

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

			internal Enumerator(HttpResponseHeaders collection)
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

		public bool HasDate
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

		public bool HasServer
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

		public StringValues HeaderAcceptRanges
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

		public StringValues HeaderAge
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

		public StringValues HeaderAltSvc
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

		public StringValues HeaderETag
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

		public StringValues HeaderLocation
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

		public StringValues HeaderProxyAuthenticate
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

		public StringValues HeaderRetryAfter
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

		public StringValues HeaderServer
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

		public StringValues HeaderSetCookie
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

		public StringValues HeaderVary
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

		public StringValues HeaderWWWAuthenticate
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

		public StringValues HeaderAccessControlAllowCredentials
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

		public StringValues HeaderAccessControlAllowHeaders
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

		public StringValues HeaderAccessControlAllowMethods
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

		public StringValues HeaderAccessControlAllowOrigin
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

		public StringValues HeaderAccessControlExposeHeaders
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

		public StringValues HeaderAccessControlMaxAge
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

		public void SetRawConnection(StringValues value, byte[] raw)
		{
			throw null;
		}

		public void SetRawDate(StringValues value, byte[] raw)
		{
			throw null;
		}

		public void SetRawTransferEncoding(StringValues value, byte[] raw)
		{
			throw null;
		}

		public void SetRawServer(StringValues value, byte[] raw)
		{
			throw null;
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

		protected override void ClearFast()
		{
			throw null;
		}

		protected override bool CopyToFast(KeyValuePair<string, StringValues>[] array, int arrayIndex)
		{
			throw null;
		}

		internal void CopyToFast(ref BufferWriter<PipeWriter> output)
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

		internal void CopyTo(ref BufferWriter<PipeWriter> buffer)
		{
			throw null;
		}

		public HttpResponseHeaders()
		{
			throw null;
		}
	}
}
