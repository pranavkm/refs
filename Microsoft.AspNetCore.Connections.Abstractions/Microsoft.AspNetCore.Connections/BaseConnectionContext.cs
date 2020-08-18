using Microsoft.AspNetCore.Http.Features;
using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Connections
{
	public abstract class BaseConnectionContext : IAsyncDisposable
	{
		/// <summary>
		/// Gets or sets a unique identifier to represent this connection in trace logs.
		/// </summary>
		public abstract string ConnectionId
		{
			[System.Runtime.CompilerServices.NullableContext(1)]
			get;
			[System.Runtime.CompilerServices.NullableContext(1)]
			set;
		}

		/// <summary>
		/// Gets the collection of features provided by the server and middleware available on this connection.
		/// </summary>
		public abstract IFeatureCollection Features
		{
			[System.Runtime.CompilerServices.NullableContext(1)]
			get;
		}

		/// <summary>
		/// Gets or sets a key/value collection that can be used to share data within the scope of this connection.
		/// </summary>
		public abstract IDictionary<object, object?> Items
		{
			get;
			set;
		}

		/// <summary>
		/// Triggered when the client connection is closed.
		/// </summary>
		public virtual CancellationToken ConnectionClosed
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets the local endpoint for this connection.
		/// </summary>
		public virtual EndPoint? LocalEndPoint
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets the remote endpoint for this connection.
		/// </summary>
		public virtual EndPoint? RemoteEndPoint
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Aborts the underlying connection.
		/// </summary>
		public abstract void Abort();

		/// <summary>
		/// Aborts the underlying connection.
		/// </summary>
		/// <param name="abortReason">An optional <see cref="T:Microsoft.AspNetCore.Connections.ConnectionAbortedException" /> describing the reason the connection is being terminated.</param>
		public abstract void Abort(ConnectionAbortedException abortReason);

		/// <summary>
		/// Releases resources for the underlying connection.
		/// </summary>
		/// <returns>A <see cref="T:System.Threading.Tasks.ValueTask" /> that completes when resources have been released.</returns>
		public virtual ValueTask DisposeAsync()
		{
			throw null;
		}

		protected BaseConnectionContext()
		{
			throw null;
		}
	}
}
