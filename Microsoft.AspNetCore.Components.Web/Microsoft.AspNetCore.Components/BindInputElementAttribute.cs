using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components
{
	/// <summary>
	/// Configures options for binding subtypes of an HTML <c>input</c> element.
	/// </summary>
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
	public sealed class BindInputElementAttribute : Attribute
	{
		/// <summary>
		/// Gets the value of the element's <c>type</c> attribute.
		/// </summary>
		public string? Type
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the suffix value.
		/// </summary>
		public string? Suffix
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the name of the value attribute to be bound.
		/// </summary>
		public string? ValueAttribute
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
		public string? ChangeAttribute
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets a value that determines whether binding will use <see cref="P:System.Globalization.CultureInfo.InvariantCulture" /> or
		/// <see cref="P:System.Globalization.CultureInfo.CurrentCulture" />.
		/// </summary>
		public bool IsInvariantCulture
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets an optional format to use when converting values.
		/// </summary>
		public string? Format
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Constructs an instance of <see cref="T:Microsoft.AspNetCore.Components.BindInputElementAttribute" />.
		/// </summary>
		/// <param name="type">The value of the element's <c>type</c> attribute.</param>
		/// <param name="suffix">The suffix value.</param>
		/// <param name="valueAttribute">The name of the value attribute to be bound.</param>
		/// <param name="changeAttribute">The name of an attribute that will register an associated change event.</param>
		/// <param name="isInvariantCulture">
		/// Determines whether binding will use <see cref="P:System.Globalization.CultureInfo.InvariantCulture" /> or <see cref="P:System.Globalization.CultureInfo.CurrentCulture" />.
		/// </param>
		/// <param name="format">
		/// An optional format to use when converting values. 
		/// </param>
		public BindInputElementAttribute(string? type, string? suffix, string? valueAttribute, string? changeAttribute, bool isInvariantCulture, string? format)
		{
			throw null;
		}
	}
}
