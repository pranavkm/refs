using System.Collections.Generic;

namespace Microsoft.AspNetCore.Routing
{
	/// <summary>
	/// Metadata that defines data tokens for an <see cref="T:Microsoft.AspNetCore.Http.Endpoint" />. This metadata
	/// type provides data tokens value for <see cref="P:Microsoft.AspNetCore.Routing.RouteData.DataTokens" /> associated
	/// with an endpoint.
	/// </summary>
	public interface IDataTokensMetadata
	{
		/// <summary>
		/// Get the data tokens.
		/// </summary>
		IReadOnlyDictionary<string, object> DataTokens
		{
			get;
		}
	}
}
