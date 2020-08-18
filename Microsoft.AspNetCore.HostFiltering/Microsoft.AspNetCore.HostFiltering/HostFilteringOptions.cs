using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.HostFiltering
{
	/// <summary>
	/// Options for the HostFiltering middleware
	/// </summary>
	public class HostFilteringOptions
	{
		/// <summary>
		/// The hosts headers that are allowed to access this site. At least one value is required.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><description>Port numbers must be excluded.</description></item>
		/// <item><description>A top level wildcard "*" allows all non-empty hosts.</description></item>
		/// <item><description>Subdomain wildcards are permitted. E.g. "*.example.com" matches subdomains like foo.example.com,
		///    but not the parent domain example.com.</description></item>
		/// <item><description>Unicode host names are allowed but will be converted to punycode for matching.</description></item>
		/// <item><description>IPv6 addresses must include their bounding brackets and be in their normalized form.</description></item>
		/// </list>
		/// </remarks>
		public IList<string> AllowedHosts
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
		/// Indicates if requests without hosts are allowed. The default is true.
		/// </summary>
		/// <remarks>
		/// HTTP/1.0 does not require a host header.
		/// Http/1.1 requires a host header, but says the value may be empty.
		/// </remarks>
		public bool AllowEmptyHosts
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
		/// Indicates if the 400 response should include a default message or be empty. This is enabled by default.
		/// </summary>
		public bool IncludeFailureMessage
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

		public HostFilteringOptions()
		{
			throw null;
		}
	}
}
