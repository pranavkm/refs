using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Cors.Infrastructure
{
	/// <summary>
	/// Defines the policy for Cross-Origin requests based on the CORS specifications.
	/// </summary>
	public class CorsPolicy
	{
		/// <summary>
		/// Gets a value indicating if all headers are allowed.
		/// </summary>
		public bool AllowAnyHeader
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets a value indicating if all methods are allowed.
		/// </summary>
		public bool AllowAnyMethod
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets a value indicating if all origins are allowed.
		/// </summary>
		public bool AllowAnyOrigin
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets a function which evaluates whether an origin is allowed.
		/// </summary>
		public Func<string, bool> IsOriginAllowed
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
		/// Gets the headers that the resource might use and can be exposed.
		/// </summary>
		public IList<string> ExposedHeaders
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the headers that are supported by the resource.
		/// </summary>
		public IList<string> Headers
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the methods that are supported by the resource.
		/// </summary>
		public IList<string> Methods
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the origins that are allowed to access the resource.
		/// </summary>
		public IList<string> Origins
		{
			[CompilerGenerated]
			get
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
		/// Gets or sets a value indicating whether the resource supports user credentials in the request.
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
		/// Default constructor for a CorsPolicy.
		/// </summary>
		public CorsPolicy()
		{
			throw null;
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
	}
}
