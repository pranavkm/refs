using Microsoft.AspNetCore.Localization;

namespace Microsoft.AspNetCore.Builder
{
	/// <summary>
	/// Extension methods for the <see cref="T:Microsoft.AspNetCore.Builder.RequestLocalizationOptions" />.
	/// </summary>
	public static class RequestLocalizationOptionsExtensions
	{
		/// <summary>
		/// Adds a new <see cref="T:Microsoft.AspNetCore.Localization.RequestCultureProvider" /> to the <see cref="P:Microsoft.AspNetCore.Builder.RequestLocalizationOptions.RequestCultureProviders" />.
		/// </summary>
		/// <param name="requestLocalizationOptions">The cultures to be added.</param>
		/// <param name="requestCultureProvider">The cultures to be added.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Builder.RequestLocalizationOptions" />.</returns>
		/// <remarks>This method ensures that <paramref name="requestCultureProvider" /> has priority over other <see cref="T:Microsoft.AspNetCore.Localization.RequestCultureProvider" /> instances in <see cref="P:Microsoft.AspNetCore.Builder.RequestLocalizationOptions.RequestCultureProviders" />.</remarks>
		public static RequestLocalizationOptions AddInitialRequestCultureProvider(this RequestLocalizationOptions requestLocalizationOptions, RequestCultureProvider requestCultureProvider)
		{
			throw null;
		}
	}
}
