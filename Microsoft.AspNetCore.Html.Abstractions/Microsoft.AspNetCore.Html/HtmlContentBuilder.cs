using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.Encodings.Web;

namespace Microsoft.AspNetCore.Html
{
	/// <summary>
	/// An <see cref="T:Microsoft.AspNetCore.Html.IHtmlContentBuilder" /> implementation using an in memory list.
	/// </summary>
	[DebuggerDisplay("{DebuggerToString()}")]
	public class HtmlContentBuilder : IHtmlContentBuilder, IHtmlContentContainer, IHtmlContent
	{
		/// <summary>
		/// Gets the number of elements in the <see cref="T:Microsoft.AspNetCore.Html.HtmlContentBuilder" />.
		/// </summary>
		public int Count
		{
			get
			{
				throw null;
			}
		}

		internal IList<object> Entries
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates a new <see cref="T:Microsoft.AspNetCore.Html.HtmlContentBuilder" />.
		/// </summary>
		public HtmlContentBuilder()
		{
			throw null;
		}

		/// <summary>
		/// Creates a new <see cref="T:Microsoft.AspNetCore.Html.HtmlContentBuilder" /> with the given initial capacity.
		/// </summary>
		/// <param name="capacity">The initial capacity of the backing store.</param>
		public HtmlContentBuilder(int capacity)
		{
			throw null;
		}

		/// <summary>
		/// Creates a new <see cref="T:Microsoft.AspNetCore.Html.HtmlContentBuilder" /> with the given list of entries.
		/// </summary>
		/// <param name="entries">
		/// The list of entries. The <see cref="T:Microsoft.AspNetCore.Html.HtmlContentBuilder" /> will use this list without making a copy.
		/// </param>
		public HtmlContentBuilder(IList<object> entries)
		{
			throw null;
		}

		/// <inheritdoc />
		public IHtmlContentBuilder Append(string? unencoded)
		{
			throw null;
		}

		/// <inheritdoc />
		public IHtmlContentBuilder AppendHtml(IHtmlContent? htmlContent)
		{
			throw null;
		}

		/// <inheritdoc />
		public IHtmlContentBuilder AppendHtml(string? encoded)
		{
			throw null;
		}

		/// <inheritdoc />
		public IHtmlContentBuilder Clear()
		{
			throw null;
		}

		/// <inheritdoc />
		public void CopyTo(IHtmlContentBuilder destination)
		{
			throw null;
		}

		/// <inheritdoc />
		public void MoveTo(IHtmlContentBuilder destination)
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
