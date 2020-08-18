using System;
using System.Globalization;

namespace Microsoft.AspNetCore.Components
{
	/// <summary>
	/// Performs conversions during binding.
	/// </summary>
	public static class BindConverter
	{
		private delegate object? BindFormatter<T>(T value, CultureInfo? culture);

		private delegate object BindFormatterWithFormat<T>(T value, CultureInfo? culture, string format);

		internal delegate bool BindParser<T>(object? obj, CultureInfo? culture, out T value);

		internal delegate bool BindParserWithFormat<T>(object? obj, CultureInfo? culture, string? format, out T value);

		private static class FormatterDelegateCache
		{
			public static BindFormatter<T> Get<T>()
			{
				throw null;
			}
		}

		internal static class ParserDelegateCache
		{
			public static BindParser<T> Get<T>()
			{
				throw null;
			}
		}

		internal static readonly BindParser<string?> ConvertToString;

		internal static readonly BindParser<bool> ConvertToBool;

		internal static readonly BindParser<bool?> ConvertToNullableBool;

		internal static BindParser<int> ConvertToInt;

		internal static BindParser<int?> ConvertToNullableInt;

		internal static BindParser<long> ConvertToLong;

		internal static BindParser<long?> ConvertToNullableLong;

		internal static BindParser<short> ConvertToShort;

		internal static BindParser<short?> ConvertToNullableShort;

		internal static BindParser<float> ConvertToFloat;

		internal static BindParser<float?> ConvertToNullableFloat;

		internal static BindParser<double> ConvertToDoubleDelegate;

		internal static BindParser<double?> ConvertToNullableDoubleDelegate;

		internal static BindParser<decimal> ConvertToDecimal;

		internal static BindParser<decimal?> ConvertToNullableDecimal;

		internal static BindParser<DateTime> ConvertToDateTime;

		internal static BindParserWithFormat<DateTime> ConvertToDateTimeWithFormat;

		internal static BindParser<DateTime?> ConvertToNullableDateTime;

		internal static BindParserWithFormat<DateTime?> ConvertToNullableDateTimeWithFormat;

		internal static BindParser<DateTimeOffset> ConvertToDateTimeOffset;

		internal static BindParserWithFormat<DateTimeOffset> ConvertToDateTimeOffsetWithFormat;

		internal static BindParser<DateTimeOffset?> ConvertToNullableDateTimeOffset;

		internal static BindParserWithFormat<DateTimeOffset?> ConvertToNullableDateTimeOffsetWithFormat;

		/// <summary>
		/// Formats the provided <paramref name="value" /> as a <see cref="T:System.String" />.
		/// </summary>
		/// <param name="value">The value to format.</param>
		/// <param name="culture">
		/// The <see cref="T:System.Globalization.CultureInfo" /> to use while formatting. Defaults to <see cref="P:System.Globalization.CultureInfo.CurrentCulture" />.
		/// </param>
		/// <returns>The formatted value.</returns>
		public static string? FormatValue(string? value, CultureInfo? culture = null)
		{
			throw null;
		}

		/// <summary>
		/// Formats the provided <paramref name="value" /> for inclusion in an attribute.
		/// </summary>
		/// <param name="value">The value to format.</param>
		/// <param name="culture">
		/// The <see cref="T:System.Globalization.CultureInfo" /> to use while formatting. Defaults to <see cref="P:System.Globalization.CultureInfo.CurrentCulture" />.
		/// </param>
		/// <returns>The formatted value.</returns>
		public static bool FormatValue(bool value, CultureInfo? culture = null)
		{
			throw null;
		}

		/// <summary>
		/// Formats the provided <paramref name="value" /> for inclusion in an attribute.
		/// </summary>
		/// <param name="value">The value to format.</param>
		/// <param name="culture">
		/// The <see cref="T:System.Globalization.CultureInfo" /> to use while formatting. Defaults to <see cref="P:System.Globalization.CultureInfo.CurrentCulture" />.
		/// </param>
		/// <returns>The formatted value.</returns>
		public static bool? FormatValue(bool? value, CultureInfo? culture = null)
		{
			throw null;
		}

