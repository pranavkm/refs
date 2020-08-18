using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Localization
{
	/// <summary>
	/// An abstract base class provider for determining the culture information of an <see cref="T:Microsoft.AspNetCore.Http.HttpRequest" />.
	/// </summary>
	public abstract class RequestCultureProvider : IRequestCultureProvider
	{
		/// <summary>
		/// Result that indicates that this instance of <see cref="T:Microsoft.AspNetCore.Localization.RequestCultureProvider" /> could not determine the
		/// request culture.
		/// </summary>
		protected static readonly Task<ProviderCultureResult> NullProviderCultureResult;

		/// <summary>
		/// The current options for the <see cref="T:Microsoft.AspNetCore.Localization.RequestLocalizationMiddleware" />.
		/// </summary>
		public RequestLocalizationOptions Options
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
		public abstract Task<ProviderCultureResult> DetermineProviderCultureResult(HttpContext httpContext);

		protected RequestCultureProvider()
		{
			throw null;
		}
	}
}
