using System.Collections.Generic;

namespace Microsoft.Extensions.Localization
{
	/// <summary>
	/// Extension methods for operating on <see cref="T:Microsoft.Extensions.Localization.IStringLocalizer" /> instances.
	/// </summary>
	public static class StringLocalizerExtensions
	{
		/// <summary>
		/// Gets the string resource with the given name.
		/// </summary>
		/// <param name="stringLocalizer">The <see cref="T:Microsoft.Extensions.Localization.IStringLocalizer" />.</param>
		/// <param name="name">The name of the string resource.</param>
		/// <returns>The string resource as a <see cref="T:Microsoft.Extensions.Localization.LocalizedString" />.</returns>
		public static LocalizedString GetString(this IStringLocalizer stringLocalizer, string name)
		{
			throw null;
		}

		/// <summary>
		/// Gets the string resource with the given name and formatted with the supplied arguments.
		/// </summary>
		/// <param name="stringLocalizer">The <see cref="T:Microsoft.Extensions.Localization.IStringLocalizer" />.</param>
		/// <param name="name">The name of the string resource.</param>
		/// <param name="arguments">The values to format the string with.</param>
		/// <returns>The formatted string resource as a <see cref="T:Microsoft.Extensions.Localization.LocalizedString" />.</returns>
		public static LocalizedString GetString(this IStringLocalizer stringLocalizer, string name, params object[] arguments)
		{
			throw null;
		}

		/// <summary>
		/// Gets all string resources including those for parent cultures.
		/// </summary>
		/// <param name="stringLocalizer">The <see cref="T:Microsoft.Extensions.Localization.IStringLocalizer" />.</param>
		/// <returns>The string resources.</returns>
		public static IEnumerable<LocalizedString> GetAllStrings(this IStringLocalizer stringLocalizer)
		{
			throw null;
		}
	}
}