		/// <summary>
		/// Formats the provided <paramref name="value" /> for inclusion in an attribute.
		/// </summary>
		/// <param name="value">The value to format.</param>
		/// <param name="culture">
		/// The <see cref="T:System.Globalization.CultureInfo" /> to use while formatting. Defaults to <see cref="P:System.Globalization.CultureInfo.CurrentCulture" />.
		/// </param>
		/// <returns>The formatted value.</returns>
		public static string? FormatValue(int value, CultureInfo? culture = null)
		{
			throw null;
		}

		/// <summary>
		/// Formats the provided <paramref name="value" /> for inclusion in an attribute.
		/// </summary>
		/// <param name="value">The value to format.</param>
		/// <param name="culture">
		/// The <see cref="T:System.Globalization.CultureInfo" /> to use while formatting. Defaults to <see cref="P:System.Globalization.CultureInfo.CurrentCulture" />.
		/// </param>
		/// <returns>The formatted value.</returns>
		public static string? FormatValue(int? value, CultureInfo? culture = null)
		{
			throw null;
		}

		/// <summary>
		/// Formats the provided <paramref name="value" /> for inclusion in an attribute.
		/// </summary>
		/// <param name="value">The value to format.</param>
		/// <param name="culture">
		/// The <see cref="T:System.Globalization.CultureInfo" /> to use while formatting. Defaults to <see cref="P:System.Globalization.CultureInfo.CurrentCulture" />.
		/// </param>
		/// <returns>The formatted value.</returns>
		public static string FormatValue(long value, CultureInfo? culture = null)
		{
			throw null;
		}

		/// <summary>
		/// Formats the provided <paramref name="value" /> for inclusion in an attribute.
		/// </summary>
		/// <param name="value">The value to format.</param>
		/// <param name="culture">
		/// The <see cref="T:System.Globalization.CultureInfo" /> to use while formatting. Defaults to <see cref="P:System.Globalization.CultureInfo.CurrentCulture" />.
		/// </param>
		/// <returns>The formatted value.</returns>
		public static string? FormatValue(long? value, CultureInfo? culture = null)
		{
			throw null;
		}

		/// <summary>
		/// Formats the provided <paramref name="value" /> for inclusion in an attribute.
		/// </summary>
		/// <param name="value">The value to format.</param>
		/// <param name="culture">
		/// The <see cref="T:System.Globalization.CultureInfo" /> to use while formatting. Defaults to <see cref="P:System.Globalization.CultureInfo.CurrentCulture" />.
		/// </param>
		/// <returns>The formatted value.</returns>
		public static string FormatValue(short value, CultureInfo? culture = null)
		{
			throw null;
		}

		/// <summary>
		/// Formats the provided <paramref name="value" /> for inclusion in an attribute.
		/// </summary>
		/// <param name="value">The value to format.</param>
		/// <param name="culture">
		/// The <see cref="T:System.Globalization.CultureInfo" /> to use while formatting. Defaults to <see cref="P:System.Globalization.CultureInfo.CurrentCulture" />.
		/// </param>
		/// <returns>The formatted value.</returns>
		public static string? FormatValue(short? value, CultureInfo? culture = null)
		{
			throw null;
		}

		/// <summary>
		/// Formats the provided <paramref name="value" /> for inclusion in an attribute.
		/// </summary>
		/// <param name="value">The value to format.</param>
		/// <param name="culture">
		/// The <see cref="T:System.Globalization.CultureInfo" /> to use while formatting. Defaults to <see cref="P:System.Globalization.CultureInfo.CurrentCulture" />.
		/// </param>
		/// <returns>The formatted value.</returns>
		public static string FormatValue(float value, CultureInfo? culture = null)
		{
			throw null;
		}

