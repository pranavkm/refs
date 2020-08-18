using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components.Forms
{
	/// <summary>
	/// Describes context for an <see cref="T:Microsoft.AspNetCore.Components.Forms.InputRadio`1" /> component.
	/// </summary>
	internal class InputRadioContext
	{
		/// <summary>
		/// Gets the name of the input radio group.
		/// </summary>
		public string GroupName
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the current selected value in the input radio group.
		/// </summary>
		public object? CurrentValue
		{
			[System.Runtime.CompilerServices.NullableContext(2)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets a css class indicating the validation state of input radio elements.
		/// </summary>
		public string FieldClass
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the event callback to be invoked when the selected value is changed.
		/// </summary>
		public EventCallback<ChangeEventArgs> ChangeEventCallback
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Instantiates a new <see cref="T:Microsoft.AspNetCore.Components.Forms.InputRadioContext" />.
		/// </summary>
		/// <param name="parentContext">The parent <see cref="T:Microsoft.AspNetCore.Components.Forms.InputRadioContext" />.</param>
		/// <param name="groupName">The name of the input radio group.</param>
		/// <param name="currentValue">The current selected value in the input radio group.</param>
		/// <param name="fieldClass">The css class indicating the validation state of input radio elements.</param>
		/// <param name="changeEventCallback">The event callback to be invoked when the selected value is changed.</param>
		public InputRadioContext(InputRadioContext? parentContext, string groupName, object? currentValue, string fieldClass, EventCallback<ChangeEventArgs> changeEventCallback)
		{
			throw null;
		}

		/// <summary>
		/// Finds an <see cref="T:Microsoft.AspNetCore.Components.Forms.InputRadioContext" /> in the context's ancestors with the matching <paramref name="groupName" />.
		/// </summary>
		/// <param name="groupName">The group name of the ancestor <see cref="T:Microsoft.AspNetCore.Components.Forms.InputRadioContext" />.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Components.Forms.InputRadioContext" />, or <c>null</c> if none was found.</returns>
		public InputRadioContext? FindContextInAncestors(string groupName)
		{
			throw null;
		}
	}
}
