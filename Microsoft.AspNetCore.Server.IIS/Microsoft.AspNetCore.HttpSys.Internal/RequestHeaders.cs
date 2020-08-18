using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.HttpSys.Internal
{
	[GeneratedCode("TextTemplatingFileGenerator", "")]
	internal class RequestHeaders : IHeaderDictionary, IDictionary<string, StringValues>, ICollection<KeyValuePair<string, StringValues>>, IEnumerable<KeyValuePair<string, StringValues>>, IEnumerable
	{
		public bool IsReadOnly
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			internal set
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

		public ICollection<string> Keys
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

		long? IHeaderDictionary.ContentLength
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

		public StringValues this[string key]
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

		internal StringValues Accept
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

		internal StringValues AcceptCharset
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

		internal StringValues AcceptEncoding
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

		internal StringValues AcceptLanguage
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

		internal StringValues Allow
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

		internal StringValues Authorization
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

		internal StringValues CacheControl
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

		internal StringValues Connection
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

		internal StringValues ContentEncoding
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

		internal StringValues ContentLanguage
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

		internal StringValues ContentLength
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

		internal StringValues ContentLocation
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

		internal StringValues ContentMd5
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

		internal StringValues ContentRange
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

		internal StringValues ContentType
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

		internal StringValues Cookie
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

		internal StringValues Date
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

		internal StringValues Expect
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

		internal StringValues Expires
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

		internal StringValues From
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

		internal StringValues Host
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

		internal StringValues IfMatch
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

		internal StringValues IfModifiedSince
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

		internal StringValues IfNoneMatch
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

		internal StringValues IfRange
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

		internal StringValues IfUnmodifiedSince
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

		internal StringValues KeepAlive
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

		internal StringValues LastModified
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

		internal StringValues MaxForwards
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

		internal StringValues Pragma
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

		internal StringValues ProxyAuthorization
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

		internal StringValues Range
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

		internal StringValues Referer
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

		internal StringValues Te
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

		internal StringValues Trailer
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

		internal StringValues TransferEncoding
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

		internal StringValues Translate
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

		internal StringValues Upgrade
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

		internal StringValues UserAgent
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

		internal StringValues Via
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

		internal StringValues Warning
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

		internal RequestHeaders(NativeRequestContext requestMemoryBlob)
		{
			throw null;
		}

		void IDictionary<string, StringValues>.Add(string key, StringValues value)
		{
			throw null;
		}

		public bool ContainsKey(string key)
		{
			throw null;
		}

		public bool Remove(string key)
		{
			throw null;
		}

		public bool TryGetValue(string key, out StringValues value)
		{
			throw null;
		}

		void ICollection<KeyValuePair<string, StringValues>>.Add(KeyValuePair<string, StringValues> item)
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

		void ICollection<KeyValuePair<string, StringValues>>.CopyTo(KeyValuePair<string, StringValues>[] array, int arrayIndex)
		{
			throw null;
		}

		bool ICollection<KeyValuePair<string, StringValues>>.Remove(KeyValuePair<string, StringValues> item)
		{
			throw null;
		}

		IEnumerator<KeyValuePair<string, StringValues>> IEnumerable<KeyValuePair<string, StringValues>>.GetEnumerator()
		{
			throw null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw null;
		}

		public IEnumerable<string> GetValues(string key)
		{
			throw null;
		}
	}
}
