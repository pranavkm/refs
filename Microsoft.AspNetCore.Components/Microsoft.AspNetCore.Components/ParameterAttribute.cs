using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components
{
	/// <summary>
	/// Denotes the target member as a component parameter.
	/// </summary>
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
	public sealed class ParameterAttribute : Attribute
	{
		/// <summary>
		/// Gets or sets a value that determines whether the parameter will capture values that
		/// don't match any other parameter.
		/// </summary>
		/// <remarks>
		/// <para>
		/// <see cref="P:Microsoft.AspNetCore.Components.ParameterAttribute.CaptureUnmatchedValues" /> allows a component to accept arbitrary additional
		/// attributes, and pass them to another component, or some element of the underlying markup.
		/// </para>
		/// <para>
		/// <see cref="P:Microsoft.AspNetCore.Components.ParameterAttribute.CaptureUnmatchedValues" /> can be used on at most one parameter per component.
		/// </para>
		/// <para>
		/// <see cref="P:Microsoft.AspNetCore.Components.ParameterAttribute.CaptureUnmatchedValues" /> should only be applied to parameters of a type that
		/// can be used with <see cref="M:Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder.AddMultipleAttributes(System.Int32,System.Collections.Generic.IEnumerable{System.Collections.Generic.KeyValuePair{System.String,System.Object}})" />
		/// such as <see cref="T:System.Collections.Generic.Dictionary`2" />.
		/// </para>
		/// </remarks>
		public bool CaptureUnmatchedValues
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

		public ParameterAttribute()
		{
			throw null;
		}
	}
}
