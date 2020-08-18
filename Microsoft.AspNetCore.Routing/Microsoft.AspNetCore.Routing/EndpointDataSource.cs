using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.Routing
{
	/// <summary>
	/// Provides a collection of <see cref="T:Microsoft.AspNetCore.Http.Endpoint" /> instances.
	/// </summary>
	public abstract class EndpointDataSource
	{
		/// <summary>
		/// Returns a read-only collection of <see cref="T:Microsoft.AspNetCore.Http.Endpoint" /> instances.
		/// </summary>
		public abstract IReadOnlyList<Endpoint> Endpoints
		{
			get;
		}

		/// <summary>
		/// Gets a <see cref="T:Microsoft.Extensions.Primitives.IChangeToken" /> used to signal invalidation of cached <see cref="T:Microsoft.AspNetCore.Http.Endpoint" />
		/// instances.
		/// </summary>
		/// <returns>The <see cref="T:Microsoft.Extensions.Primitives.IChangeToken" />.</returns>
		public abstract IChangeToken GetChangeToken();

		protected EndpointDataSource()
		{
			throw null;
		}
	}
}
