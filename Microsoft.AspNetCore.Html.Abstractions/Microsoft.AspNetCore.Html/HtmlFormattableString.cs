using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.Encodings.Web;

namespace Microsoft.AspNetCore.Html
{
	/// <summary>
	/// An <see cref="T:Microsoft.AspNetCore.Html.IHtmlContent" /> implementation of composite string formatting
	/// (see https://msdn.microsoft.com/en-us/library/txafckwd(v=vs.110).aspx) which HTML encodes
	/// formatted arguments.
	/// </summary>
	[DebuggerDisplay("{DebuggerToString()}")]
	public class HtmlFormattableString : IHtmlContent
	{
		private class EncodingFormatProvider : IFormatProvider, ICustomFormatter
		{
			[System.Runtime.CompilerServices.NullableContext(1)]
			public EncodingFormatProvider(IFormatProvider formatProvider, HtmlEncoder encoder)
			{
				throw null;
			}

			public string Format(string? format, object? arg, IFormatProvider? formatProvider)
			{
				throw null;
			}

			public object? GetFormat(Type? formatType)
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates a new <see cref="T:Microsoft.AspNetCore.Html.HtmlFormattableString" /> with the given <paramref name="format" /> and
		/// <paramref name="args" />.
		/// </summary>
		/// <param name="format">A composite format string.</param>
		/// <param name="args">An array that contains objects to format.</param>
		public HtmlFormattableString(string format, params object[] args)
		{
			throw null;
		}

		/// <summary>
		/// Creates a new <see cref="T:Microsoft.AspNetCore.Html.HtmlFormattableString" /> with the given <paramref name="formatProvider" />,
		/// <paramref name="format" /> and <paramref name="args" />.
		/// </summary>
		/// <param name="formatProvider">An object that provides culture-specific formatting information.</param>
		/// <param name="format">A composite format string.</param>
		/// <param name="args">An array that contains objects to format.</param>
		public HtmlFormattableString(IFormatProvider? formatProvider, string format, params object[] args)
		{
			throw null;
		}

		/// <inheritdoc />
		public void WriteTo(TextWriter writer, HtmlEncoder encoder)
		{
			throw null;
		}
	}
}
