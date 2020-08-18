using Microsoft.AspNetCore.Components.Rendering;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components.Forms
{
	/// <summary>
	/// An input component used for selecting a value from a group of choices.
	/// </summary>
	public class InputRadio<TValue> : ComponentBase
	{
		/// <summary>
		/// Gets context for this <see cref="T:Microsoft.AspNetCore.Components.Forms.InputRadio`1" />.
		/// </summary>
		internal InputRadioContext? Context
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets a collection of additional attributes that will be applied to the input element.
		/// </summary>
		[Parameter(CaptureUnmatchedValues = true)]
		public IReadOnlyDictionary<string, object>? AdditionalAttributes
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
		/// Gets or sets the value of this input.
		/// </summary>
		[Parameter]
		public TValue Value
		{
			[System.Runtime.CompilerServices.NullableContext(1)]
			[CompilerGenerated]
			[return: MaybeNull]
			get
			{
				throw null;
			}
			[System.Runtime.CompilerServices.NullableContext(1)]
			[CompilerGenerated]
			[param: AllowNull]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets the name of the parent input radio group.
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

		public InputRadio()
		{
			throw null;
		}
	}
}
