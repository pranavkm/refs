using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Hosting
{
	/// <summary>
	/// Marker attribute indicating an implementation of <see cref="T:Microsoft.AspNetCore.Hosting.IHostingStartup" /> that will be loaded and executed when building an <see cref="T:Microsoft.AspNetCore.Hosting.IWebHost" />.
	/// </summary>
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false, AllowMultiple = true)]
	public sealed class HostingStartupAttribute : Attribute
	{
		/// <summary>
		/// The implementation of <see cref="T:Microsoft.AspNetCore.Hosting.IHostingStartup" /> that should be loaded when 
		/// starting an application.
		/// </summary>
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
		public Type HostingStartupType
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Constructs the <see cref="T:Microsoft.AspNetCore.Hosting.HostingStartupAttribute" /> with the specified type.
		/// </summary>
		/// <param name="hostingStartupType">A type that implements <see cref="T:Microsoft.AspNetCore.Hosting.IHostingStartup" />.</param>
		public HostingStartupAttribute([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)] Type hostingStartupType)
		{
			throw null;
		}
	}
}
