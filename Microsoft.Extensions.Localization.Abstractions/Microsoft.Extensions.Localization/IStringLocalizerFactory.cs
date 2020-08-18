using System;

namespace Microsoft.Extensions.Localization
{
	/// <summary>
	/// Represents a factory that creates <see cref="T:Microsoft.Extensions.Localization.IStringLocalizer" /> instances.
	/// </summary>
	public interface IStringLocalizerFactory
	{
		/// <summary>
		/// Creates an <see cref="T:Microsoft.Extensions.Localization.IStringLocalizer" /> using the <see cref="T:System.Reflection.Assembly" /> and
		/// <see cref="P:System.Type.FullName" /> of the specified <see cref="T:System.Type" />.
		/// </summary>
		/// <param name="resourceSource">The <see cref="T:System.Type" />.</param>
		/// <returns>The <see cref="T:Microsoft.Extensions.Localization.IStringLocalizer" />.</returns>
		IStringLocalizer Create(Type resourceSource);

		/// <summary>
		/// Creates an <see cref="T:Microsoft.Extensions.Localization.IStringLocalizer" />.
		/// </summary>
		/// <param name="baseName">The base name of the resource to load strings from.</param>
		/// <param name="location">The location to load resources from.</param>
		/// <returns>The <see cref="T:Microsoft.Extensions.Localization.IStringLocalizer" />.</returns>
		IStringLocalizer Create(string baseName, string location);
	}
}
