using System;

namespace Microsoft.AspNetCore.Components
{
	/// <summary>
	/// Indicates that the associated property should have a value injected from the
	/// service provider during initialization.
	/// </summary>
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
	public sealed class InjectAttribute : Attribute
	{
		public InjectAttribute()
		{
			throw null;
		}
	}
}
