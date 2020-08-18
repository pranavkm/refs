using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Localization
{
	/// <summary>
	/// Provides the location of resources for an Assembly.
	/// </summary>
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false, Inherited = false)]
	public class ResourceLocationAttribute : Attribute
	{
		/// <summary>
		/// The location of resources for this Assembly.
		/// </summary>
		public string ResourceLocation
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates a new <see cref="T:Microsoft.Extensions.Localization.ResourceLocationAttribute" />.
		/// </summary>
		/// <param name="resourceLocation">The location of resources for this Assembly.</param>
		public ResourceLocationAttribute(string resourceLocation)
		{
			throw null;
		}
	}
}
