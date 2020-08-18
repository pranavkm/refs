using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components
{
	/// <summary>
	/// Denotes the target member as a cascading component parameter. Its value will be
	/// supplied by the closest ancestor <see cref="T:Microsoft.AspNetCore.Components.CascadingValue`1" /> component that
	/// supplies values with a compatible type and name.
	/// </summary>
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
	public sealed class CascadingParameterAttribute : Attribute
	{
		/// <summary>
		/// If specified, the parameter value will be supplied by the closest
		/// ancestor <see cref="T:Microsoft.AspNetCore.Components.CascadingValue`1" /> that supplies a value with
		/// this name.
		///
		/// If null, the parameter value will be supplied by the closest ancestor
		/// <see cref="T:Microsoft.AspNetCore.Components.CascadingValue`1" />  that supplies a value with a compatible
		/// type.
		/// </summary>
		public string? Name
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

		public CascadingParameterAttribute()
		{
			throw null;
		}
	}
}
