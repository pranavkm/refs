using Microsoft.AspNetCore.Components.Rendering;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.AspNetCore.Components.Forms
{
	/// <summary>
	/// An input component for editing <see cref="T:System.Boolean" /> values.
	/// </summary>
	public class InputCheckbox : InputBase<bool>
	{
		/// <inheritdoc />
		protected override void BuildRenderTree(RenderTreeBuilder builder)
		{
			throw null;
		}

		/// <inheritdoc />
		protected override bool TryParseValueFromString(string? value, out bool result, [NotNullWhen(false)] out string? validationErrorMessage)
		{
			throw null;
		}

		public InputCheckbox()
		{
			throw null;
		}
	}
}
