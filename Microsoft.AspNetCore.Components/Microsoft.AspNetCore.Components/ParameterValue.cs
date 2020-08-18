using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components
{
	/// <summary>
	/// Represents a single parameter supplied to an <see cref="T:Microsoft.AspNetCore.Components.IComponent" />
	/// by its parent in the render tree.
	/// </summary>
	public readonly struct ParameterValue
	{
		/// <summary>
		/// Gets the name of the parameter.
		/// </summary>
		public string Name
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the value being supplied for the parameter.
		/// </summary>
		public object Value
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets a value to indicate whether the parameter is cascading, meaning that it
		/// was supplied by a <see cref="T:Microsoft.AspNetCore.Components.CascadingValue`1" />.
		/// </summary>
		public bool Cascading
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		internal ParameterValue(string name, object value, bool cascading)
		{
			throw null;
		}
	}
}
