using Microsoft.AspNetCore.Components.Rendering;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components.Forms
{
	/// <summary>
	/// An input component for editing numeric values.
	/// Supported numeric types are <see cref="T:System.Int32" />, <see cref="T:System.Int64" />, <see cref="T:System.Int16" />, <see cref="T:System.Single" />, <see cref="T:System.Double" />, <see cref="T:System.Decimal" />.
	/// </summary>
	public class InputNumber<TValue> : InputBase<TValue>
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
		protected override bool TryParseValueFromString(string? value, [MaybeNull] out TValue result, [NotNullWhen(false)] out string? validationErrorMessage)
		{
			throw null;
		}

		/// <summary>
		/// Formats the value as a string. Derived classes can override this to determine the formatting used for <c>CurrentValueAsString</c>.
		/// </summary>
		/// <param name="value">The value to format.</param>
		/// <returns>A string representation of the value.</returns>
		protected override string? FormatValueAsString([AllowNull] TValue value)
		{
			throw null;
		}

		public InputNumber()
		{
			throw null;
		}
	}
}
