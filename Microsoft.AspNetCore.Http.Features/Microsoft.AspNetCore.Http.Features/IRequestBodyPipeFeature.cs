using System.IO.Pipelines;

namespace Microsoft.AspNetCore.Http.Features
{
	/// <summary>
	/// Represents the HttpRequestBody as a PipeReader.
	/// </summary>
	public interface IRequestBodyPipeFeature
	{
		/// <summary>
		/// A <see cref="T:System.IO.Pipelines.PipeReader" /> representing the request body, if any.
		/// </summary>
		PipeReader Reader
		{
			get;
		}
	}
}
