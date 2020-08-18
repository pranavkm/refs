using Microsoft.AspNetCore.Http;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Authentication
{
	/// <summary>
	/// Base context for authentication events which contain <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationProperties" />.
	/// </summary>
	public abstract class PropertiesContext<TOptions> : BaseContext<TOptions> where TOptions : AuthenticationSchemeOptions
	{
		/// <summary>
		/// Gets or sets the <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationProperties" />.
		/// </summary>
		public virtual AuthenticationProperties Properties
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			protected set
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
		/// <param name="properties">The authentication properties.</param>
		protected PropertiesContext(HttpContext context, AuthenticationScheme scheme, TOptions options, AuthenticationProperties? properties)
		{
			throw null;
		}
	}
}
