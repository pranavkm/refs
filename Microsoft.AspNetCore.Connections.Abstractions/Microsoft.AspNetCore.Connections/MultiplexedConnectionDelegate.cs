using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Connections
{
	/// <summary>
	/// A function that can process a connection.
	/// </summary>
	/// <param name="connection">A <see cref="T:Microsoft.AspNetCore.Connections.MultiplexedConnectionContext" /> representing the connection.</param>
	/// <returns>A <see cref="T:System.Threading.Tasks.Task" /> that represents the connection lifetime. When the task completes, the connection will be closed.</returns>
	public delegate Task MultiplexedConnectionDelegate(MultiplexedConnectionContext connection);
}
