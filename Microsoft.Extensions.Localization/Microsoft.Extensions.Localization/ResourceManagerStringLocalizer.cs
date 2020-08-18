using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Localization
{
	/// <summary>
	/// An <see cref="T:Microsoft.Extensions.Localization.IStringLocalizer" /> that uses the <see cref="T:System.Resources.ResourceManager" /> and
	/// <see cref="T:System.Resources.ResourceReader" /> to provide localized strings.
	/// </summary>
	/// <remarks>This type is thread-safe.</remarks>
	public class ResourceManagerStringLocalizer : IStringLocalizer
	{
		/// <inheritdoc />
		public virtual LocalizedString this[string name]
		{
			get
			{
				throw null;
			}
		}

		/// <inheritdoc />
		public virtual LocalizedString this[string name, params object[] arguments]
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates a new <see cref="T:Microsoft.Extensions.Localization.ResourceManagerStringLocalizer" />.
		/// </summary>
		/// <param name="resourceManager">The <see cref="T:System.Resources.ResourceManager" /> to read strings from.</param>
		/// <param name="resourceAssembly">The <see cref="T:System.Reflection.Assembly" /> that contains the strings as embedded resources.</param>
		/// <param name="baseName">The base name of the embedded resource that contains the strings.</param>
		/// <param name="resourceNamesCache">Cache of the list of strings for a given resource assembly name.</param>
		/// <param name="logger">The <see cref="T:Microsoft.Extensions.Logging.ILogger" />.</param>
		public ResourceManagerStringLocalizer(ResourceManager resourceManager, Assembly resourceAssembly, string baseName, IResourceNamesCache resourceNamesCache, ILogger logger)
		{
			throw null;
		}

		/// <summary>
		/// Intended for testing purposes only.
		/// </summary>
		internal ResourceManagerStringLocalizer(ResourceManager resourceManager, AssemblyWrapper resourceAssemblyWrapper, string baseName, IResourceNamesCache resourceNamesCache, ILogger logger)
		{
			throw null;
		}

		/// <summary>
		/// Intended for testing purposes only.
		/// </summary>
		internal ResourceManagerStringLocalizer(ResourceManager resourceManager, IResourceStringProvider resourceStringProvider, string baseName, IResourceNamesCache resourceNamesCache, ILogger logger)
		{
			throw null;
		}

		/// <inheritdoc />
		public virtual IEnumerable<LocalizedString> GetAllStrings(bool includeParentCultures)
		{
			throw null;
		}

		/// <summary>
		/// Returns all strings in the specified culture.
		/// </summary>
		/// <param name="includeParentCultures">Whether to include parent cultures in the search for a resource.</param>
		/// <param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> to get strings for.</param>
		/// <returns>The strings.</returns>
		[IteratorStateMachine(typeof(_003CGetAllStrings_003Ed__14))]
		protected IEnumerable<LocalizedString> GetAllStrings(bool includeParentCultures, CultureInfo culture)
		{
			throw null;
		}

		/// <summary>
		/// Gets a resource string from a <see cref="T:System.Resources.ResourceManager" /> and returns <c>null</c> instead of
		/// throwing exceptions if a match isn't found.
		/// </summary>
		/// <param name="name">The name of the string resource.</param>
		/// <param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> to get the string for.</param>
		/// <returns>The resource string, or <c>null</c> if none was found.</returns>
		protected string? GetStringSafely(string name, CultureInfo? culture)
		{
			throw null;
		}
	}
}
