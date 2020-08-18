namespace Microsoft.AspNetCore.Routing
{
	/// <summary>
	/// Represents metadata used during link generation. If <see cref="P:Microsoft.AspNetCore.Routing.SuppressLinkGenerationMetadata.SuppressLinkGeneration" /> is <c>true</c> 
	/// the associated endpoint will not be used for link generation.
	/// </summary>
	public sealed class SuppressLinkGenerationMetadata : ISuppressLinkGenerationMetadata
	{
		/// <summary>
		/// Gets a value indicating whether the assocated endpoint should be used for link generation.
		/// </summary>
		public bool SuppressLinkGeneration
		{
			get
			{
				throw null;
			}
		}

		public SuppressLinkGenerationMetadata()
		{
			throw null;
		}
	}
}
