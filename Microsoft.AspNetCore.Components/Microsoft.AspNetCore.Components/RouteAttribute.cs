using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components
{
	/// <summary>
	/// Indicates that the associated component should match the specified route template pattern.
	/// </summary>
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
	public sealed class RouteAttribute : Attribute
	{
		/// <summary>
		/// Gets the route template.
		/// </summary>
		public string Template
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Constructs an instance of <see cref="T:Microsoft.AspNetCore.Components.RouteAttribute" />.
		/// </summary>
		/// <param name="template">The route template.</param>
		public RouteAttribute(string template)
		{
			throw null;
		}
	}
}
