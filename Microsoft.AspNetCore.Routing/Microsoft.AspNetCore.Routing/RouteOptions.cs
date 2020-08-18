using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Routing
{
	public class RouteOptions
	{
		/// <summary>
		/// Gets a collection of <see cref="T:Microsoft.AspNetCore.Routing.EndpointDataSource" /> instances configured with routing.
		/// </summary>
		internal ICollection<EndpointDataSource> EndpointDataSources
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
		/// Gets or sets a value indicating whether all generated paths URLs are lowercase.
		/// Use <see cref="P:Microsoft.AspNetCore.Routing.RouteOptions.LowercaseQueryStrings" /> to configure the behavior for query strings.
		/// </summary>
		public bool LowercaseUrls
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
		/// Gets or sets a value indicating whether a generated query strings are lowercase.
		/// This property will not be used unless <see cref="P:Microsoft.AspNetCore.Routing.RouteOptions.LowercaseUrls" /> is also <c>true</c>.
		/// </summary>
		public bool LowercaseQueryStrings
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
		/// Gets or sets a value indicating whether a trailing slash should be appended to the generated URLs.
		/// </summary>
		public bool AppendTrailingSlash
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
		/// Gets or sets a value that indicates if the check for unhandled security endpoint metadata is suppressed.
		/// <para>
		/// Endpoints can be associated with metadata such as authorization, or CORS, that needs to be
		/// handled by a specific middleware to be actionable. If the middleware is not configured, such
		/// metadata will go unhandled.
		/// </para>
		/// <para>
		/// When <see langword="false" />, prior to the execution of the endpoint, routing will verify that
		/// all known security-specific metadata has been handled.
		/// Setting this property to <see langword="true" /> suppresses this check.
		/// </para>
		/// </summary>
		/// <value>Defaults to <see langword="false" />.</value>
		/// <remarks>
		/// This check exists as a safeguard against accidental insecure configuration. You may suppress
		/// this check if it does not match your application's requirements.
		/// </remarks>
		public bool SuppressCheckForUnhandledSecurityMetadata
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

		public IDictionary<string, Type> ConstraintMap
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

		public RouteOptions()
		{
			throw null;
		}
	}
}
