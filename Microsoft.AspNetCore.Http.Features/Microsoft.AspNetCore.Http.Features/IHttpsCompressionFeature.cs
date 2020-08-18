namespace Microsoft.AspNetCore.Http.Features
{
	/// <summary>
	/// Configures response compression behavior for HTTPS on a per-request basis.
	/// </summary>
	public interface IHttpsCompressionFeature
	{
		/// <summary>
		/// The <see cref="T:Microsoft.AspNetCore.Http.Features.HttpsCompressionMode" /> to use.
		/// </summary>
		HttpsCompressionMode Mode
		{
			get;
			set;
		}
	}
}
