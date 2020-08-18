using Microsoft.AspNetCore.Localization;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Builder
{
	/// <summary>
	/// Specifies options for the <see cref="T:Microsoft.AspNetCore.Localization.RequestLocalizationMiddleware" />.
	/// </summary>
	public class RequestLocalizationOptions
	{
		/// <summary>
		/// Gets or sets the default culture to use for requests when a supported culture could not be determined by
		/// one of the configured <see cref="T:Microsoft.AspNetCore.Localization.IRequestCultureProvider" />s.
		/// Defaults to <see cref="P:System.Globalization.CultureInfo.CurrentCulture" /> and <see cref="P:System.Globalization.CultureInfo.CurrentUICulture" />.
		/// </summary>
		public RequestCulture DefaultRequestCulture
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether to set a request culture to an parent culture in the case the
		/// culture determined by the configured <see cref="T:Microsoft.AspNetCore.Localization.IRequestCultureProvider" />s is not in the
		/// <see cref="P:Microsoft.AspNetCore.Builder.RequestLocalizationOptions.SupportedCultures" /> list but a parent culture is.
		/// Defaults to <c>true</c>;
		/// </summary>
		/// <remarks>
		/// Note that the parent culture check is done using only the culture name.
		/// </remarks>
		/// <example>
		/// If this property is <c>true</c> and the application is configured to support the culture "fr", but not the
		/// culture "fr-FR", and a configured <see cref="T:Microsoft.AspNetCore.Localization.IRequestCultureProvider" /> determines a request's culture is
		/// "fr-FR", then the request's culture will be set to the culture "fr", as it is a parent of "fr-FR".
		/// </example>
		public bool FallBackToParentCultures
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

		/// <summary>
		/// Gets or sets a value indicating whether to set a request UI culture to a parent culture in the case the
		/// UI culture determined by the configured <see cref="T:Microsoft.AspNetCore.Localization.IRequestCultureProvider" />s is not in the
		/// <see cref="P:Microsoft.AspNetCore.Builder.RequestLocalizationOptions.SupportedUICultures" /> list but a parent culture is.
		/// Defaults to <c>true</c>;
		/// </summary>
		/// <remarks>
		/// Note that the parent culture check is done using ony the culture name.
		/// </remarks>
		/// <example>
		/// If this property is <c>true</c> and the application is configured to support the UI culture "fr", but not
		/// the UI culture "fr-FR", and a configured <see cref="T:Microsoft.AspNetCore.Localization.IRequestCultureProvider" /> determines a request's UI
		/// culture is "fr-FR", then the request's UI culture will be set to the culture "fr", as it is a parent of
		/// "fr-FR".
		/// </example>
		public bool FallBackToParentUICultures
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

		/// <summary>
		/// Gets or sets a value that determines if <see cref="P:System.Globalization.CultureInfo.CurrentUICulture" /> is applied to the response <c>Content-Language</c> header.
		/// </summary>
		public bool ApplyCurrentCultureToResponseHeaders
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

		/// <summary>
		/// The cultures supported by the application. The <see cref="T:Microsoft.AspNetCore.Localization.RequestLocalizationMiddleware" /> will only set
		/// the current request culture to an entry in this list.
		/// Defaults to <see cref="P:System.Globalization.CultureInfo.CurrentCulture" />.
		/// </summary>
		public IList<CultureInfo> SupportedCultures
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

		/// <summary>
		/// The UI cultures supported by the application. The <see cref="T:Microsoft.AspNetCore.Localization.RequestLocalizationMiddleware" /> will only set
		/// the current request culture to an entry in this list.
		/// Defaults to <see cref="P:System.Globalization.CultureInfo.CurrentUICulture" />.
		/// </summary>
		public IList<CultureInfo> SupportedUICultures
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

		/// <summary>
		/// An ordered list of providers used to determine a request's culture information. The first provider that
		/// returns a non-<c>null</c> result for a given request will be used.
		/// Defaults to the following:
		/// <list type="number">
		///     <item><description><see cref="T:Microsoft.AspNetCore.Localization.QueryStringRequestCultureProvider" /></description></item>
		///     <item><description><see cref="T:Microsoft.AspNetCore.Localization.CookieRequestCultureProvider" /></description></item>
		///     <item><description><see cref="T:Microsoft.AspNetCore.Localization.AcceptLanguageHeaderRequestCultureProvider" /></description></item>
		/// </list>
		/// </summary>
		public IList<IRequestCultureProvider> RequestCultureProviders
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

		/// <summary>
		/// Creates a new <see cref="T:Microsoft.AspNetCore.Builder.RequestLocalizationOptions" /> with default values.
		/// </summary>
		public RequestLocalizationOptions()
		{
			throw null;
		}

		/// <summary>
		/// Adds the set of the supported cultures by the application.
		/// </summary>
		/// <param name="cultures">The cultures to be added.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Builder.RequestLocalizationOptions" />.</returns>
		public RequestLocalizationOptions AddSupportedCultures(params string[] cultures)
		{
			throw null;
		}

		/// <summary>
		/// Adds the set of the supported UI cultures by the application.
		/// </summary>
		/// <param name="uiCultures">The UI cultures to be added.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Builder.RequestLocalizationOptions" />.</returns>
		public RequestLocalizationOptions AddSupportedUICultures(params string[] uiCultures)
		{
			throw null;
		}

		/// <summary>
		/// Set the default culture which is used by the application when a supported culture could not be determined by
		/// one of the configured <see cref="T:Microsoft.AspNetCore.Localization.IRequestCultureProvider" />s.
		/// </summary>
		/// <param name="defaultCulture">The default culture to be set.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Builder.RequestLocalizationOptions" />.</returns>
		public RequestLocalizationOptions SetDefaultCulture(string defaultCulture)
		{
			throw null;
		}
	}
}
