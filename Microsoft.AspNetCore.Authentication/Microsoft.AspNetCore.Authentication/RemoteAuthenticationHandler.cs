using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Authentication
{
	public abstract class RemoteAuthenticationHandler<TOptions> : AuthenticationHandler<TOptions>, IAuthenticationRequestHandler, IAuthenticationHandler where TOptions : RemoteAuthenticationOptions, new()
	{
		protected string? SignInScheme
		{
			[System.Runtime.CompilerServices.NullableContext(2)]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// The handler calls methods on the events which give the application control at certain points where processing is occurring.
		/// If it is not provided a default instance is supplied which does nothing when the methods are called.
		/// </summary>
		protected new RemoteAuthenticationEvents Events
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		protected RemoteAuthenticationHandler(IOptionsMonitor<TOptions> options, ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock)
		{
			throw null;
		}

		protected override Task<object> CreateEventsAsync()
		{
			throw null;
		}

		public virtual Task<bool> ShouldHandleRequestAsync()
		{
			throw null;
		}

		[AsyncStateMachine(typeof(RemoteAuthenticationHandler<>._003CHandleRequestAsync_003Ed__11))]
		[DebuggerStepThrough]
		public virtual Task<bool> HandleRequestAsync()
		{
			throw null;
		}

		/// <summary>
		/// Authenticate the user identity with the identity provider.
		///
		/// The method process the request on the endpoint defined by CallbackPath.
		/// </summary>
		protected abstract Task<HandleRequestResult> HandleRemoteAuthenticateAsync();

		[AsyncStateMachine(typeof(RemoteAuthenticationHandler<>._003CHandleAuthenticateAsync_003Ed__13))]
		[DebuggerStepThrough]
		protected override Task<AuthenticateResult> HandleAuthenticateAsync()
		{
			throw null;
		}

		protected override Task HandleForbiddenAsync(AuthenticationProperties properties)
		{
			throw null;
		}

		protected virtual void GenerateCorrelationId(AuthenticationProperties properties)
		{
			throw null;
		}

		protected virtual bool ValidateCorrelationId(AuthenticationProperties properties)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(RemoteAuthenticationHandler<>._003CHandleAccessDeniedErrorAsync_003Ed__17))]
		[DebuggerStepThrough]
		protected virtual Task<HandleRequestResult> HandleAccessDeniedErrorAsync(AuthenticationProperties properties)
		{
			throw null;
		}
	}
}
