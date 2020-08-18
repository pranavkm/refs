using Microsoft.Net.Http.Headers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Http.Headers
{
	public class ResponseHeaders
	{
		public IHeaderDictionary Headers
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public CacheControlHeaderValue CacheControl
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

		public ContentDispositionHeaderValue ContentDisposition
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

		public ContentRangeHeaderValue ContentRange
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

		public MediaTypeHeaderValue ContentType
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

		public DateTimeOffset? Date
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

		public EntityTagHeaderValue ETag
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

		public DateTimeOffset? Expires
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

		public DateTimeOffset? LastModified
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

		public Uri Location
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

		public IList<SetCookieHeaderValue> SetCookie
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

		public ResponseHeaders(IHeaderDictionary headers)
		{
			throw null;
		}

		/// <summary>
		/// Gets the value of header with <paramref name="name" />.
		/// </summary>
		/// <remarks><typeparamref name="T" /> must contain a TryParse method with the signature <c>public static bool TryParse(string, out T)</c>.</remarks>
		/// <typeparam name="T">The type of the header.
		/// The given type must have a static TryParse method.</typeparam>
		/// <param name="name">The name of the header to retrieve.</param>
		/// <returns>The value of the header.</returns>
		public T Get<T>(string name)
		{
			throw null;
		}

		/// <summary>
		/// Gets the values of header with <paramref name="name" />.
		/// </summary>
		/// <remarks><typeparamref name="T" /> must contain a TryParseList method with the signature <c>public static bool TryParseList(IList&lt;string&gt;, out IList&lt;T&gt;)</c>.</remarks>
		/// <typeparam name="T">The type of the header.
		/// The given type must have a static TryParseList method.</typeparam>
		/// <param name="name">The name of the header to retrieve.</param>
		/// <returns>List of values of the header.</returns>
		public IList<T> GetList<T>(string name)
		{
			throw null;
		}

		public void Set(string name, object value)
		{
			throw null;
		}

		public void SetList<T>(string name, IList<T> values)
		{
			throw null;
		}

		public void Append(string name, object value)
		{
			throw null;
		}

		public void AppendList<T>(string name, IList<T> values)
		{
			throw null;
		}
	}
}
