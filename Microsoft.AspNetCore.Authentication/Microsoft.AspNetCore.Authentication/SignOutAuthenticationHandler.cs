using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Authentication
{
	/// <summary>
	/// Adds support for SignOutAsync
	/// </summary>
	public abstract class SignOutAuthenticationHandler<TOptions> : AuthenticationHandler<TOptions>, IAuthenticationSignOutHandler, IAuthenticationHandler where TOptions : AuthenticationSchemeOptions, new()
	{
		public SignOutAuthenticationHandler(IOptionsMonitor<TOptions> options, ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock)
		{
			throw null;
		}

		public virtual Task SignOutAsync(AuthenticationProperties? properties)
		{
			throw null;
		}

		/// <summary>
		/// Override this method to handle SignOut.
		/// </summary>
		/// <param name="properties"></param>
		/// <returns>A Task.</returns>
		protected abstract Task HandleSignOutAsync(AuthenticationProperties? properties);
	}
}
