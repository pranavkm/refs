using Microsoft.AspNetCore.Components.Rendering;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components.Forms
{
	/// <summary>
	/// Renders a form element that cascades an <see cref="P:Microsoft.AspNetCore.Components.Forms.EditForm.EditContext" /> to descendants.
	/// </summary>
	public class EditForm : ComponentBase
	{
		/// <summary>
		/// Gets or sets a collection of additional attributes that will be applied to the created <c>form</c> element.
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
		/// Supplies the edit context explicitly. If using this parameter, do not
		/// also supply <see cref="P:Microsoft.AspNetCore.Components.Forms.EditForm.Model" />, since the model value will be taken
		/// from the <see cref="P:Microsoft.AspNetCore.Components.Forms.EditContext.Model" /> property.
		/// </summary>
		[Parameter]
		public EditContext? EditContext
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Specifies the top-level model object for the form. An edit context will
		/// be constructed for this model. If using this parameter, do not also supply
		/// a value for <see cref="P:Microsoft.AspNetCore.Components.Forms.EditForm.EditContext" />.
		/// </summary>
		[Parameter]
		public object? Model
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
		/// Specifies the content to be rendered inside this <see cref="T:Microsoft.AspNetCore.Components.Forms.EditForm" />.
		/// </summary>
		[Parameter]
		public RenderFragment<EditContext>? ChildContent
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
		/// A callback that will be invoked when the form is submitted.
		///
		/// If using this parameter, you are responsible for triggering any validation
		/// manually, e.g., by calling <see cref="M:Microsoft.AspNetCore.Components.Forms.EditContext.Validate" />.
		/// </summary>
		[Parameter]
		public EventCallback<EditContext> OnSubmit
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
		/// A callback that will be invoked when the form is submitted and the
		/// <see cref="P:Microsoft.AspNetCore.Components.Forms.EditForm.EditContext" /> is determined to be valid.
		/// </summary>
		[Parameter]
		public EventCallback<EditContext> OnValidSubmit
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
		/// A callback that will be invoked when the form is submitted and the
		/// <see cref="P:Microsoft.AspNetCore.Components.Forms.EditForm.EditContext" /> is determined to be invalid.
		/// </summary>
		[Parameter]
		public EventCallback<EditContext> OnInvalidSubmit
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
		/// Constructs an instance of <see cref="T:Microsoft.AspNetCore.Components.Forms.EditForm" />.
		/// </summary>
		public EditForm()
		{
			throw null;
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
	}
}
