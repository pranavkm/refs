using System.IO;
using System.Runtime.CompilerServices;
using System.Text.Encodings.Web;

namespace Microsoft.AspNetCore.Html
{
	/// <summary>
	/// An <see cref="T:Microsoft.AspNetCore.Html.IHtmlContent" /> implementation that wraps an HTML encoded <see cref="T:System.String" />.
	/// </summary>
	public class HtmlString : IHtmlContent
	{
		/// <summary>
		/// An <see cref="T:Microsoft.AspNetCore.Html.HtmlString" /> instance for <see cref="P:System.Environment.NewLine" />.
		/// </summary>
		public static readonly HtmlString NewLine;

		/// <summary>
		/// An <see cref="T:Microsoft.AspNetCore.Html.HtmlString" /> instance for <see cref="F:System.String.Empty" />.
		/// </summary>
		public static readonly HtmlString Empty;

		/// <summary>
		/// Gets the HTML encoded value.
		/// </summary>
		public string? Value
		{
			[System.Runtime.CompilerServices.NullableContext(2)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates a new <see cref="T:Microsoft.AspNetCore.Html.HtmlString" />.
		/// </summary>
		/// <param name="value">The HTML encoded value.</param>
		[System.Runtime.CompilerServices.NullableContext(2)]
		public HtmlString(string? value)
		{
			throw null;
		}

		/// <inheritdoc />
		public void WriteTo(TextWriter writer, HtmlEncoder encoder)
		{
			throw null;
		}

		/// <inheritdoc />
		public override string ToString()
		{
			throw null;
		}
	}
}
