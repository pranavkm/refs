using System.Collections.Generic;

namespace Microsoft.AspNetCore.Routing
{
	/// <summary>
	/// Information about the current routing path.
	/// </summary>
	public class RouteData
	{
		/// <summary>
		/// A snapshot of the state of a <see cref="T:Microsoft.AspNetCore.Routing.RouteData" /> instance.
		/// </summary>
		public readonly struct RouteDataSnapshot
		{
			private readonly RouteData _routeData;

			private readonly RouteValueDictionary? _dataTokens;

			private readonly IList<IRouter>? _routers;

			private readonly RouteValueDictionary? _values;

			/// <summary>
			/// Creates a new instance of <see cref="T:Microsoft.AspNetCore.Routing.RouteData.RouteDataSnapshot" /> for <paramref name="routeData" />.
			/// </summary>
			/// <param name="routeData">The <see cref="T:Microsoft.AspNetCore.Routing.RouteData" />.</param>
			/// <param name="dataTokens">The data tokens.</param>
			/// <param name="routers">The routers.</param>
			/// <param name="values">The route values.</param>
			public RouteDataSnapshot(RouteData routeData, RouteValueDictionary? dataTokens, IList<IRouter>? routers, RouteValueDictionary? values)
			{
				throw null;
			}

			/// <summary>
			/// Restores the <see cref="T:Microsoft.AspNetCore.Routing.RouteData" /> to the captured state.
			/// </summary>
			public void Restore()
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the data tokens produced by routes on the current routing path.
		/// </summary>
		public RouteValueDictionary DataTokens
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the list of <see cref="T:Microsoft.AspNetCore.Routing.IRouter" /> instances on the current routing path.
		/// </summary>
		public IList<IRouter> Routers
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the values produced by routes on the current routing path.
		/// </summary>
		public RouteValueDictionary Values
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates a new instance of <see cref="T:Microsoft.AspNetCore.Routing.RouteData" /> instance.
		/// </summary>
		public RouteData()
		{
			throw null;
		}

		/// <summary>
		/// Creates a new instance of <see cref="T:Microsoft.AspNetCore.Routing.RouteData" /> instance with values copied from <paramref name="other" />.
		/// </summary>
		/// <param name="other">The other <see cref="T:Microsoft.AspNetCore.Routing.RouteData" /> instance to copy.</param>
		public RouteData(RouteData other)
		{
			throw null;
		}

		/// <summary>
		/// Creates a new instance of <see cref="T:Microsoft.AspNetCore.Routing.RouteData" /> instance with the specified values.
		/// </summary>
		/// <param name="values">The <see cref="T:Microsoft.AspNetCore.Routing.RouteValueDictionary" /> values.</param>
		public RouteData(RouteValueDictionary values)
		{
			throw null;
		}

		/// <summary>
		/// <para>
		/// Creates a snapshot of the current state of the <see cref="T:Microsoft.AspNetCore.Routing.RouteData" /> before appending
		/// <paramref name="router" /> to <see cref="P:Microsoft.AspNetCore.Routing.RouteData.Routers" />, merging <paramref name="values" /> into
		/// <see cref="P:Microsoft.AspNetCore.Routing.RouteData.Values" />, and merging <paramref name="dataTokens" /> into <see cref="P:Microsoft.AspNetCore.Routing.RouteData.DataTokens" />.
		/// </para>
		/// <para>
		/// Call <see cref="M:Microsoft.AspNetCore.Routing.RouteData.RouteDataSnapshot.Restore" /> to restore the state of this <see cref="T:Microsoft.AspNetCore.Routing.RouteData" />
		/// to the state at the time of calling
		/// <see cref="M:Microsoft.AspNetCore.Routing.RouteData.PushState(Microsoft.AspNetCore.Routing.IRouter,Microsoft.AspNetCore.Routing.RouteValueDictionary,Microsoft.AspNetCore.Routing.RouteValueDictionary)" />.
		/// </para>
		/// </summary>
		/// <param name="router">
		/// An <see cref="T:Microsoft.AspNetCore.Routing.IRouter" /> to append to <see cref="P:Microsoft.AspNetCore.Routing.RouteData.Routers" />. If <c>null</c>, then <see cref="P:Microsoft.AspNetCore.Routing.RouteData.Routers" />
		/// will not be changed.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:Microsoft.AspNetCore.Routing.RouteValueDictionary" /> to merge into <see cref="P:Microsoft.AspNetCore.Routing.RouteData.Values" />. If <c>null</c>, then
		/// <see cref="P:Microsoft.AspNetCore.Routing.RouteData.Values" /> will not be changed.
		/// </param>
		/// <param name="dataTokens">
		/// A <see cref="T:Microsoft.AspNetCore.Routing.RouteValueDictionary" /> to merge into <see cref="P:Microsoft.AspNetCore.Routing.RouteData.DataTokens" />. If <c>null</c>, then
		/// <see cref="P:Microsoft.AspNetCore.Routing.RouteData.DataTokens" /> will not be changed.
		/// </param>
		/// <returns>A <see cref="T:Microsoft.AspNetCore.Routing.RouteData.RouteDataSnapshot" /> that captures the current state.</returns>
		public RouteDataSnapshot PushState(IRouter? router, RouteValueDictionary? values, RouteValueDictionary? dataTokens)
		{
			throw null;
		}
	}
}
