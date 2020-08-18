using System.Diagnostics.CodeAnalysis;

namespace Microsoft.AspNetCore.Components.Forms
{
	internal static class InputExtensions
	{
		public static bool TryParseSelectableValueFromString<TValue>(this InputBase<TValue> input, string? value, [MaybeNull] out TValue result, [NotNullWhen(false)] out string? validationErrorMessage)
		{
			throw null;
		}
	}
}
