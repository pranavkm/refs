using Microsoft.AspNetCore.Http;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Authentication
{
	/// <summary>
	/// Base class used by other context classes.
	/// </summary>
	public abstract class BaseContext<TOptions> where TOptions : AuthenticationSchemeOptions
	{
		/// <summary>
		/// The authentication scheme.
		/// </summary>
		public AuthenticationScheme Scheme
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the authentication options associated with the scheme.
		/// </summary>
		public TOptions Options
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// The context.
		/// </summary>
		public HttpContext HttpContext
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// The request.
		/// </summary>
		public HttpRequest Request
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// The response.
		/// </summary>
		public HttpResponse Response
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="scheme">The authentication scheme.</param>
		/// <param name="options">The authentication options associated with the scheme.</param>
		protected BaseContext(HttpContext context, AuthenticationScheme scheme, TOptions options)
		{
			throw null;
		}
	}
}
