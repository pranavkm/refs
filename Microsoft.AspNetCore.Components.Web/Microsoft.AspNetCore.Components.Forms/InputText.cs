using Microsoft.AspNetCore.Components.Rendering;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.AspNetCore.Components.Forms
{
	/// <summary>
	/// An input component for editing <see cref="T:System.String" /> values.
	/// </summary>
	public class InputText : InputBase<string>
	{
		/// <inheritdoc />
		protected override void BuildRenderTree(RenderTreeBuilder builder)
		{
			throw null;
		}

		/// <inheritdoc />
		protected override bool TryParseValueFromString(string? value, out string? result, [NotNullWhen(false)] out string? validationErrorMessage)
		{
			throw null;
		}

		public InputText()
		{
			throw null;
		}
	}
}
