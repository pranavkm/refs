using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.Routing
{
	internal sealed class DataSourceDependentCache<T> : IDisposable where T : class
	{
		public T Value
		{
			get
			{
				throw null;
			}
		}

		public DataSourceDependentCache(EndpointDataSource dataSource, Func<IReadOnlyList<Endpoint>, T> initialize)
		{
			throw null;
		}

		public T EnsureInitialized()
		{
			throw null;
		}

		public void Dispose()
		{
			throw null;
		}
	}
}
