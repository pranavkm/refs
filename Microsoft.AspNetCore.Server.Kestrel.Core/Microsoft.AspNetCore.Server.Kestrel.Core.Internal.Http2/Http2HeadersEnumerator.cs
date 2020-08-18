using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http2
{
	internal sealed class Http2HeadersEnumerator : IEnumerator<KeyValuePair<string, string>>, IEnumerator, IDisposable
	{
		private enum HeadersType : byte
		{
			Headers,
			Trailers,
			Untyped
		}

		public int HPackStaticTableId
		{
			get
			{
				throw null;
			}
		}

		public KeyValuePair<string, string> Current
		{
			[CompilerGenerated]
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

		public Http2HeadersEnumerator()
		{
			throw null;
		}

		public void Initialize(HttpResponseHeaders headers)
		{
			throw null;
		}

		public void Initialize(HttpResponseTrailers headers)
		{
			throw null;
		}

		public void Initialize(IDictionary<string, StringValues> headers)
		{
			throw null;
		}

		public bool MoveNext()
		{
			throw null;
		}

		public void Reset()
		{
			throw null;
		}

		public void Dispose()
		{
			throw null;
		}

		internal static int GetResponseHeaderStaticTableId(KnownHeaderType responseHeaderType)
		{
			throw null;
		}
	}
}