		/// <summary>
		/// Formats the provided <paramref name="value" /> for inclusion in an attribute.
		/// </summary>
		/// <param name="value">The value to format.</param>
		/// <param name="culture">
		/// The <see cref="T:System.Globalization.CultureInfo" /> to use while formatting. Defaults to <see cref="P:System.Globalization.CultureInfo.CurrentCulture" />.
		/// </param>
		/// <returns>The formatted value.</returns>
		public static string? FormatValue(float? value, CultureInfo? culture = null)
		{
			throw null;
		}

		/// <summary>
		/// Formats the provided <paramref name="value" /> for inclusion in an attribute.
		/// </summary>
		/// <param name="value">The value to format.</param>
		/// <param name="culture">
		/// The <see cref="T:System.Globalization.CultureInfo" /> to use while formatting. Defaults to <see cref="P:System.Globalization.CultureInfo.CurrentCulture" />.
		/// </param>
		/// <returns>The formatted value.</returns>
		public static string? FormatValue(double value, CultureInfo? culture = null)
		{
			throw null;
		}

		/// <summary>
		/// Formats the provided <paramref name="value" /> for inclusion in an attribute.
		/// </summary>
		/// <param name="value">The value to format.</param>
		/// <param name="culture">
		/// The <see cref="T:System.Globalization.CultureInfo" /> to use while formatting. Defaults to <see cref="P:System.Globalization.CultureInfo.CurrentCulture" />.
		/// </param>
		/// <returns>The formatted value.</returns>
		public static string? FormatValue(double? value, CultureInfo? culture = null)
		{
			throw null;
		}

		/// <summary>
		/// Formats the provided <paramref name="value" /> for inclusion in an attribute.
		/// </summary>
		/// <param name="value">The value to format.</param>
		/// <param name="culture">
		/// The <see cref="T:System.Globalization.CultureInfo" /> to use while formatting. Defaults to <see cref="P:System.Globalization.CultureInfo.CurrentCulture" />.
		/// </param>
		/// <returns>The formatted value.</returns>
		public static string FormatValue(decimal value, CultureInfo? culture = null)
		{
			throw null;
		}

		/// <summary>
		/// Formats the provided <paramref name="value" /> as a <see cref="T:System.String" />.
		/// </summary>
		/// <param name="value">The value to format.</param>
		/// <param name="culture">
		/// The <see cref="T:System.Globalization.CultureInfo" /> to use while formatting. Defaults to <see cref="P:System.Globalization.CultureInfo.CurrentCulture" />.
		/// </param>
		/// <returns>The formatted value.</returns>
		public static string? FormatValue(decimal? value, CultureInfo? culture = null)
		{
			throw null;
		}

		/// <summary>
		/// Formats the provided <paramref name="value" /> as a <see cref="T:System.String" />.
		/// </summary>
		/// <param name="value">The value to format.</param>
		/// <param name="culture">
		/// The <see cref="T:System.Globalization.CultureInfo" /> to use while formatting. Defaults to <see cref="P:System.Globalization.CultureInfo.CurrentCulture" />.
		/// </param>
		/// <returns>The formatted value.</returns>
		public static string FormatValue(DateTime value, CultureInfo? culture = null)
		{
			throw null;
		}

		/// <summary>
		/// Formats the provided <paramref name="value" /> as a <see cref="T:System.String" />.
		/// </summary>
		/// <param name="value">The value to format.</param>
		/// <param name="format">The format to use. Provided to <see cref="M:System.DateTimeOffset.ToString(System.String,System.IFormatProvider)" />.</param>
		/// <param name="culture">
		/// The <see cref="T:System.Globalization.CultureInfo" /> to use while formatting. Defaults to <see cref="P:System.Globalization.CultureInfo.CurrentCulture" />.
		/// </param>
		/// <returns>The formatted value.</returns>
		public static string FormatValue(DateTime value, string format, CultureInfo? culture = null)
		{
			throw null;
		}

		/// <summary>
		/// Formats the provided <paramref name="value" /> as a <see cref="T:System.String" />.
		/// </summary>
		/// <param name="value">The value to format.</param>
		/// <param name="culture">
		/// The <see cref="T:System.Globalization.CultureInfo" /> to use while formatting. Defaults to <see cref="P:System.Globalization.CultureInfo.CurrentCulture" />.
		/// </param>
		/// <returns>The formatted value.</returns>
		public static string? FormatValue(DateTime? value, CultureInfo? culture = null)
		{
			throw null;
		}

