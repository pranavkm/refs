using System;

namespace Microsoft.Extensions.Http
{
	/// <summary>
	/// Used by the <see cref="T:Microsoft.Extensions.Http.DefaultHttpClientFactory" /> to apply additional initialization to the configure the
	/// <see cref="T:Microsoft.Extensions.Http.HttpMessageHandlerBuilder" /> immediately before <see cref="M:Microsoft.Extensions.Http.HttpMessageHandlerBuilder.Build" />
	/// is called.
	/// </summary>
	public interface IHttpMessageHandlerBuilderFilter
	{
		/// <summary>
		/// Applies additional initialization to the <see cref="T:Microsoft.Extensions.Http.HttpMessageHandlerBuilder" />
		/// </summary>
		/// <param name="next">A delegate which will run the next <see cref="T:Microsoft.Extensions.Http.IHttpMessageHandlerBuilderFilter" />.</param>
		Action<HttpMessageHandlerBuilder> Configure(Action<HttpMessageHandlerBuilder> next);
	}
}
