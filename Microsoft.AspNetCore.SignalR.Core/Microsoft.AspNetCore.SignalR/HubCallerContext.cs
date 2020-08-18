using Microsoft.AspNetCore.Http.Features;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Threading;

namespace Microsoft.AspNetCore.SignalR
{
	/// <summary>
	/// A context abstraction for accessing information about the hub caller connection.
	/// </summary>
	public abstract class HubCallerContext
	{
		/// <summary>
		/// Gets the connection ID.
		/// </summary>
		public abstract string ConnectionId
		{
			get;
		}

		/// <summary>
		/// Gets the user identifier.
		/// </summary>
		public abstract string? UserIdentifier
		{
			[System.Runtime.CompilerServices.NullableContext(2)]
			get;
		}

		/// <summary>
		/// Gets the user.
		/// </summary>
		public abstract ClaimsPrincipal? User
		{
			[System.Runtime.CompilerServices.NullableContext(2)]
			get;
		}

		/// <summary>
		/// Gets a key/value collection that can be used to share data within the scope of this connection.
		/// </summary>
		public abstract IDictionary<object, object?> Items
		{
			get;
		}

		/// <summary>
		/// Gets the collection of HTTP features available on the connection.
		/// </summary>
		public abstract IFeatureCollection Features
		{
			get;
		}

		/// <summary>
		/// Gets a <see cref="T:System.Threading.CancellationToken" /> that notifies when the connection is aborted.
		/// </summary>
		public abstract CancellationToken ConnectionAborted
		{
			get;
		}

		/// <summary>
		/// Aborts the connection.
		/// </summary>
		public abstract void Abort();

		protected HubCallerContext()
		{
			throw null;
		}
	}
}