		/// <summary>
		/// Formats the provided <paramref name="value" /> as a <see cref="T:System.String" />.
		/// </summary>
		/// <param name="value">The value to format.</param>
		/// <param name="format">The format to use. Provided to <see cref="M:System.DateTime.ToString(System.String,System.IFormatProvider)" />.</param>
		/// <param name="culture">
		/// The <see cref="T:System.Globalization.CultureInfo" /> to use while formatting. Defaults to <see cref="P:System.Globalization.CultureInfo.CurrentCulture" />.
		/// </param>
		/// <returns>The formatted value.</returns>
		public static string? FormatValue(DateTime? value, string? format, CultureInfo? culture = null)
		{
			throw null;
		}

		/// <summary>
		/// Formats the provided <paramref name="value" /> as a <see cref="T:System.String" />.
		/// </summary>
		/// <param name="value">The value to format.</param>
		/// <param name="culture">
		/// The <see cref="T:System.Globalization.CultureInfo" /> to use while formatting. Defaults to <see cref="P:System.Globalization.CultureInfo.CurrentCulture" />.
		/// </param>
		/// <returns>The formatted value.</returns>
		public static string FormatValue(DateTimeOffset value, CultureInfo? culture = null)
		{
			throw null;
		}

		/// <summary>
		/// Formats the provided <paramref name="value" /> as a <see cref="T:System.String" />.
		/// </summary>
		/// <param name="value">The value to format.</param>
		/// <param name="format">The format to use. Provided to <see cref="M:System.DateTimeOffset.ToString(System.String,System.IFormatProvider)" />.</param>
		/// <param name="culture">
		/// The <see cref="T:System.Globalization.CultureInfo" /> to use while formatting. Defaults to <see cref="P:System.Globalization.CultureInfo.CurrentCulture" />.
		/// </param>
		/// <returns>The formatted value.</returns>
		public static string FormatValue(DateTimeOffset value, string format, CultureInfo? culture = null)
		{
			throw null;
		}

		/// <summary>
		/// Formats the provided <paramref name="value" /> as a <see cref="T:System.String" />.
		/// </summary>
		/// <param name="value">The value to format.</param>
		/// <param name="culture">
		/// The <see cref="T:System.Globalization.CultureInfo" /> to use while formatting. Defaults to <see cref="P:System.Globalization.CultureInfo.CurrentCulture" />.
		/// </param>
		/// <returns>The formatted value.</returns>
		public static string? FormatValue(DateTimeOffset? value, CultureInfo? culture = null)
		{
			throw null;
		}

		/// <summary>
		/// Formats the provided <paramref name="value" /> as a <see cref="T:System.String" />.
		/// </summary>
		/// <param name="value">The value to format.</param>
		/// <param name="format">The format to use. Provided to <see cref="M:System.DateTimeOffset.ToString(System.String,System.IFormatProvider)" />.</param>
		/// <param name="culture">
		/// The <see cref="T:System.Globalization.CultureInfo" /> to use while formatting. Defaults to <see cref="P:System.Globalization.CultureInfo.CurrentCulture" />.
		/// </param>
		/// <returns>The formatted value.</returns>
		public static string? FormatValue(DateTimeOffset? value, string format, CultureInfo? culture = null)
		{
			throw null;
		}

		/// <summary>
		/// Formats the provided <paramref name="value" /> as a <see cref="T:System.String" />.
		/// </summary>
		/// <param name="value">The value to format.</param>
		/// <param name="culture">
		/// The <see cref="T:System.Globalization.CultureInfo" /> to use while formatting. Defaults to <see cref="P:System.Globalization.CultureInfo.CurrentCulture" />.
		/// </param>
		/// <returns>The formatted value.</returns>
		public static object? FormatValue<T>(T value, CultureInfo? culture = null)
		{
			throw null;
		}

