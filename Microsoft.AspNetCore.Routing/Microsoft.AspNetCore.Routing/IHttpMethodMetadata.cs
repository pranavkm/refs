using System.Collections.Generic;

namespace Microsoft.AspNetCore.Routing
{
	/// <summary>
	/// Represents HTTP method metadata used during routing.
	/// </summary>
	public interface IHttpMethodMetadata
	{
		/// <summary>
		/// Returns a value indicating whether the associated endpoint should accept CORS preflight requests.
		/// </summary>
		bool AcceptCorsPreflight
		{
			get;
		}

		/// <summary>
		/// Returns a read-only collection of HTTP methods used during routing.
		/// An empty collection means any HTTP method will be accepted.
		/// </summary>
		IReadOnlyList<string> HttpMethods
		{
			get;
		}
	}
}
