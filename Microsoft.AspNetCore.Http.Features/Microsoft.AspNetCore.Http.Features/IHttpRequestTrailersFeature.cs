namespace Microsoft.AspNetCore.Http.Features
{
	/// <summary>
	/// This feature exposes HTTP request trailer headers, either for HTTP/1.1 chunked bodies or HTTP/2 trailing headers.
	/// </summary>
	public interface IHttpRequestTrailersFeature
	{
		/// <summary>
		/// Indicates if the <see cref="P:Microsoft.AspNetCore.Http.Features.IHttpRequestTrailersFeature.Trailers" /> are available yet. They may not be available until the
		/// request body is fully read.
		/// </summary>
		bool Available
		{
			get;
		}

		/// <summary>
		/// The trailing headers received. This will throw <see cref="T:System.InvalidOperationException" /> if <see cref="P:Microsoft.AspNetCore.Http.Features.IHttpRequestTrailersFeature.Available" />
		/// returns false. They may not be available until the request body is fully read. If there are no trailers this will
		/// return an empty collection.
		/// </summary>
		IHeaderDictionary Trailers
		{
			get;
		}
	}
}
