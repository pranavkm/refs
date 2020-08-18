using Microsoft.AspNetCore.Components.Rendering;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components.Forms
{
	/// <summary>
	/// An input component for editing date values.
	/// Supported types are <see cref="T:System.DateTime" /> and <see cref="T:System.DateTimeOffset" />.
	/// </summary>
	public class InputDate<TValue> : InputBase<TValue>
	{
		/// <summary>
		/// Gets or sets the error message used when displaying an a parsing error.
		/// </summary>
		[Parameter]
		public string ParsingErrorMessage
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
		protected override string FormatValueAsString([AllowNull] TValue value)
		{
			throw null;
		}

		/// <inheritdoc />
		protected override bool TryParseValueFromString(string? value, [MaybeNull] out TValue result, [NotNullWhen(false)] out string? validationErrorMessage)
		{
			throw null;
		}

		public InputDate()
		{
			throw null;
		}
	}
}
