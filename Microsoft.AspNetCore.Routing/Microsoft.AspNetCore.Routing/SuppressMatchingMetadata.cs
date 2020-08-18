namespace Microsoft.AspNetCore.Routing
{
	/// <summary>
	/// Metadata used to prevent URL matching. If <see cref="P:Microsoft.AspNetCore.Routing.SuppressMatchingMetadata.SuppressMatching" /> is <c>true</c> the
	/// associated endpoint will not be considered for URL matching.
	/// </summary>
	public sealed class SuppressMatchingMetadata : ISuppressMatchingMetadata
	{
		/// <summary>
		/// Gets a value indicating whether the assocated endpoint should be used for URL matching.
		/// </summary>
		public bool SuppressMatching
		{
			get
			{
				throw null;
			}
		}

		public SuppressMatchingMetadata()
		{
			throw null;
		}
	}
}
