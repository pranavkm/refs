namespace Microsoft.AspNetCore.Http.Features
{
	/// <summary>
	/// Controls the IO behavior for the <see cref="P:Microsoft.AspNetCore.Http.Features.IHttpRequestFeature.Body" /> and <see cref="P:Microsoft.AspNetCore.Http.Features.IHttpResponseFeature.Body" /> 
	/// </summary>
	public interface IHttpBodyControlFeature
	{
		/// <summary>
		/// Gets or sets a value that controls whether synchronous IO is allowed for the <see cref="P:Microsoft.AspNetCore.Http.Features.IHttpRequestFeature.Body" /> and <see cref="P:Microsoft.AspNetCore.Http.Features.IHttpResponseFeature.Body" /> 
		/// </summary>
		bool AllowSynchronousIO
		{
			get;
			set;
		}
	}
}
