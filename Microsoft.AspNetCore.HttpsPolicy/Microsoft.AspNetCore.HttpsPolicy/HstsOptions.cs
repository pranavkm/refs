using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.HttpsPolicy
{
	/// <summary>
	/// Options for the Hsts Middleware
	/// </summary>
	public class HstsOptions
	{
		/// <summary>
		/// Sets the max-age parameter of the Strict-Transport-Security header.
		/// </summary>
		/// <remarks>
		/// Max-age is required; defaults to 30 days.
		/// See: https://tools.ietf.org/html/rfc6797#section-6.1.1
		/// </remarks>
		public TimeSpan MaxAge
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
		/// Enables includeSubDomain parameter of the Strict-Transport-Security header.
		/// </summary>
		/// <remarks>
		/// See: https://tools.ietf.org/html/rfc6797#section-6.1.2
		/// </remarks>
		public bool IncludeSubDomains
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
		/// Sets the preload parameter of the Strict-Transport-Security header.
		/// </summary>
		/// <remarks>
		/// Preload is not part of the RFC specification, but is supported by web browsers
		/// to preload HSTS sites on fresh install. See https://hstspreload.org/.
		/// </remarks>
		public bool Preload
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
		/// A list of host names that will not add the HSTS header.
		/// </summary>
		public IList<string> ExcludedHosts
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public HstsOptions()
		{
			throw null;
		}
	}
}
