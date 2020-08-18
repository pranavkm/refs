using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Authentication
{
	public abstract class AuthenticationHandler<TOptions> : IAuthenticationHandler where TOptions : AuthenticationSchemeOptions, new()
	{
		public AuthenticationScheme Scheme
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public TOptions Options
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		protected HttpContext Context
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		protected HttpRequest Request
		{
			get
			{
				throw null;
			}
		}

		protected HttpResponse Response
		{
			get
			{
				throw null;
			}
		}

		protected PathString OriginalPath
		{
			get
			{
				throw null;
			}
		}

		protected PathString OriginalPathBase
		{
			get
			{
				throw null;
			}
		}

		protected ILogger Logger
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		protected UrlEncoder UrlEncoder
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		protected ISystemClock Clock
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		protected IOptionsMonitor<TOptions> OptionsMonitor
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// The handler calls methods on the events which give the application control at certain points where processing is occurring. 
		/// If it is not provided a default instance is supplied which does nothing when the methods are called.
		/// </summary>
		protected virtual object? Events
		{
			[System.Runtime.CompilerServices.NullableContext(2)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[System.Runtime.CompilerServices.NullableContext(2)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		protected virtual string ClaimsIssuer
		{
			get
			{
				throw null;
			}
		}

		protected string CurrentUri
		{
			get
			{
				throw null;
			}
		}

		protected AuthenticationHandler(IOptionsMonitor<TOptions> options, ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock)
		{
			throw null;
		}

		/// <summary>
		/// Initialize the handler, resolve the options and validate them.
		/// </summary>
		/// <param name="scheme"></param>
		/// <param name="context"></param>
		/// <returns></returns>
		[AsyncStateMachine(typeof(AuthenticationHandler<>._003CInitializeAsync_003Ed__42))]
		[DebuggerStepThrough]
		public Task InitializeAsync(AuthenticationScheme scheme, HttpContext context)
		{
			throw null;
		}

		/// <summary>
		/// Initializes the events object, called once per request by <see cref="M:Microsoft.AspNetCore.Authentication.AuthenticationHandler`1.InitializeAsync(Microsoft.AspNetCore.Authentication.AuthenticationScheme,Microsoft.AspNetCore.Http.HttpContext)" />.
		/// </summary>
		[AsyncStateMachine(typeof(AuthenticationHandler<>._003CInitializeEventsAsync_003Ed__43))]
		[DebuggerStepThrough]
		protected virtual Task InitializeEventsAsync()
		{
			throw null;
		}

		/// <summary>
		/// Creates a new instance of the events instance.
		/// </summary>
		/// <returns>A new instance of the events instance.</returns>
		protected virtual Task<object> CreateEventsAsync()
		{
			throw null;
		}

		/// <summary>
		/// Called after options/events have been initialized for the handler to finish initializing itself.
		/// </summary>
		/// <returns>A task</returns>
		protected virtual Task InitializeHandlerAsync()
		{
			throw null;
		}

		protected string BuildRedirectUri(string targetPath)
		{
			throw null;
		}

		protected virtual string? ResolveTarget(string? scheme)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(AuthenticationHandler<>._003CAuthenticateAsync_003Ed__48))]
		[DebuggerStepThrough]
		public Task<AuthenticateResult> AuthenticateAsync()
		{
			throw null;
		}

		/// <summary>
		/// Used to ensure HandleAuthenticateAsync is only invoked once. The subsequent calls
		/// will return the same authenticate result.
		/// </summary>
		protected Task<AuthenticateResult> HandleAuthenticateOnceAsync()
		{
			throw null;
		}

		/// <summary>
		/// Used to ensure HandleAuthenticateAsync is only invoked once safely. The subsequent
		/// calls will return the same authentication result. Any exceptions will be converted
		/// into a failed authentication result containing the exception.
		/// </summary>
		[AsyncStateMachine(typeof(AuthenticationHandler<>._003CHandleAuthenticateOnceSafeAsync_003Ed__50))]
		[DebuggerStepThrough]
		protected Task<AuthenticateResult> HandleAuthenticateOnceSafeAsync()
		{
			throw null;
		}

		protected abstract Task<AuthenticateResult> HandleAuthenticateAsync();

		/// <summary>
		/// Override this method to handle Forbid.
		/// </summary>
		/// <param name="properties"></param>
		/// <returns>A Task.</returns>
		protected virtual Task HandleForbiddenAsync(AuthenticationProperties properties)
		{
			throw null;
		}

		/// <summary>
		/// Override this method to deal with 401 challenge concerns, if an authentication scheme in question
		/// deals an authentication interaction as part of it's request flow. (like adding a response header, or
		/// changing the 401 result to 302 of a login page or external sign-in location.)
		/// </summary>
		/// <param name="properties"></param>
		/// <returns>A Task.</returns>
		protected virtual Task HandleChallengeAsync(AuthenticationProperties properties)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(AuthenticationHandler<>._003CChallengeAsync_003Ed__54))]
		[DebuggerStepThrough]
		public Task ChallengeAsync(AuthenticationProperties? properties)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(AuthenticationHandler<>._003CForbidAsync_003Ed__55))]
		[DebuggerStepThrough]
		public Task ForbidAsync(AuthenticationProperties? properties)
		{
			throw null;
		}
	}
}