		/// <summary>
		/// Attempts to convert a value to a <see cref="T:System.String" />.
		/// </summary>
		/// <param name="obj">The object to convert.</param>
		/// <param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> to use for conversion.</param>
		/// <param name="value">The converted value.</param>
		/// <returns><c>true</c> if conversion is successful, otherwise <c>false</c>.</returns>
		public static bool TryConvertToString(object? obj, CultureInfo? culture, out string? value)
		{
			throw null;
		}

		/// <summary>
		/// Attempts to convert a value to a <see cref="T:System.Boolean" />.
		/// </summary>
		/// <param name="obj">The object to convert.</param>
		/// <param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> to use for conversion.</param>
		/// <param name="value">The converted value.</param>
		/// <returns><c>true</c> if conversion is successful, otherwise <c>false</c>.</returns>
		public static bool TryConvertToBool(object? obj, CultureInfo? culture, out bool value)
		{
			throw null;
		}

		/// <summary>
		/// Attempts to convert a value to a nullable <see cref="T:System.Boolean" />.
		/// </summary>
		/// <param name="obj">The object to convert.</param>
		/// <param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> to use for conversion.</param>
		/// <param name="value">The converted value.</param>
		/// <returns><c>true</c> if conversion is successful, otherwise <c>false</c>.</returns>
		public static bool TryConvertToNullableBool(object? obj, CultureInfo? culture, out bool? value)
		{
			throw null;
		}

		/// <summary>
		/// Attempts to convert a value to a <see cref="T:System.Int32" />.
		/// </summary>
		/// <param name="obj">The object to convert.</param>
		/// <param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> to use for conversion.</param>
		/// <param name="value">The converted value.</param>
		/// <returns><c>true</c> if conversion is successful, otherwise <c>false</c>.</returns>
		public static bool TryConvertToInt(object? obj, CultureInfo? culture, out int value)
		{
			throw null;
		}

		/// <summary>
		/// Attempts to convert a value to a nullable <see cref="T:System.Int32" />.
		/// </summary>
		/// <param name="obj">The object to convert.</param>
		/// <param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> to use for conversion.</param>
		/// <param name="value">The converted value.</param>
		/// <returns><c>true</c> if conversion is successful, otherwise <c>false</c>.</returns>
		public static bool TryConvertToNullableInt(object? obj, CultureInfo? culture, out int? value)
		{
			throw null;
		}

		/// <summary>
		/// Attempts to convert a value to a <see cref="T:System.Int64" />.
		/// </summary>
		/// <param name="obj">The object to convert.</param>
		/// <param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> to use for conversion.</param>
		/// <param name="value">The converted value.</param>
		/// <returns><c>true</c> if conversion is successful, otherwise <c>false</c>.</returns>
		public static bool TryConvertToLong(object? obj, CultureInfo? culture, out long value)
		{
			throw null;
		}

		/// <summary>
		/// Attempts to convert a value to a nullable <see cref="T:System.Int64" />.
		/// </summary>
		/// <param name="obj">The object to convert.</param>
		/// <param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> to use for conversion.</param>
		/// <param name="value">The converted value.</param>
		/// <returns><c>true</c> if conversion is successful, otherwise <c>false</c>.</returns>
		public static bool TryConvertToNullableLong(object? obj, CultureInfo? culture, out long? value)
		{
			throw null;
		}

		/// <summary>
		/// Attempts to convert a value to a <see cref="T:System.Int16" />.
		/// </summary>
		/// <param name="obj">The object to convert.</param>
		/// <param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> to use for conversion.</param>
		/// <param name="value">The converted value.</param>
		/// <returns><c>true</c> if conversion is successful, otherwise <c>false</c>.</returns>
		public static bool TryConvertToShort(object? obj, CultureInfo? culture, out short value)
		{
			throw null;
		}

