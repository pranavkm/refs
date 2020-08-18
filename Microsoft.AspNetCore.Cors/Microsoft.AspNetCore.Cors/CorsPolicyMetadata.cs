using Microsoft.AspNetCore.Cors.Infrastructure;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Cors
{
	/// <summary>
	/// Metadata that provides a CORS policy.
	/// </summary>
	public class CorsPolicyMetadata : ICorsPolicyMetadata, ICorsMetadata
	{
		/// <summary>
		/// The policy which needs to be applied.
		/// </summary>
		public CorsPolicy Policy
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public CorsPolicyMetadata(CorsPolicy policy)
		{
			throw null;
		}
	}
}
