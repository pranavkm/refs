using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Components.Server.Circuits
{
	/// <summary>
	/// A <see cref="T:Microsoft.AspNetCore.Components.Server.Circuits.CircuitHandler" /> allows running code during specific lifetime events of a <see cref="T:Microsoft.AspNetCore.Components.Server.Circuits.Circuit" />.
	/// <list type="bullet">
	/// <item>
	/// <see cref="M:Microsoft.AspNetCore.Components.Server.Circuits.CircuitHandler.OnCircuitOpenedAsync(Microsoft.AspNetCore.Components.Server.Circuits.Circuit,System.Threading.CancellationToken)" /> is invoked after an initial circuit to the client
	/// has been established.
	/// </item>
	/// <item>
	/// <see cref="M:Microsoft.AspNetCore.Components.Server.Circuits.CircuitHandler.OnConnectionUpAsync(Microsoft.AspNetCore.Components.Server.Circuits.Circuit,System.Threading.CancellationToken)" /> is invoked immediately after the completion of
	/// <see cref="M:Microsoft.AspNetCore.Components.Server.Circuits.CircuitHandler.OnCircuitOpenedAsync(Microsoft.AspNetCore.Components.Server.Circuits.Circuit,System.Threading.CancellationToken)" />. In addition, the method is invoked each time a connection is re-established
	/// with a client after it's been dropped. <see cref="M:Microsoft.AspNetCore.Components.Server.Circuits.CircuitHandler.OnConnectionDownAsync(Microsoft.AspNetCore.Components.Server.Circuits.Circuit,System.Threading.CancellationToken)" /> is invoked each time a connection
	/// is dropped.
	/// </item>
	/// <item>
	/// <see cref="M:Microsoft.AspNetCore.Components.Server.Circuits.CircuitHandler.OnCircuitClosedAsync(Microsoft.AspNetCore.Components.Server.Circuits.Circuit,System.Threading.CancellationToken)" /> is invoked prior to the server evicting the circuit to the client.
	/// Application users may use this event to save state for a client that can be later rehydrated.
	/// </item>
	/// </list>
	/// </summary>
	public abstract class CircuitHandler
	{
		/// <summary>
		/// Gets the execution order for the current instance of <see cref="T:Microsoft.AspNetCore.Components.Server.Circuits.CircuitHandler" />.
		/// <para>
		/// When multiple <see cref="T:Microsoft.AspNetCore.Components.Server.Circuits.CircuitHandler" /> instances are registered, the <see cref="P:Microsoft.AspNetCore.Components.Server.Circuits.CircuitHandler.Order" />
		/// property is used to determine the order in which instances are executed. When two handlers
		/// have the same value for <see cref="P:Microsoft.AspNetCore.Components.Server.Circuits.CircuitHandler.Order" />, their execution order is non-deterministic.
		/// </para>
		/// </summary>
		/// <value>
		/// Defaults to 0.
		/// </value>
		public virtual int Order
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Invoked when a new circuit was established.
		/// </summary>
		/// <param name="circuit">The <see cref="T:Microsoft.AspNetCore.Components.Server.Circuits.Circuit" />.</param>
		/// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> that notifies when the client connection is aborted.</param>
		/// <returns><see cref="T:System.Threading.Tasks.Task" /> that represents the asynchronous execution operation.</returns>
		public virtual Task OnCircuitOpenedAsync(Circuit circuit, CancellationToken cancellationToken)
		{
			throw null;
		}

		/// <summary>
		/// Invoked when a connection to the client was established.
		/// <para>
		/// This method is executed once initially after <see cref="M:Microsoft.AspNetCore.Components.Server.Circuits.CircuitHandler.OnCircuitOpenedAsync(Microsoft.AspNetCore.Components.Server.Circuits.Circuit,System.Threading.CancellationToken)" />
		/// and once each for each reconnect during the lifetime of a circuit.
		/// </para>
		/// </summary>
		/// <param name="circuit">The <see cref="T:Microsoft.AspNetCore.Components.Server.Circuits.Circuit" />.</param>
		/// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> that notifies when the client connection is aborted.</param>
		/// <returns><see cref="T:System.Threading.Tasks.Task" /> that represents the asynchronous execution operation.</returns>
		public virtual Task OnConnectionUpAsync(Circuit circuit, CancellationToken cancellationToken)
		{
			throw null;
		}

		/// <summary>
		/// Invoked when a connection to the client was dropped.
		/// </summary>
		/// <param name="circuit">The <see cref="T:Microsoft.AspNetCore.Components.Server.Circuits.Circuit" />.</param>
		/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" />.</param>
		/// <returns><see cref="T:System.Threading.Tasks.Task" /> that represents the asynchronous execution operation.</returns>
		public virtual Task OnConnectionDownAsync(Circuit circuit, CancellationToken cancellationToken)
		{
			throw null;
		}

		/// <summary>
		/// Invoked when a new circuit is being discarded.
		/// </summary>
		/// <param name="circuit">The <see cref="T:Microsoft.AspNetCore.Components.Server.Circuits.Circuit" />.</param>
		/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" />.</param>
		/// <returns><see cref="T:System.Threading.Tasks.Task" /> that represents the asynchronous execution operation.</returns>
		public virtual Task OnCircuitClosedAsync(Circuit circuit, CancellationToken cancellationToken)
		{
			throw null;
		}

		protected CircuitHandler()
		{
			throw null;
		}
	}
}
