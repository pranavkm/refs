using Microsoft.AspNetCore.Components.Rendering;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components.Forms
{
	/// <summary>
	/// Groups child <see cref="T:Microsoft.AspNetCore.Components.Forms.InputRadio`1" /> components.
	/// </summary>
	public class InputRadioGroup<TValue> : InputBase<TValue>
	{
		/// <summary>
		/// Gets or sets the child content to be rendering inside the <see cref="T:Microsoft.AspNetCore.Components.Forms.InputRadioGroup`1" />.
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

		/// <summary>
		/// Gets or sets the name of the group.
		/// </summary>
		[Parameter]
		public string? Name
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
		protected override void OnParametersSet()
		{
			throw null;
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

		public InputRadioGroup()
		{
			throw null;
		}
	}
}
