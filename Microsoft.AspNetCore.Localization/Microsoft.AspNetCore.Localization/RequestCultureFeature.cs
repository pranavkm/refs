using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Localization
{
	/// <summary>
	/// Provides the current request's culture information.
	/// </summary>
	public class RequestCultureFeature : IRequestCultureFeature
	{
		/// <inheritdoc />
		public RequestCulture RequestCulture
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <inheritdoc />
		public IRequestCultureProvider Provider
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates a new <see cref="T:Microsoft.AspNetCore.Localization.RequestCultureFeature" /> with the specified <see cref="T:Microsoft.AspNetCore.Localization.RequestCulture" />.
		/// </summary>
		/// <param name="requestCulture">The <see cref="T:Microsoft.AspNetCore.Localization.RequestCulture" />.</param>
		/// <param name="provider">The <see cref="T:Microsoft.AspNetCore.Localization.IRequestCultureProvider" />.</param>
		public RequestCultureFeature(RequestCulture requestCulture, IRequestCultureProvider provider)
		{
			throw null;
		}
	}
}
