namespace Microsoft.AspNetCore.Routing
{
	/// <summary>
	/// Represents metadata used during link generation. If <see cref="P:Microsoft.AspNetCore.Routing.ISuppressLinkGenerationMetadata.SuppressLinkGeneration" /> is <c>true</c> 
	/// the associated endpoint will not be used for link generation.
	/// </summary>
	public interface ISuppressLinkGenerationMetadata
	{
		/// <summary>
		/// Gets a value indicating whether the assocated endpoint should be used for link generation.
		/// </summary>
		bool SuppressLinkGeneration
		{
			get;
		}
	}
}
