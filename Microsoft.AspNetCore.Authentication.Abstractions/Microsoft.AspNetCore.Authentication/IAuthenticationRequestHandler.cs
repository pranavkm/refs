using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Authentication
{
	/// <summary>
	/// Used to determine if a handler wants to participate in request processing.
	/// </summary>
	public interface IAuthenticationRequestHandler : IAuthenticationHandler
	{
		/// <summary>
		/// Returns true if request processing should stop.
		/// </summary>
		/// <returns><see langword="true" /> if request processing should stop.</returns>
		Task<bool> HandleRequestAsync();
	}
}