		/// <summary>
		/// Attempts to convert a value to a nullable <see cref="T:System.Int16" />.
		/// </summary>
		/// <param name="obj">The object to convert.</param>
		/// <param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> to use for conversion.</param>
		/// <param name="value">The converted value.</param>
		/// <returns><c>true</c> if conversion is successful, otherwise <c>false</c>.</returns>
		public static bool TryConvertToNullableShort(object? obj, CultureInfo? culture, out short? value)
		{
			throw null;
		}

		/// <summary>
		/// Attempts to convert a value to a <see cref="T:System.Single" />.
		/// </summary>
		/// <param name="obj">The object to convert.</param>
		/// <param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> to use for conversion.</param>
		/// <param name="value">The converted value.</param>
		/// <returns><c>true</c> if conversion is successful, otherwise <c>false</c>.</returns>
		public static bool TryConvertToFloat(object? obj, CultureInfo? culture, out float value)
		{
			throw null;
		}

		/// <summary>
		/// Attempts to convert a value to a nullable <see cref="T:System.Single" />.
		/// </summary>
		/// <param name="obj">The object to convert.</param>
		/// <param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> to use for conversion.</param>
		/// <param name="value">The converted value.</param>
		/// <returns><c>true</c> if conversion is successful, otherwise <c>false</c>.</returns>
		public static bool TryConvertToNullableFloat(object? obj, CultureInfo? culture, out float? value)
		{
			throw null;
		}

		/// <summary>
		/// Attempts to convert a value to a <see cref="T:System.Double" />.
		/// </summary>
		/// <param name="obj">The object to convert.</param>
		/// <param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> to use for conversion.</param>
		/// <param name="value">The converted value.</param>
		/// <returns><c>true</c> if conversion is successful, otherwise <c>false</c>.</returns>
		public static bool TryConvertToDouble(object? obj, CultureInfo? culture, out double value)
		{
			throw null;
		}

		/// <summary>
		/// Attempts to convert a value to a nullable <see cref="T:System.Double" />.
		/// </summary>
		/// <param name="obj">The object to convert.</param>
		/// <param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> to use for conversion.</param>
		/// <param name="value">The converted value.</param>
		/// <returns><c>true</c> if conversion is successful, otherwise <c>false</c>.</returns>
		public static bool TryConvertToNullableDouble(object? obj, CultureInfo? culture, out double? value)
		{
			throw null;
		}

		/// <summary>
		/// Attempts to convert a value to a <see cref="T:System.Decimal" />.
		/// </summary>
		/// <param name="obj">The object to convert.</param>
		/// <param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> to use for conversion.</param>
		/// <param name="value">The converted value.</param>
		/// <returns><c>true</c> if conversion is successful, otherwise <c>false</c>.</returns>
		public static bool TryConvertToDecimal(object? obj, CultureInfo? culture, out decimal value)
		{
			throw null;
		}

		/// <summary>
		/// Attempts to convert a value to a nullable <see cref="T:System.Decimal" />.
		/// </summary>
		/// <param name="obj">The object to convert.</param>
		/// <param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> to use for conversion.</param>
		/// <param name="value">The converted value.</param>
		/// <returns><c>true</c> if conversion is successful, otherwise <c>false</c>.</returns>
		public static bool TryConvertToNullableDecimal(object? obj, CultureInfo? culture, out decimal? value)
		{
			throw null;
		}

		/// <summary>
		/// Attempts to convert a value to a <see cref="T:System.DateTime" />.
		/// </summary>
		/// <param name="obj">The object to convert.</param>
		/// <param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> to use for conversion.</param>
		/// <param name="value">The converted value.</param>
		/// <returns><c>true</c> if conversion is successful, otherwise <c>false</c>.</returns>
		public static bool TryConvertToDateTime(object? obj, CultureInfo? culture, out DateTime value)
		{
			throw null;
		}

		/// <summary>
		/// Attempts to convert a value to a <see cref="T:System.DateTime" />.
		/// </summary>
		/// <param name="obj">The object to convert.</param>
		/// <param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> to use for conversion.</param>
		/// <param name="format">The format string to use in conversion.</param>
		/// <param name="value">The converted value.</param>
		/// <returns><c>true</c> if conversion is successful, otherwise <c>false</c>.</returns>
		public static bool TryConvertToDateTime(object? obj, CultureInfo? culture, string format, out DateTime value)
		{
			throw null;
		}

