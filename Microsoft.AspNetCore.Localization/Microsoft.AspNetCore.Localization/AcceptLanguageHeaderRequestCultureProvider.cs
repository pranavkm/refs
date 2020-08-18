using Microsoft.AspNetCore.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Localization
{
	/// <summary>
	/// Determines the culture information for a request via the value of the Accept-Language header.
	/// </summary>
	public class AcceptLanguageHeaderRequestCultureProvider : RequestCultureProvider
	{
		/// <summary>
		/// The maximum number of values in the Accept-Language header to attempt to create a <see cref="T:System.Globalization.CultureInfo" />
		/// from for the current request.
		/// Defaults to <c>3</c>.
		/// </summary>
		public int MaximumAcceptLanguageHeaderValuesToTry
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

		/// <inheritdoc />
		public override Task<ProviderCultureResult> DetermineProviderCultureResult(HttpContext httpContext)
		{
			throw null;
		}

		public AcceptLanguageHeaderRequestCultureProvider()
		{
			throw null;
		}
	}
}
