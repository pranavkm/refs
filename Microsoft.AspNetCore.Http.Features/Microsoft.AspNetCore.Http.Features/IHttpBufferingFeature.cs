using System;

namespace Microsoft.AspNetCore.Http.Features
{
	[Obsolete("See IHttpRequestBodyFeature or IHttpResponseBodyFeature DisableBuffering", true)]
	public interface IHttpBufferingFeature
	{
		void DisableRequestBuffering();

		void DisableResponseBuffering();
	}
}
