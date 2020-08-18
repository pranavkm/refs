using System;

namespace Microsoft.AspNetCore.Http
{
	/// <summary>
	/// Provides methods to create middleware.
	/// </summary>
	public interface IMiddlewareFactory
	{
		/// <summary>
		/// Creates a middleware instance for each request.
		/// </summary>
		/// <param name="middlewareType">The concrete <see cref="T:System.Type" /> of the <see cref="T:Microsoft.AspNetCore.Http.IMiddleware" />.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Http.IMiddleware" /> instance.</returns>
		IMiddleware? Create(Type middlewareType);

		/// <summary>
		/// Releases a <see cref="T:Microsoft.AspNetCore.Http.IMiddleware" /> instance at the end of each request.
		/// </summary>
		/// <param name="middleware">The <see cref="T:Microsoft.AspNetCore.Http.IMiddleware" /> instance to release.</param>
		void Release(IMiddleware middleware);
	}
}
