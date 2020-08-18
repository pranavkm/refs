namespace Microsoft.AspNetCore.Html
{
	/// <summary>
	/// Defines a contract for <see cref="T:Microsoft.AspNetCore.Html.IHtmlContent" /> instances made up of several components which
	/// can be copied into an <see cref="T:Microsoft.AspNetCore.Html.IHtmlContentBuilder" />.
	/// </summary>
	public interface IHtmlContentContainer : IHtmlContent
	{
		/// <summary>
		/// Copies the contained content of this <see cref="T:Microsoft.AspNetCore.Html.IHtmlContentContainer" /> into <paramref name="builder" />.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.Html.IHtmlContentBuilder" />.</param>
		void CopyTo(IHtmlContentBuilder builder);

		/// <summary>
		/// <para>
		/// Moves the contained content of this <see cref="T:Microsoft.AspNetCore.Html.IHtmlContentContainer" /> into <paramref name="builder" />.
		/// </para>
		/// <para>
		/// After <see cref="M:Microsoft.AspNetCore.Html.IHtmlContentContainer.MoveTo(Microsoft.AspNetCore.Html.IHtmlContentBuilder)" /> is called, this <see cref="T:Microsoft.AspNetCore.Html.IHtmlContentContainer" /> instance should be left
		/// in an empty state.
		/// </para>
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.Html.IHtmlContentBuilder" />.</param>
		void MoveTo(IHtmlContentBuilder builder);
	}
}
