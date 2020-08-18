using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Components
{
	public static class ElementReferenceExtensions
	{
		/// <summary>
		/// Gives focus to an element given its <see cref="T:Microsoft.AspNetCore.Components.ElementReference" />.
		/// </summary>
		/// <param name="elementReference">A reference to the element to focus.</param>
		/// <returns>The <see cref="T:System.Threading.Tasks.ValueTask" /> representing the asynchronous focus operation.</returns>
		public static ValueTask FocusAsync(this ElementReference elementReference)
		{
			throw null;
		}

		internal static IJSRuntime GetJSRuntime(this ElementReference elementReference)
		{
			throw null;
		}
	}
}
