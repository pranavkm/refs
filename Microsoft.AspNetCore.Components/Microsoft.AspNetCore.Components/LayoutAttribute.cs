using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components
{
	/// <summary>
	/// Indicates that the associated component type uses a specified layout.
	/// </summary>
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
	public sealed class LayoutAttribute : Attribute
	{
		/// <summary>
		/// The type of the layout. The type must implement <see cref="T:Microsoft.AspNetCore.Components.IComponent" />
		/// and must accept a parameter with the name 'Body'.
		/// </summary>
		public Type LayoutType
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Constructs an instance of <see cref="T:Microsoft.AspNetCore.Components.LayoutAttribute" />.
		/// </summary>
		/// <param name="layoutType">The type of the layout.</param>
		public LayoutAttribute(Type layoutType)
		{
			throw null;
		}
	}
}
