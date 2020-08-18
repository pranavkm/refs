using Microsoft.AspNetCore.Http.Headers;
using System;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.Http
{
	public static class HeaderDictionaryTypeExtensions
	{
		public static RequestHeaders GetTypedHeaders(this HttpRequest request)
		{
			throw null;
		}

		public static ResponseHeaders GetTypedHeaders(this HttpResponse response)
		{
			throw null;
		}

		internal static DateTimeOffset? GetDate(this IHeaderDictionary headers, string name)
		{
			throw null;
		}

		internal static void Set(this IHeaderDictionary headers, string name, object value)
		{
			throw null;
		}

		internal static void SetList<T>(this IHeaderDictionary headers, string name, IList<T> values)
		{
			throw null;
		}

		public static void AppendList<T>(this IHeaderDictionary Headers, string name, IList<T> values)
		{
			throw null;
		}

		internal static void SetDate(this IHeaderDictionary headers, string name, DateTimeOffset? value)
		{
			throw null;
		}

		internal static T Get<T>(this IHeaderDictionary headers, string name)
		{
			throw null;
		}

		internal static IList<T> GetList<T>(this IHeaderDictionary headers, string name)
		{
			throw null;
		}
	}
}
