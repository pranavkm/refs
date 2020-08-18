using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace Microsoft.AspNetCore.Routing
{
	/// <summary>
	/// Represents an <see cref="T:Microsoft.AspNetCore.Routing.EndpointDataSource" /> whose values come from a collection of <see cref="T:Microsoft.AspNetCore.Routing.EndpointDataSource" /> instances.
	/// </summary>
	[DebuggerDisplay("{DebuggerDisplayString,nq}")]
	public sealed class CompositeEndpointDataSource : EndpointDataSource
	{
		public IEnumerable<EndpointDataSource> DataSources
		{
			get
			{
				throw null;
			}
		}

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

		internal CompositeEndpointDataSource(ObservableCollection<EndpointDataSource> dataSources)
		{
			throw null;
		}

		public CompositeEndpointDataSource(IEnumerable<EndpointDataSource> endpointDataSources)
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
