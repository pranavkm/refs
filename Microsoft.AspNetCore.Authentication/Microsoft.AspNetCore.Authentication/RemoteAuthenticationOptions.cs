using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Http;
using System;
using System.Net.Http;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Authentication
{
	/// <summary>
	/// Contains the options used by the <see cref="T:Microsoft.AspNetCore.Authentication.RemoteAuthenticationHandler`1" />.
	/// </summary>
	public class RemoteAuthenticationOptions : AuthenticationSchemeOptions
	{
		private class CorrelationCookieBuilder : RequestPathBaseCookieBuilder
		{
			protected override string AdditionalPath
			{
				get
				{
					throw null;
				}
			}

			public CorrelationCookieBuilder(RemoteAuthenticationOptions remoteAuthenticationOptions)
			{
				throw null;
			}

			public override CookieOptions Build(HttpContext context, DateTimeOffset expiresFrom)
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets timeout value in milliseconds for back channel communications with the remote identity provider.
		/// </summary>
		/// <value>
		/// The back channel timeout.
		/// </value>
		public TimeSpan BackchannelTimeout
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// The HttpMessageHandler used to communicate with remote identity provider.
		/// This cannot be set at the same time as BackchannelCertificateValidator unless the value 
		/// can be downcast to a WebRequestHandler.
		/// </summary>
		public HttpMessageHandler? BackchannelHttpHandler
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

		/// <summary>
		/// Used to communicate with the remote identity provider.
		/// </summary>
		public HttpClient Backchannel
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets the type used to secure data.
		/// </summary>
		public IDataProtectionProvider? DataProtectionProvider
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

		/// <summary>
		/// The request path within the application's base path where the user-agent will be returned.
		/// The middleware will process this request when it arrives.
		/// </summary>
		public PathString CallbackPath
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets the optional path the user agent is redirected to if the user
		/// doesn't approve the authorization demand requested by the remote server.
		/// This property is not set by default. In this case, an exception is thrown
		/// if an access_denied response is returned by the remote authorization server.
		/// </summary>
		public PathString AccessDeniedPath
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets the name of the parameter used to convey the original location
		/// of the user before the remote challenge was triggered up to the access denied page.
		/// This property is only used when the <see cref="P:Microsoft.AspNetCore.Authentication.RemoteAuthenticationOptions.AccessDeniedPath" /> is explicitly specified.
		/// </summary>
		public string ReturnUrlParameter
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets the authentication scheme corresponding to the middleware
		/// responsible of persisting user's identity after a successful authentication.
		/// This value typically corresponds to a cookie middleware registered in the Startup class.
		/// When omitted, <see cref="P:Microsoft.AspNetCore.Authentication.AuthenticationOptions.DefaultSignInScheme" /> is used as a fallback value.
		/// </summary>
		public string? SignInScheme
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

		/// <summary>
		/// Gets or sets the time limit for completing the authentication flow (15 minutes by default).
		/// </summary>
		public TimeSpan RemoteAuthenticationTimeout
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public new RemoteAuthenticationEvents Events
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

		/// <summary>
		/// Defines whether access and refresh tokens should be stored in the
		/// <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationProperties" /> after a successful authorization.
		/// This property is set to <c>false</c> by default to reduce
		/// the size of the final authentication cookie.
		/// </summary>
		public bool SaveTokens
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Determines the settings used to create the correlation cookie before the
		/// cookie gets added to the response.
		/// </summary>
		public CookieBuilder CorrelationCookie
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

		/// <summary>
		/// Initializes a new <see cref="T:Microsoft.AspNetCore.Authentication.RemoteAuthenticationOptions" />.
		/// </summary>
		public RemoteAuthenticationOptions()
		{
			throw null;
		}

		/// <summary>
		/// Checks that the options are valid for a specific scheme
		/// </summary>
		/// <param name="scheme">The scheme being validated.</param>
		public override void Validate(string scheme)
		{
			throw null;
		}

		/// <summary>
		/// Check that the options are valid.  Should throw an exception if things are not ok.
		/// </summary>
		public override void Validate()
		{
			throw null;
		}
	}
}
