using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Routing
{
	/// <summary>
	/// Attribute for providing host metdata that is used during routing.
	/// </summary>
	[DebuggerDisplay("{DebuggerToString(),nq}")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
	public sealed class HostAttribute : Attribute, IHostMetadata
	{
		/// <summary>
		/// Returns a read-only collection of hosts used during routing.
		/// Hosts will be Unicode rather than punycode, and may have a port.
		/// An empty collection means any host will be accepted.
		/// </summary>
		public IReadOnlyList<string> Hosts
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.Routing.HostAttribute" /> class.
		/// </summary>
		/// <param name="host">
		/// The host used during routing.
		/// Host should be Unicode rather than punycode, and may have a port.
		/// </param>
		public HostAttribute(string host)
		{
			throw null;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.Routing.HostAttribute" /> class.
		/// </summary>
		/// <param name="hosts">
		/// The hosts used during routing.
		/// Hosts should be Unicode rather than punycode, and may have a port.
		/// An empty collection means any host will be accepted.
		/// </param>
		public HostAttribute(params string[] hosts)
		{
			throw null;
		}
	}
}
