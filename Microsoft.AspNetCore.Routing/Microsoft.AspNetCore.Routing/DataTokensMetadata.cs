using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Routing
{
	/// <summary>
	/// Metadata that defines data tokens for an <see cref="T:Microsoft.AspNetCore.Http.Endpoint" />. This metadata
	/// type provides data tokens value for <see cref="P:Microsoft.AspNetCore.Routing.RouteData.DataTokens" /> associated
	/// with an endpoint.
	/// </summary>
	public sealed class DataTokensMetadata : IDataTokensMetadata
	{
		/// <summary>
		/// Get the data tokens.
		/// </summary>
		public IReadOnlyDictionary<string, object> DataTokens
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public DataTokensMetadata(IReadOnlyDictionary<string, object> dataTokens)
		{
			throw null;
		}
	}
}
