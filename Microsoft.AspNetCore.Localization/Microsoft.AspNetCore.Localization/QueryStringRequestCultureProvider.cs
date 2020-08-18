using Microsoft.AspNetCore.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Localization
{
	/// <summary>
	/// Determines the culture information for a request via values in the query string.
	/// </summary>
	public class QueryStringRequestCultureProvider : RequestCultureProvider
	{
		/// <summary>
		/// The key that contains the culture name.
		/// Defaults to "culture".
		/// </summary>
		public string QueryStringKey
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
		/// The key that contains the UI culture name. If not specified or no value is found,
		/// <see cref="P:Microsoft.AspNetCore.Localization.QueryStringRequestCultureProvider.QueryStringKey" /> will be used.
		/// Defaults to "ui-culture".
		/// </summary>
		public string UIQueryStringKey
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

		public QueryStringRequestCultureProvider()
		{
			throw null;
		}
	}
}
