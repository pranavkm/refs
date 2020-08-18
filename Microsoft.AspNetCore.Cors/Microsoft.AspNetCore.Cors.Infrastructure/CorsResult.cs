using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Cors.Infrastructure
{
	/// <summary>
	/// Results returned by <see cref="T:Microsoft.AspNetCore.Cors.Infrastructure.ICorsService" />.
	/// </summary>
	public class CorsResult
	{
		/// <summary>
		/// Gets or sets a value that determines if the current request is a CORS-preflight request.
		/// </summary>
		public bool IsPreflightRequest
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
		/// Gets or sets the allowed origin.
		/// </summary>
		public string AllowedOrigin
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
		/// Gets or sets a value that determines if the origin is allowed.
		/// When <c>false</c>, no CORS headers should be sent.
		/// </summary>
		public bool IsOriginAllowed
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
		/// Gets or sets a value indicating whether the resource supports user credentials.
		/// </summary>
		public bool SupportsCredentials
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
		/// Gets the allowed methods.
		/// </summary>
		public IList<string> AllowedMethods
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the allowed headers.
		/// </summary>
		public IList<string> AllowedHeaders
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the allowed headers that can be exposed on the response.
		/// </summary>
		public IList<string> AllowedExposedHeaders
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets a value indicating if a 'Vary' header with the value 'Origin' is required.
		/// </summary>
		public bool VaryByOrigin
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
		/// Gets or sets the <see cref="T:System.TimeSpan" /> for which the results of a preflight request can be cached.
		/// </summary>
		public TimeSpan? PreflightMaxAge
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
		/// Returns a <see cref="T:System.String" /> that represents this instance.
		/// </summary>
		/// <returns>
		/// A <see cref="T:System.String" /> that represents this instance.
		/// </returns>
		public override string ToString()
		{
			throw null;
		}

		public CorsResult()
		{
			throw null;
		}
	}
}
