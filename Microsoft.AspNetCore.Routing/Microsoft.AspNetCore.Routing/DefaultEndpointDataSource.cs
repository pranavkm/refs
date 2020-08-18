using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.Routing
{
	/// <summary>
	/// Provides a collection of <see cref="T:Microsoft.AspNetCore.Http.Endpoint" /> instances.
	/// </summary>
	public sealed class DefaultEndpointDataSource : EndpointDataSource
	{
		/// <summary>
		/// Returns a read-only collection of <see cref="T:Microsoft.AspNetCore.Http.Endpoint" /> instances.
		/// </summary>
		public override IReadOnlyList<Endpoint> Endpoints
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.Routing.DefaultEndpointDataSource" /> class.
		/// </summary>
		/// <param name="endpoints">The <see cref="T:Microsoft.AspNetCore.Http.Endpoint" /> instances that the data source will return.</param>
		public DefaultEndpointDataSource(params Endpoint[] endpoints)
		{
			throw null;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.Routing.DefaultEndpointDataSource" /> class.
		/// </summary>
		/// <param name="endpoints">The <see cref="T:Microsoft.AspNetCore.Http.Endpoint" /> instances that the data source will return.</param>
		public DefaultEndpointDataSource(IEnumerable<Endpoint> endpoints)
		{
			throw null;
		}

		/// <summary>
		/// Gets a <see cref="T:Microsoft.Extensions.Primitives.IChangeToken" /> used to signal invalidation of cached <see cref="T:Microsoft.AspNetCore.Http.Endpoint" />
		/// instances.
		/// </summary>
		/// <returns>The <see cref="T:Microsoft.Extensions.Primitives.IChangeToken" />.</returns>
		public override IChangeToken GetChangeToken()
		{
			throw null;
		}
	}
}
