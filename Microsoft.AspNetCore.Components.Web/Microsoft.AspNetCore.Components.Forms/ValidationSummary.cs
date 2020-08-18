using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components.Forms
{
	/// <summary>
	/// Displays a list of validation messages from a cascaded <see cref="T:Microsoft.AspNetCore.Components.Forms.EditContext" />.
	/// </summary>
	public class ValidationSummary : ComponentBase, IDisposable
	{
		/// <summary>
		/// Gets or sets the model to produce the list of validation messages for.
		/// When specified, this lists all errors that are associated with the model instance.
		/// </summary>
		[Parameter]
		public object? Model
		{
			[System.Runtime.CompilerServices.NullableContext(2)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[System.Runtime.CompilerServices.NullableContext(2)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets a collection of additional attributes that will be applied to the created <c>ul</c> element.
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

		/// <summary>`
		/// Constructs an instance of <see cref="T:Microsoft.AspNetCore.Components.Forms.ValidationSummary" />.
		/// </summary>
		public ValidationSummary()
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

		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		void IDisposable.Dispose()
		{
			throw null;
		}
	}
}
