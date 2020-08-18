using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Routing
{
	/// <summary>
	/// Represents HTTP method metadata used during routing.
	/// </summary>
	[DebuggerDisplay("{DebuggerToString(),nq}")]
	public sealed class HttpMethodMetadata : IHttpMethodMetadata
	{
		/// <summary>
		/// Returns a value indicating whether the associated endpoint should accept CORS preflight requests.
		/// </summary>
		public bool AcceptCorsPreflight
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Returns a read-only collection of HTTP methods used during routing.
		/// An empty collection means any HTTP method will be accepted.
		/// </summary>
		public IReadOnlyList<string> HttpMethods
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.Routing.HttpMethodMetadata" /> class.
		/// </summary>
		/// <param name="httpMethods">
		/// The HTTP methods used during routing.
		/// An empty collection means any HTTP method will be accepted.
		/// </param>
		public HttpMethodMetadata(IEnumerable<string> httpMethods)
		{
			throw null;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.Routing.HttpMethodMetadata" /> class.
		/// </summary>
		/// <param name="httpMethods">
		/// The HTTP methods used during routing.
		/// An empty collection means any HTTP method will be accepted.
		/// </param>
		/// <param name="acceptCorsPreflight">A value indicating whether routing accepts CORS preflight requests.</param>
		public HttpMethodMetadata(IEnumerable<string> httpMethods, bool acceptCorsPreflight)
		{
			throw null;
		}
	}
}
