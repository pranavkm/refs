using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components.Forms
{
	/// <summary>
	/// Displays a list of validation messages for a specified field within a cascaded <see cref="T:Microsoft.AspNetCore.Components.Forms.EditContext" />.
	/// </summary>
	public class ValidationMessage<TValue> : ComponentBase, IDisposable
	{
		/// <summary>
		/// Gets or sets a collection of additional attributes that will be applied to the created <c>div</c> element.
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
		/// Specifies the field for which validation messages should be displayed.
		/// </summary>
		[Parameter]
		public Expression<Func<TValue>>? For
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
		/// Constructs an instance of <see cref="T:Microsoft.AspNetCore.Components.Forms.ValidationMessage`1" />.
		/// </summary>
		public ValidationMessage()
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
