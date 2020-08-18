using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Localization
{
	/// <summary>
	/// Provides the RootNamespace of an Assembly. The RootNamespace of the assembly is used by Localization to
	/// determine the resource name to look for when RootNamespace differs from the AssemblyName.
	/// </summary>
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false, Inherited = false)]
	public class RootNamespaceAttribute : Attribute
	{
		/// <summary>
		/// The RootNamespace of this Assembly. The RootNamespace of the assembly is used by Localization to
		/// determine the resource name to look for when RootNamespace differs from the AssemblyName.
		/// </summary>
		public string RootNamespace
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates a new <see cref="T:Microsoft.Extensions.Localization.RootNamespaceAttribute" />.
		/// </summary>
		/// <param name="rootNamespace">The RootNamespace for this Assembly.</param>
		public RootNamespaceAttribute(string rootNamespace)
		{
			throw null;
		}
	}
}
