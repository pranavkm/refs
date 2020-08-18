using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components
{
	/// <summary>
	/// Configures options for binding specific element types.
	/// </summary>
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
	public sealed class BindElementAttribute : Attribute
	{
		/// <summary>
		/// Gets the tag name of the element.
		/// </summary>
		public string Element
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the suffix value.
		/// For example, this will be <c>value</c> to mean <c>bind-value</c>, or <see langword="null" /> to mean <c>bind</c>.
		/// </summary>
		public string? Suffix
		{
			[System.Runtime.CompilerServices.NullableContext(2)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the name of the value attribute to be bound.
		/// </summary>
		public string ValueAttribute
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the name of an attribute that will register an associated change event.
		/// </summary>
		public string ChangeAttribute
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Constructs an instance of <see cref="T:Microsoft.AspNetCore.Components.BindElementAttribute" />.
		/// </summary>
		/// <param name="element">The tag name of the element.</param>
		/// <param name="suffix">The suffix value. For example, set this to <c>value</c> for <c>bind-value</c>, or set this to <see langword="null" /> for <c>bind</c>.</param>
		/// <param name="valueAttribute">The name of the value attribute to be bound.</param>
		/// <param name="changeAttribute">The name of an attribute that will register an associated change event.</param>
		public BindElementAttribute(string element, string? suffix, string valueAttribute, string changeAttribute)
		{
			throw null;
		}
	}
}
