using Microsoft.AspNetCore.Components.Rendering;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components.Forms
{
	/// <summary>
	/// A dropdown selection component.
	/// </summary>
	public class InputSelect<TValue> : InputBase<TValue>
	{
		/// <summary>
		/// Gets or sets the child content to be rendering inside the select element.
		/// </summary>
		[Parameter]
		public RenderFragment? ChildContent
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <inheritdoc />
		protected override void BuildRenderTree(RenderTreeBuilder builder)
		{
			throw null;
		}

		/// <inheritdoc />
		protected override bool TryParseValueFromString(string? value, [MaybeNull] out TValue result, [NotNullWhen(false)] out string? validationErrorMessage)
		{
			throw null;
		}

		public InputSelect()
		{
			throw null;
		}
	}
}
