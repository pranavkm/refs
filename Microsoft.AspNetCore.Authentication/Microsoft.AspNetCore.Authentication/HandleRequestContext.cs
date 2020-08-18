using Microsoft.AspNetCore.Http;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Authentication
{
	public class HandleRequestContext<TOptions> : BaseContext<TOptions> where TOptions : AuthenticationSchemeOptions
	{
		/// <summary>
		/// The <see cref="T:Microsoft.AspNetCore.Authentication.HandleRequestResult" /> which is used by the handler.
		/// </summary>
		public HandleRequestResult Result
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

		protected HandleRequestContext(HttpContext context, AuthenticationScheme scheme, TOptions options)
		{
			throw null;
		}

		/// <summary>
		/// Discontinue all processing for this request and return to the client.
		/// The caller is responsible for generating the full response.
		/// </summary>
		public void HandleResponse()
		{
			throw null;
		}

		/// <summary>
		/// Discontinue processing the request in the current handler.
		/// </summary>
		public void SkipHandler()
		{
			throw null;
		}
	}
}
