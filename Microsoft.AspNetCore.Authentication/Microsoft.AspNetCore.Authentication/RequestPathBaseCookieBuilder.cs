using Microsoft.AspNetCore.Http;
using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Authentication
{
	/// <summary>
	/// A cookie builder that sets <see cref="P:Microsoft.AspNetCore.Http.CookieOptions.Path" /> to the request path base.
	/// </summary>
	public class RequestPathBaseCookieBuilder : CookieBuilder
	{
		/// <summary>
		/// Gets an optional value that is appended to the request path base.
		/// </summary>
		protected virtual string? AdditionalPath
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public override CookieOptions Build(HttpContext context, DateTimeOffset expiresFrom)
		{
			throw null;
		}

		public RequestPathBaseCookieBuilder()
		{
			throw null;
		}
	}
}
