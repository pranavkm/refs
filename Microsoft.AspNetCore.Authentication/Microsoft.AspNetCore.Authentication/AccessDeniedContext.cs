using Microsoft.AspNetCore.Http;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Authentication
{
	/// <summary>
	/// Provides access denied failure context information to handler providers.
	/// </summary>
	public class AccessDeniedContext : HandleRequestContext<RemoteAuthenticationOptions>
	{
		/// <summary>
		/// Gets or sets the endpoint path the user agent will be redirected to.
		/// By default, this property is set to <see cref="P:Microsoft.AspNetCore.Authentication.RemoteAuthenticationOptions.AccessDeniedPath" />.
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
		/// Additional state values for the authentication session.
		/// </summary>
		public AuthenticationProperties? Properties
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
		/// Gets or sets the return URL that will be flowed up to the access denied page.
		/// If <see cref="P:Microsoft.AspNetCore.Authentication.AccessDeniedContext.ReturnUrlParameter" /> is not set, this property is not used.
		/// </summary>
		public string? ReturnUrl
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
		/// Gets or sets the parameter name that will be used to flow the return URL.
		/// By default, this property is set to <see cref="P:Microsoft.AspNetCore.Authentication.RemoteAuthenticationOptions.ReturnUrlParameter" />.
		/// </summary>
		public string ReturnUrlParameter
		{
			[System.Runtime.CompilerServices.NullableContext(1)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[System.Runtime.CompilerServices.NullableContext(1)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		[System.Runtime.CompilerServices.NullableContext(1)]
		public AccessDeniedContext(HttpContext context, AuthenticationScheme scheme, RemoteAuthenticationOptions options)
		{
			throw null;
		}
	}
}
