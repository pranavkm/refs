using Microsoft.AspNetCore.Http;
using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Diagnostics
{
	/// <summary>
	/// Provides context about the error currently being handled by the DeveloperExceptionPageMiddleware.
	/// </summary>
	public class ErrorContext
	{
		/// <summary>
		/// The <see cref="P:Microsoft.AspNetCore.Diagnostics.ErrorContext.HttpContext" />.
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
		/// The <see cref="P:Microsoft.AspNetCore.Diagnostics.ErrorContext.Exception" /> thrown during request processing.
		/// </summary>
		public Exception Exception
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Initializes the ErrorContext with the specified <see cref="P:Microsoft.AspNetCore.Diagnostics.ErrorContext.HttpContext" /> and <see cref="P:Microsoft.AspNetCore.Diagnostics.ErrorContext.Exception" />.
		/// </summary>
		/// <param name="httpContext"></param>
		/// <param name="exception"></param>
		public ErrorContext(HttpContext httpContext, Exception exception)
		{
			throw null;
		}
	}
}
