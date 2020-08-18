using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Primitives;
using Microsoft.Extensions.StackTrace.Sources;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Diagnostics.RazorViews
{
	/// <summary>
	/// Holds data to be displayed on the error page.
	/// </summary>
	internal class ErrorPageModel
	{
		/// <summary>
		/// Options for what output to display.
		/// </summary>
		public DeveloperExceptionPageOptions Options
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
		/// Detailed information about each exception in the stack.
		/// </summary>
		public IEnumerable<ExceptionDetails> ErrorDetails
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
		/// Parsed query data.
		/// </summary>
		public IQueryCollection Query
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
		/// Request cookies.
		/// </summary>
		public IRequestCookieCollection Cookies
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
		/// Request headers.
		/// </summary>
		public IDictionary<string, StringValues> Headers
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
		/// Request route values.
		/// </summary>
		public RouteValueDictionary RouteValues
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
		/// Request endpoint.
		/// </summary>
		public EndpointModel Endpoint
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

		public ErrorPageModel()
		{
			throw null;
		}
	}
}
