using Microsoft.Extensions.Primitives;

namespace Microsoft.AspNetCore.Http
{
	public static class HeaderDictionaryExtensions
	{
		/// <summary>
		/// Add new values. Each item remains a separate array entry.
		/// </summary>
		/// <param name="headers">The <see cref="T:Microsoft.AspNetCore.Http.IHeaderDictionary" /> to use.</param>
		/// <param name="key">The header name.</param>
		/// <param name="value">The header value.</param>
		public static void Append(this IHeaderDictionary headers, string key, StringValues value)
		{
			throw null;
		}

		/// <summary>
		/// Quotes any values containing commas, and then comma joins all of the values with any existing values.
		/// </summary>
		/// <param name="headers">The <see cref="T:Microsoft.AspNetCore.Http.IHeaderDictionary" /> to use.</param>
		/// <param name="key">The header name.</param>
		/// <param name="values">The header values.</param>
		public static void AppendCommaSeparatedValues(this IHeaderDictionary headers, string key, params string[] values)
		{
			throw null;
		}

		/// <summary>
		/// Get the associated values from the collection separated into individual values.
		/// Quoted values will not be split, and the quotes will be removed.
		/// </summary>
		/// <param name="headers">The <see cref="T:Microsoft.AspNetCore.Http.IHeaderDictionary" /> to use.</param>
		/// <param name="key">The header name.</param>
		/// <returns>the associated values from the collection separated into individual values, or StringValues.Empty if the key is not present.</returns>
		public static string[] GetCommaSeparatedValues(this IHeaderDictionary headers, string key)
		{
			throw null;
		}

		/// <summary>
		/// Quotes any values containing commas, and then comma joins all of the values.
		/// </summary>
		/// <param name="headers">The <see cref="T:Microsoft.AspNetCore.Http.IHeaderDictionary" /> to use.</param>
		/// <param name="key">The header name.</param>
		/// <param name="values">The header values.</param>
		public static void SetCommaSeparatedValues(this IHeaderDictionary headers, string key, params string[] values)
		{
			throw null;
		}
	}
}
