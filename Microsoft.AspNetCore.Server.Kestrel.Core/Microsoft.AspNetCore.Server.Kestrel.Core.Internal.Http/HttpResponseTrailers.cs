using Microsoft.Extensions.Primitives;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http
{
	internal class HttpResponseTrailers : HttpHeaders
	{
		private struct HeaderReferences
		{
			public StringValues _ETag;

			public StringValues _GrpcMessage;

			public StringValues _GrpcStatus;
		}

		public struct Enumerator : IEnumerator<KeyValuePair<string, StringValues>>, IEnumerator, IDisposable
		{
			private readonly HttpResponseTrailers _collection;

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

			internal Enumerator(HttpResponseTrailers collection)
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

		public StringValues HeaderGrpcMessage
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

		public StringValues HeaderGrpcStatus
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

		public Enumerator GetEnumerator()
		{
			throw null;
		}

		protected override IEnumerator<KeyValuePair<string, StringValues>> GetEnumeratorFast()
		{
			throw null;
		}

		public HttpResponseTrailers()
		{
			throw null;
		}
	}
}
