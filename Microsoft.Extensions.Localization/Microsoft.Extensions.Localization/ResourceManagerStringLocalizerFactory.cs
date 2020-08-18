using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Reflection;

namespace Microsoft.Extensions.Localization
{
	/// <summary>
	/// An <see cref="T:Microsoft.Extensions.Localization.IStringLocalizerFactory" /> that creates instances of <see cref="T:Microsoft.Extensions.Localization.ResourceManagerStringLocalizer" />.
	/// </summary>
	/// <remarks>
	/// <see cref="T:Microsoft.Extensions.Localization.ResourceManagerStringLocalizerFactory" /> offers multiple ways to set the relative path of
	/// resources to be used. They are, in order of precedence:
	/// <see cref="T:Microsoft.Extensions.Localization.ResourceLocationAttribute" /> -&gt; <see cref="P:Microsoft.Extensions.Localization.LocalizationOptions.ResourcesPath" /> -&gt; the project root.
	/// </remarks>
	public class ResourceManagerStringLocalizerFactory : IStringLocalizerFactory
	{
		/// <summary>
		/// Creates a new <see cref="T:Microsoft.Extensions.Localization.ResourceManagerStringLocalizer" />.
		/// </summary>
		/// <param name="localizationOptions">The <see cref="T:Microsoft.Extensions.Options.IOptions`1" />.</param>
		/// <param name="loggerFactory">The <see cref="T:Microsoft.Extensions.Logging.ILoggerFactory" />.</param>
		public ResourceManagerStringLocalizerFactory(IOptions<LocalizationOptions> localizationOptions, ILoggerFactory loggerFactory)
		{
			throw null;
		}

		/// <summary>
		/// Gets the resource prefix used to look up the resource.
		/// </summary>
		/// <param name="typeInfo">The type of the resource to be looked up.</param>
		/// <returns>The prefix for resource lookup.</returns>
		protected virtual string GetResourcePrefix(TypeInfo typeInfo)
		{
			throw null;
		}

		/// <summary>
		/// Gets the resource prefix used to look up the resource.
		/// </summary>
		/// <param name="typeInfo">The type of the resource to be looked up.</param>
		/// <param name="baseNamespace">The base namespace of the application.</param>
		/// <param name="resourcesRelativePath">The folder containing all resources.</param>
		/// <returns>The prefix for resource lookup.</returns>
		/// <remarks>
		/// For the type "Sample.Controllers.Home" if there's a resourceRelativePath return
		/// "Sample.Resourcepath.Controllers.Home" if there isn't one then it would return "Sample.Controllers.Home".
		/// </remarks>
		protected virtual string GetResourcePrefix(TypeInfo typeInfo, string? baseNamespace, string? resourcesRelativePath)
		{
			throw null;
		}

		/// <summary>
		/// Gets the resource prefix used to look up the resource.
		/// </summary>
		/// <param name="baseResourceName">The name of the resource to be looked up</param>
		/// <param name="baseNamespace">The base namespace of the application.</param>
		/// <returns>The prefix for resource lookup.</returns>
		protected virtual string GetResourcePrefix(string baseResourceName, string baseNamespace)
		{
			throw null;
		}

		/// <summary>
		/// Creates a <see cref="T:Microsoft.Extensions.Localization.ResourceManagerStringLocalizer" /> using the <see cref="T:System.Reflection.Assembly" /> and
		/// <see cref="P:System.Type.FullName" /> of the specified <see cref="T:System.Type" />.
		/// </summary>
		/// <param name="resourceSource">The <see cref="T:System.Type" />.</param>
		/// <returns>The <see cref="T:Microsoft.Extensions.Localization.ResourceManagerStringLocalizer" />.</returns>
		public IStringLocalizer Create(Type resourceSource)
		{
			throw null;
		}

		/// <summary>
		/// Creates a <see cref="T:Microsoft.Extensions.Localization.ResourceManagerStringLocalizer" />.
		/// </summary>
		/// <param name="baseName">The base name of the resource to load strings from.</param>
		/// <param name="location">The location to load resources from.</param>
		/// <returns>The <see cref="T:Microsoft.Extensions.Localization.ResourceManagerStringLocalizer" />.</returns>
		public IStringLocalizer Create(string baseName, string location)
		{
			throw null;
		}

		/// <summary>Creates a <see cref="T:Microsoft.Extensions.Localization.ResourceManagerStringLocalizer" /> for the given input.</summary>
		/// <param name="assembly">The assembly to create a <see cref="T:Microsoft.Extensions.Localization.ResourceManagerStringLocalizer" /> for.</param>
		/// <param name="baseName">The base name of the resource to search for.</param>
		/// <returns>A <see cref="T:Microsoft.Extensions.Localization.ResourceManagerStringLocalizer" /> for the given <paramref name="assembly" /> and <paramref name="baseName" />.</returns>
		/// <remarks>This method is virtual for testing purposes only.</remarks>
		protected virtual ResourceManagerStringLocalizer CreateResourceManagerStringLocalizer(Assembly assembly, string baseName)
		{
			throw null;
		}

		/// <summary>
		/// Gets the resource prefix used to look up the resource.
		/// </summary>
		/// <param name="location">The general location of the resource.</param>
		/// <param name="baseName">The base name of the resource.</param>
		/// <param name="resourceLocation">The location of the resource within <paramref name="location" />.</param>
		/// <returns>The resource prefix used to look up the resource.</returns>
		protected virtual string GetResourcePrefix(string location, string baseName, string resourceLocation)
		{
			throw null;
		}

		/// <summary>Gets a <see cref="T:Microsoft.Extensions.Localization.ResourceLocationAttribute" /> from the provided <see cref="T:System.Reflection.Assembly" />.</summary>
		/// <param name="assembly">The assembly to get a <see cref="T:Microsoft.Extensions.Localization.ResourceLocationAttribute" /> from.</param>
		/// <returns>The <see cref="T:Microsoft.Extensions.Localization.ResourceLocationAttribute" /> associated with the given <see cref="T:System.Reflection.Assembly" />.</returns>
		/// <remarks>This method is protected and virtual for testing purposes only.</remarks>
		protected virtual ResourceLocationAttribute? GetResourceLocationAttribute(Assembly assembly)
		{
			throw null;
		}

		/// <summary>Gets a <see cref="T:Microsoft.Extensions.Localization.RootNamespaceAttribute" /> from the provided <see cref="T:System.Reflection.Assembly" />.</summary>
		/// <param name="assembly">The assembly to get a <see cref="T:Microsoft.Extensions.Localization.RootNamespaceAttribute" /> from.</param>
		/// <returns>The <see cref="T:Microsoft.Extensions.Localization.RootNamespaceAttribute" /> associated with the given <see cref="T:System.Reflection.Assembly" />.</returns>
		/// <remarks>This method is protected and virtual for testing purposes only.</remarks>
		protected virtual RootNamespaceAttribute? GetRootNamespaceAttribute(Assembly assembly)
		{
			throw null;
		}
	}
}
