using System.Collections.Generic;

namespace Microsoft.AspNetCore.Routing
{
	/// <summary>
	/// Represents host metadata used during routing.
	/// </summary>
	public interface IHostMetadata
	{
		/// <summary>
		/// Returns a read-only collection of hosts used during routing.
		/// Hosts will be Unicode rather than punycode, and may have a port.
		/// An empty collection means any host will be accepted.
		/// </summary>
		IReadOnlyList<string> Hosts
		{
			get;
		}
	}
}
