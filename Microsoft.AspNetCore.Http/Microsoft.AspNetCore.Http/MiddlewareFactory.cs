using System;

namespace Microsoft.AspNetCore.Http
{
	public class MiddlewareFactory : IMiddlewareFactory
	{
		public MiddlewareFactory(IServiceProvider serviceProvider)
		{
			throw null;
		}

		public IMiddleware? Create(Type middlewareType)
		{
			throw null;
		}

		public void Release(IMiddleware middleware)
		{
			throw null;
		}
	}
}
