using System.IO.Pipelines;

namespace Microsoft.AspNetCore.Http.Features
{
	public class RequestBodyPipeFeature : IRequestBodyPipeFeature
	{
		public PipeReader Reader
		{
			get
			{
				throw null;
			}
		}

		public RequestBodyPipeFeature(HttpContext context)
		{
			throw null;
		}
	}
}