		/// <summary>
		/// Attempts to convert a value to a nullable <see cref="T:System.DateTime" />.
		/// </summary>
		/// <param name="obj">The object to convert.</param>
		/// <param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> to use for conversion.</param>
		/// <param name="value">The converted value.</param>
		/// <returns><c>true</c> if conversion is successful, otherwise <c>false</c>.</returns>
		public static bool TryConvertToNullableDateTime(object? obj, CultureInfo? culture, out DateTime? value)
		{
			throw null;
		}

		/// <summary>
		/// Attempts to convert a value to a nullable <see cref="T:System.DateTime" />.
		/// </summary>
		/// <param name="obj">The object to convert.</param>
		/// <param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> to use for conversion.</param>
		/// <param name="format">The format string to use in conversion.</param>
		/// <param name="value">The converted value.</param>
		/// <returns><c>true</c> if conversion is successful, otherwise <c>false</c>.</returns>
		public static bool TryConvertToNullableDateTime(object? obj, CultureInfo? culture, string format, out DateTime? value)
		{
			throw null;
		}

		/// <summary>
		/// Attempts to convert a value to a <see cref="T:System.DateTimeOffset" />.
		/// </summary>
		/// <param name="obj">The object to convert.</param>
		/// <param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> to use for conversion.</param>
		/// <param name="value">The converted value.</param>
		/// <returns><c>true</c> if conversion is successful, otherwise <c>false</c>.</returns>
		public static bool TryConvertToDateTimeOffset(object? obj, CultureInfo? culture, out DateTimeOffset value)
		{
			throw null;
		}

		/// <summary>
		/// Attempts to convert a value to a <see cref="T:System.DateTimeOffset" />.
		/// </summary>
		/// <param name="obj">The object to convert.</param>
		/// <param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> to use for conversion.</param>
		/// <param name="format">The format string to use in conversion.</param>
		/// <param name="value">The converted value.</param>
		/// <returns><c>true</c> if conversion is successful, otherwise <c>false</c>.</returns>
		public static bool TryConvertToDateTimeOffset(object? obj, CultureInfo? culture, string format, out DateTimeOffset value)
		{
			throw null;
		}

		/// <summary>
		/// Attempts to convert a value to a nullable <see cref="T:System.DateTimeOffset" />.
		/// </summary>
		/// <param name="obj">The object to convert.</param>
		/// <param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> to use for conversion.</param>
		/// <param name="value">The converted value.</param>
		/// <returns><c>true</c> if conversion is successful, otherwise <c>false</c>.</returns>
		public static bool TryConvertToNullableDateTimeOffset(object? obj, CultureInfo? culture, out DateTimeOffset? value)
		{
			throw null;
		}

		/// <summary>
		/// Attempts to convert a value to a nullable <see cref="T:System.DateTimeOffset" />.
		/// </summary>
		/// <param name="obj">The object to convert.</param>
		/// <param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> to use for conversion.</param>
		/// <param name="format">The format string to use in conversion.</param>
		/// <param name="value">The converted value.</param>
		/// <returns><c>true</c> if conversion is successful, otherwise <c>false</c>.</returns>
		public static bool TryConvertToNullableDateTimeOffset(object? obj, CultureInfo? culture, string format, out DateTimeOffset? value)
		{
			throw null;
		}

		/// <summary>
		/// Attempts to convert a value to a value of type <typeparamref name="T" />.
		/// </summary>
		/// <param name="obj">The object to convert.</param>
		/// <param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> to use for conversion.</param>
		/// <param name="value">The converted value.</param>
		/// <returns><c>true</c> if conversion is successful, otherwise <c>false</c>.</returns>
		public static bool TryConvertTo<T>(object? obj, CultureInfo? culture, out T value)
		{
			throw null;
		}
	}
}
