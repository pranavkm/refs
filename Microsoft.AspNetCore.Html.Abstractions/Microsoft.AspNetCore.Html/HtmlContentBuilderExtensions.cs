using System;

namespace Microsoft.AspNetCore.Html
{
	/// <summary>
	/// Extension methods for <see cref="T:Microsoft.AspNetCore.Html.IHtmlContentBuilder" />.
	/// </summary>
	public static class HtmlContentBuilderExtensions
	{
		/// <summary>
		/// Appends the specified <paramref name="format" /> to the existing content after replacing each format
		/// item with the HTML encoded <see cref="T:System.String" /> representation of the corresponding item in the
		/// <paramref name="args" /> array.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.Html.IHtmlContentBuilder" />.</param>
		/// <param name="format">
		/// The composite format <see cref="T:System.String" /> (see http://msdn.microsoft.com/en-us/library/txafckwd.aspx).
		/// The format string is assumed to be HTML encoded as-provided, and no further encoding will be performed.
		/// </param>
		/// <param name="args">
		/// The object array to format. Each element in the array will be formatted and then HTML encoded.
		/// </param>
		/// <returns>A reference to this instance after the append operation has completed.</returns>
		public static IHtmlContentBuilder AppendFormat(this IHtmlContentBuilder builder, string format, params object[] args)
		{
			throw null;
		}

		/// <summary>
		/// Appends the specified <paramref name="format" /> to the existing content with information from the
		/// <paramref name="formatProvider" /> after replacing each format item with the HTML encoded
		/// <see cref="T:System.String" /> representation of the corresponding item in the <paramref name="args" /> array.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.Html.IHtmlContentBuilder" />.</param>
		/// <param name="formatProvider">An object that supplies culture-specific formatting information.</param>
		/// <param name="format">
		/// The composite format <see cref="T:System.String" /> (see http://msdn.microsoft.com/en-us/library/txafckwd.aspx).
		/// The format string is assumed to be HTML encoded as-provided, and no further encoding will be performed.
		/// </param>
		/// <param name="args">
		/// The object array to format. Each element in the array will be formatted and then HTML encoded.
		/// </param>
		/// <returns>A reference to this instance after the append operation has completed.</returns>
		public static IHtmlContentBuilder AppendFormat(this IHtmlContentBuilder builder, IFormatProvider formatProvider, string format, params object[] args)
		{
			throw null;
		}

		/// <summary>
		/// Appends an <see cref="P:System.Environment.NewLine" />.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.Html.IHtmlContentBuilder" />.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Html.IHtmlContentBuilder" />.</returns>
		public static IHtmlContentBuilder AppendLine(this IHtmlContentBuilder builder)
		{
			throw null;
		}

		/// <summary>
		/// Appends an <see cref="P:System.Environment.NewLine" /> after appending the <see cref="T:System.String" /> value.
		/// The value is treated as unencoded as-provided, and will be HTML encoded before writing to output.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.Html.IHtmlContentBuilder" />.</param>
		/// <param name="unencoded">The <see cref="T:System.String" /> to append.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Html.IHtmlContentBuilder" />.</returns>
		public static IHtmlContentBuilder AppendLine(this IHtmlContentBuilder builder, string unencoded)
		{
			throw null;
		}

		/// <summary>
		/// Appends an <see cref="P:System.Environment.NewLine" /> after appending the <see cref="T:Microsoft.AspNetCore.Html.IHtmlContent" /> value.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.Html.IHtmlContentBuilder" />.</param>
		/// <param name="content">The <see cref="T:Microsoft.AspNetCore.Html.IHtmlContent" /> to append.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Html.IHtmlContentBuilder" />.</returns>
		public static IHtmlContentBuilder AppendLine(this IHtmlContentBuilder builder, IHtmlContent content)
		{
			throw null;
		}

		/// <summary>
		/// Appends an <see cref="P:System.Environment.NewLine" /> after appending the <see cref="T:System.String" /> value.
		/// The value is treated as HTML encoded as-provided, and no further encoding will be performed.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.Html.IHtmlContentBuilder" />.</param>
		/// <param name="encoded">The HTML encoded <see cref="T:System.String" /> to append.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Html.IHtmlContentBuilder" />.</returns>
		public static IHtmlContentBuilder AppendHtmlLine(this IHtmlContentBuilder builder, string encoded)
		{
			throw null;
		}

		/// <summary>
		/// Sets the content to the <see cref="T:System.String" /> value. The value is treated as unencoded as-provided,
		/// and will be HTML encoded before writing to output.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.Html.IHtmlContentBuilder" />.</param>
		/// <param name="unencoded">The <see cref="T:System.String" /> value that replaces the content.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Html.IHtmlContentBuilder" />.</returns>
		public static IHtmlContentBuilder SetContent(this IHtmlContentBuilder builder, string unencoded)
		{
			throw null;
		}

		/// <summary>
		/// Sets the content to the <see cref="T:Microsoft.AspNetCore.Html.IHtmlContent" /> value.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.Html.IHtmlContentBuilder" />.</param>
		/// <param name="content">The <see cref="T:Microsoft.AspNetCore.Html.IHtmlContent" /> value that replaces the content.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Html.IHtmlContentBuilder" />.</returns>
		public static IHtmlContentBuilder SetHtmlContent(this IHtmlContentBuilder builder, IHtmlContent content)
		{
			throw null;
		}

		/// <summary>
		/// Sets the content to the <see cref="T:System.String" /> value. The value is treated as HTML encoded as-provided, and
		/// no further encoding will be performed.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.Html.IHtmlContentBuilder" />.</param>
		/// <param name="encoded">The HTML encoded <see cref="T:System.String" /> that replaces the content.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Html.IHtmlContentBuilder" />.</returns>
		public static IHtmlContentBuilder SetHtmlContent(this IHtmlContentBuilder builder, string encoded)
		{
			throw null;
		}
	}
}
