using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http
{
	internal abstract class HttpHeaders : IHeaderDictionary, IDictionary<string, StringValues>, ICollection<KeyValuePair<string, StringValues>>, IEnumerable<KeyValuePair<string, StringValues>>, IEnumerable
	{
		protected long _bits;

		protected long? _contentLength;

		protected bool _isReadOnly;

		protected Dictionary<string, StringValues> MaybeUnknown;

		protected Dictionary<string, StringValues> Unknown
		{
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
			set
			{
				throw null;
			}
		}

		StringValues IHeaderDictionary.this[string key]
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

		StringValues IDictionary<string, StringValues>.this[string key]
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

		public int Count
		{
			get
			{
				throw null;
			}
		}

		bool ICollection<KeyValuePair<string, StringValues>>.IsReadOnly
		{
			get
			{
				throw null;
			}
		}

		ICollection<string> IDictionary<string, StringValues>.Keys
		{
			get
			{
				throw null;
			}
		}

		ICollection<StringValues> IDictionary<string, StringValues>.Values
		{
			get
			{
				throw null;
			}
		}

		protected static void ThrowHeadersReadOnlyException()
		{
			throw null;
		}

		protected static void ThrowArgumentException()
		{
			throw null;
		}

		protected static void ThrowKeyNotFoundException()
		{
			throw null;
		}

		protected static void ThrowDuplicateKeyException()
		{
			throw null;
		}

		public void SetReadOnly()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Reset()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static StringValues AppendValue(StringValues existing, string append)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected bool TryGetUnknown(string key, ref StringValues value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected bool RemoveUnknown(string key)
		{
			throw null;
		}

		protected virtual int GetCountFast()
		{
			throw null;
		}

		protected virtual bool TryGetValueFast(string key, out StringValues value)
		{
			throw null;
		}

		protected virtual void SetValueFast(string key, StringValues value)
		{
			throw null;
		}

		protected virtual bool AddValueFast(string key, StringValues value)
		{
			throw null;
		}

		protected virtual bool RemoveFast(string key)
		{
			throw null;
		}

		protected virtual void ClearFast()
		{
			throw null;
		}

		protected virtual bool CopyToFast(KeyValuePair<string, StringValues>[] array, int arrayIndex)
		{
			throw null;
		}

		protected virtual IEnumerator<KeyValuePair<string, StringValues>> GetEnumeratorFast()
		{
			throw null;
		}

		void ICollection<KeyValuePair<string, StringValues>>.Add(KeyValuePair<string, StringValues> item)
		{
			throw null;
		}

		void IDictionary<string, StringValues>.Add(string key, StringValues value)
		{
			throw null;
		}

		void ICollection<KeyValuePair<string, StringValues>>.Clear()
		{
			throw null;
		}

		bool ICollection<KeyValuePair<string, StringValues>>.Contains(KeyValuePair<string, StringValues> item)
		{
			throw null;
		}

		bool IDictionary<string, StringValues>.ContainsKey(string key)
		{
			throw null;
		}

		void ICollection<KeyValuePair<string, StringValues>>.CopyTo(KeyValuePair<string, StringValues>[] array, int arrayIndex)
		{
			throw null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw null;
		}

		IEnumerator<KeyValuePair<string, StringValues>> IEnumerable<KeyValuePair<string, StringValues>>.GetEnumerator()
		{
			throw null;
		}

		bool ICollection<KeyValuePair<string, StringValues>>.Remove(KeyValuePair<string, StringValues> item)
		{
			throw null;
		}

		bool IDictionary<string, StringValues>.Remove(string key)
		{
			throw null;
		}

		bool IDictionary<string, StringValues>.TryGetValue(string key, out StringValues value)
		{
			throw null;
		}

		public static void ValidateHeaderValueCharacters(StringValues headerValues)
		{
			throw null;
		}

		public static void ValidateHeaderValueCharacters(string headerCharacters)
		{
			throw null;
		}

		public static void ValidateHeaderNameCharacters(string headerCharacters)
		{
			throw null;
		}

		public static ConnectionOptions ParseConnection(StringValues connection)
		{
			throw null;
		}

		public static TransferCoding GetFinalTransferCoding(StringValues transferEncoding)
		{
			throw null;
		}

		protected HttpHeaders()
		{
			throw null;
		}
	}
}
