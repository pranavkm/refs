using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Components.Server
{
	/// <summary>
	/// A base class for <see cref="T:Microsoft.AspNetCore.Components.Authorization.AuthenticationStateProvider" /> services that receive an
	/// authentication state from the host environment, and revalidate it at regular intervals.
	/// </summary>
	public abstract class RevalidatingServerAuthenticationStateProvider : ServerAuthenticationStateProvider, IDisposable
	{
		/// <summary>
		/// Gets the interval between revalidation attempts.
		/// </summary>
		protected abstract TimeSpan RevalidationInterval
		{
			get;
		}

		/// <summary>
		/// Constructs an instance of <see cref="T:Microsoft.AspNetCore.Components.Server.RevalidatingServerAuthenticationStateProvider" />.
		/// </summary>
		/// <param name="loggerFactory">A logger factory.</param>
		public RevalidatingServerAuthenticationStateProvider(ILoggerFactory loggerFactory)
		{
			throw null;
		}

		/// <summary>
		/// Determines whether the authentication state is still valid.
		/// </summary>
		/// <param name="authenticationState">The current <see cref="T:Microsoft.AspNetCore.Components.Authorization.AuthenticationState" />.</param>
		/// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while performing the operation.</param>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task" /> that resolves as true if the <paramref name="authenticationState" /> is still valid, or false if it is not.</returns>
		protected abstract Task<bool> ValidateAuthenticationStateAsync(AuthenticationState authenticationState, CancellationToken cancellationToken);

		void IDisposable.Dispose()
		{
			throw null;
		}

		/// <inheritdoc />
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}
	}
}
