using System.Globalization;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Localization
{
	/// <summary>
	/// Details about the culture for an <see cref="T:Microsoft.AspNetCore.Http.HttpRequest" />.
	/// </summary>
	public class RequestCulture
	{
		/// <summary>
		/// Gets the <see cref="T:System.Globalization.CultureInfo" /> for the request to be used for formatting.
		/// </summary>
		public CultureInfo Culture
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the <see cref="T:System.Globalization.CultureInfo" /> for the request to be used for text, i.e. language;
		/// </summary>
		public CultureInfo UICulture
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates a new <see cref="T:Microsoft.AspNetCore.Localization.RequestCulture" /> object with its <see cref="P:Microsoft.AspNetCore.Localization.RequestCulture.Culture" /> and <see cref="P:Microsoft.AspNetCore.Localization.RequestCulture.UICulture" />
		/// properties set to the same <see cref="T:System.Globalization.CultureInfo" /> value.
		/// </summary>
		/// <param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> for the request.</param>
		public RequestCulture(CultureInfo culture)
		{
			throw null;
		}

		/// <summary>
		/// Creates a new <see cref="T:Microsoft.AspNetCore.Localization.RequestCulture" /> object with its <see cref="P:Microsoft.AspNetCore.Localization.RequestCulture.Culture" /> and <see cref="P:Microsoft.AspNetCore.Localization.RequestCulture.UICulture" />
		/// properties set to the same <see cref="T:System.Globalization.CultureInfo" /> value.
		/// </summary>
		/// <param name="culture">The culture for the request.</param>
		public RequestCulture(string culture)
		{
			throw null;
		}

		/// <summary>
		/// Creates a new <see cref="T:Microsoft.AspNetCore.Localization.RequestCulture" /> object with its <see cref="P:Microsoft.AspNetCore.Localization.RequestCulture.Culture" /> and <see cref="P:Microsoft.AspNetCore.Localization.RequestCulture.UICulture" />
		/// properties set to the respective <see cref="T:System.Globalization.CultureInfo" /> values provided.
		/// </summary>
		/// <param name="culture">The culture for the request to be used for formatting.</param>
		/// <param name="uiCulture">The culture for the request to be used for text, i.e. language.</param>
		public RequestCulture(string culture, string uiCulture)
		{
			throw null;
		}

		/// <summary>
		/// Creates a new <see cref="T:Microsoft.AspNetCore.Localization.RequestCulture" /> object with its <see cref="P:Microsoft.AspNetCore.Localization.RequestCulture.Culture" /> and <see cref="P:Microsoft.AspNetCore.Localization.RequestCulture.UICulture" />
		/// properties set to the respective <see cref="T:System.Globalization.CultureInfo" /> values provided.
		/// </summary>
		/// <param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> for the request to be used for formatting.</param>
		/// <param name="uiCulture">The <see cref="T:System.Globalization.CultureInfo" /> for the request to be used for text, i.e. language.</param>
		public RequestCulture(CultureInfo culture, CultureInfo uiCulture)
		{
			throw null;
		}
	}
}
