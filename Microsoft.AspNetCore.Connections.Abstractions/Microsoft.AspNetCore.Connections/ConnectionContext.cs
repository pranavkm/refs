using System;
using System.IO.Pipelines;

namespace Microsoft.AspNetCore.Connections
{
	/// <summary>
	/// Encapsulates all information about an individual connection.
	/// </summary>
	public abstract class ConnectionContext : BaseConnectionContext, IAsyncDisposable
	{
		/// <summary>
		/// Gets or sets the <see cref="T:System.IO.Pipelines.IDuplexPipe" /> that can be used to read or write data on this connection.
		/// </summary>
		public abstract IDuplexPipe Transport
		{
			get;
			set;
		}

		/// <summary>
		/// Aborts the underlying connection.
		/// </summary>
		/// <param name="abortReason">An optional <see cref="T:Microsoft.AspNetCore.Connections.ConnectionAbortedException" /> describing the reason the connection is being terminated.</param>
		public override void Abort(ConnectionAbortedException abortReason)
		{
			throw null;
		}

		/// <summary>
		/// Aborts the underlying connection.
		/// </summary>
		public override void Abort()
		{
			throw null;
		}

		protected ConnectionContext()
		{
			throw null;
		}
	}
}
