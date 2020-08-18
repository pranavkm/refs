namespace Microsoft.AspNetCore.Http.Features
{
	/// <summary>
	/// Feature to inspect and modify the maximum request body size for a single request.
	/// </summary>
	public interface IHttpMaxRequestBodySizeFeature
	{
		/// <summary>
		/// Indicates whether <see cref="P:Microsoft.AspNetCore.Http.Features.IHttpMaxRequestBodySizeFeature.MaxRequestBodySize" /> is read-only.
		/// If true, this could mean that the request body has already been read from
		/// or that <see cref="M:Microsoft.AspNetCore.Http.Features.IHttpUpgradeFeature.UpgradeAsync" /> was called.
		/// </summary>
		bool IsReadOnly
		{
			get;
		}

		/// <summary>
		/// The maximum allowed size of the current request body in bytes.
		/// When set to null, the maximum request body size is unlimited.
		/// This cannot be modified after the reading the request body has started.
		/// This limit does not affect upgraded connections which are always unlimited.
		/// </summary>
		/// <remarks>
		/// Defaults to the server's global max request body size limit.
		/// </remarks>
		long? MaxRequestBodySize
		{
			get;
			set;
		}
	}
}
