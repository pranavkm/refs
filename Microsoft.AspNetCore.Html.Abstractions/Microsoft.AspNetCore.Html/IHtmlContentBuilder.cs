namespace Microsoft.AspNetCore.Html
{
	/// <summary>
	/// A builder for HTML content.
	/// </summary>
	public interface IHtmlContentBuilder : IHtmlContentContainer, IHtmlContent
	{
		/// <summary>
		/// Appends an <see cref="T:Microsoft.AspNetCore.Html.IHtmlContent" /> instance.
		/// </summary>
		/// <param name="content">The <see cref="T:Microsoft.AspNetCore.Html.IHtmlContent" /> to append.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Html.IHtmlContentBuilder" />.</returns>
		IHtmlContentBuilder AppendHtml(IHtmlContent content);

		/// <summary>
		/// Appends a <see cref="T:System.String" /> value. The value is treated as unencoded as-provided, and will be HTML
		/// encoded before writing to output.
		/// </summary>
		/// <param name="unencoded">The <see cref="T:System.String" /> to append.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Html.IHtmlContentBuilder" />.</returns>
		IHtmlContentBuilder Append(string unencoded);

		/// <summary>
		/// Appends an HTML encoded <see cref="T:System.String" /> value. The value is treated as HTML encoded as-provided, and
		/// no further encoding will be performed.
		/// </summary>
		/// <param name="encoded">The HTML encoded <see cref="T:System.String" /> to append.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Html.IHtmlContentBuilder" />.</returns>
		IHtmlContentBuilder AppendHtml(string encoded);

		/// <summary>
		/// Clears the content.
		/// </summary>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Html.IHtmlContentBuilder" />.</returns>
		IHtmlContentBuilder Clear();
	}
}
