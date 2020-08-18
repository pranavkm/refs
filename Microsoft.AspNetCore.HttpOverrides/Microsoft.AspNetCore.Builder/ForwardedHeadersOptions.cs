using Microsoft.AspNetCore.HttpOverrides;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Builder
{
	public class ForwardedHeadersOptions
	{
		/// <summary>
		/// Use this header instead of <see cref="P:Microsoft.AspNetCore.HttpOverrides.ForwardedHeadersDefaults.XForwardedForHeaderName" />
		/// </summary>
		/// <seealso cref="T:Microsoft.AspNetCore.HttpOverrides.ForwardedHeadersDefaults" />
		public string ForwardedForHeaderName
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
		/// Use this header instead of <see cref="P:Microsoft.AspNetCore.HttpOverrides.ForwardedHeadersDefaults.XForwardedHostHeaderName" />
		/// </summary>
		/// <seealso cref="T:Microsoft.AspNetCore.HttpOverrides.ForwardedHeadersDefaults" />
		public string ForwardedHostHeaderName
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
		/// Use this header instead of <see cref="P:Microsoft.AspNetCore.HttpOverrides.ForwardedHeadersDefaults.XForwardedProtoHeaderName" />
		/// </summary>
		/// <seealso cref="T:Microsoft.AspNetCore.HttpOverrides.ForwardedHeadersDefaults" />
		public string ForwardedProtoHeaderName
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
		/// Use this header instead of <see cref="P:Microsoft.AspNetCore.HttpOverrides.ForwardedHeadersDefaults.XOriginalForHeaderName" />
		/// </summary>
		/// <seealso cref="T:Microsoft.AspNetCore.HttpOverrides.ForwardedHeadersDefaults" />
		public string OriginalForHeaderName
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
		/// Use this header instead of <see cref="P:Microsoft.AspNetCore.HttpOverrides.ForwardedHeadersDefaults.XOriginalHostHeaderName" />
		/// </summary>
		/// <seealso cref="T:Microsoft.AspNetCore.HttpOverrides.ForwardedHeadersDefaults" />
		public string OriginalHostHeaderName
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
		/// Use this header instead of <see cref="P:Microsoft.AspNetCore.HttpOverrides.ForwardedHeadersDefaults.XOriginalProtoHeaderName" />
		/// </summary>
		/// <seealso cref="T:Microsoft.AspNetCore.HttpOverrides.ForwardedHeadersDefaults" />
		public string OriginalProtoHeaderName
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
		/// Identifies which forwarders should be processed.
		/// </summary>
		public ForwardedHeaders ForwardedHeaders
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
		/// Limits the number of entries in the headers that will be processed. The default value is 1.
		/// Set to null to disable the limit, but this should only be done if
		/// KnownProxies or KnownNetworks are configured.
		/// </summary>
		public int? ForwardLimit
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
		/// Addresses of known proxies to accept forwarded headers from.
		/// </summary>
		public IList<IPAddress> KnownProxies
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Address ranges of known proxies to accept forwarded headers from.
		/// </summary>
		public IList<IPNetwork> KnownNetworks
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// The allowed values from x-forwarded-host. If the list is empty then all hosts are allowed.
		/// Failing to restrict this these values may allow an attacker to spoof links generated by your service. 
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
		/// Require the number of header values to be in sync between the different headers being processed.
		/// The default is 'false'.
		/// </summary>
		public bool RequireHeaderSymmetry
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

		public ForwardedHeadersOptions()
		{
			throw null;
		}
	}
}
