using Microsoft.Extensions.Primitives;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Localization
{
	/// <summary>
	/// Details about the cultures obtained from <see cref="T:Microsoft.AspNetCore.Localization.IRequestCultureProvider" />.
	/// </summary>
	public class ProviderCultureResult
	{
		/// <summary>
		/// Gets the list of cultures to be used for formatting.
		/// </summary>
		public IList<StringSegment> Cultures
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the list of ui cultures to be used for text, i.e. language;
		/// </summary>
		public IList<StringSegment> UICultures
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates a new <see cref="T:Microsoft.AspNetCore.Localization.ProviderCultureResult" /> object that has its <see cref="P:Microsoft.AspNetCore.Localization.ProviderCultureResult.Cultures" /> and
		/// <see cref="P:Microsoft.AspNetCore.Localization.ProviderCultureResult.UICultures" /> properties set to the same culture value.
		/// </summary>
		/// <param name="culture">The name of the culture to be used for formatting, text, i.e. language.</param>
		public ProviderCultureResult(StringSegment culture)
		{
			throw null;
		}

		/// <summary>
		/// Creates a new <see cref="T:Microsoft.AspNetCore.Localization.ProviderCultureResult" /> object has its <see cref="P:Microsoft.AspNetCore.Localization.ProviderCultureResult.Cultures" /> and
		/// <see cref="P:Microsoft.AspNetCore.Localization.ProviderCultureResult.UICultures" /> properties set to the respective culture values provided.
		/// </summary>
		/// <param name="culture">The name of the culture to be used for formatting.</param>
		/// <param name="uiCulture"> The name of the ui culture to be used for text, i.e. language.</param>
		public ProviderCultureResult(StringSegment culture, StringSegment uiCulture)
		{
			throw null;
		}

		/// <summary>
		/// Creates a new <see cref="T:Microsoft.AspNetCore.Localization.ProviderCultureResult" /> object that has its <see cref="P:Microsoft.AspNetCore.Localization.ProviderCultureResult.Cultures" /> and
		/// <see cref="P:Microsoft.AspNetCore.Localization.ProviderCultureResult.UICultures" /> properties set to the same culture value.
		/// </summary>
		/// <param name="cultures">The list of cultures to be used for formatting, text, i.e. language.</param>
		public ProviderCultureResult(IList<StringSegment> cultures)
		{
			throw null;
		}

		/// <summary>
		/// Creates a new <see cref="T:Microsoft.AspNetCore.Localization.ProviderCultureResult" /> object has its <see cref="P:Microsoft.AspNetCore.Localization.ProviderCultureResult.Cultures" /> and
		/// <see cref="P:Microsoft.AspNetCore.Localization.ProviderCultureResult.UICultures" /> properties set to the respective culture values provided.
		/// </summary>
		/// <param name="cultures">The list of cultures to be used for formatting.</param>
		/// <param name="uiCultures">The list of ui cultures to be used for text, i.e. language.</param>
		public ProviderCultureResult(IList<StringSegment> cultures, IList<StringSegment> uiCultures)
		{
			throw null;
		}
	}
}
