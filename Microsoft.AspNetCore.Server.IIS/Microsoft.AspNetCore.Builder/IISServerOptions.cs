using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Builder
{
	public class IISServerOptions
	{
		internal long IisMaxRequestSizeLimit;

		/// <summary>
		/// Gets or sets a value that controls whether synchronous IO is allowed for the <see cref="P:Microsoft.AspNetCore.Http.HttpContext.Request" /> and <see cref="P:Microsoft.AspNetCore.Http.HttpContext.Response" />
		/// </summary>
		/// <remarks>
		/// Defaults to false.
		/// </remarks>
		public bool AllowSynchronousIO
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
		/// If true the server should set HttpContext.User. If false the server will only provide an
		/// identity when explicitly requested by the AuthenticationScheme.
		/// Note Windows Authentication must also be enabled in IIS for this to work.
		/// </summary>
		public bool AutomaticAuthentication
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
		/// Sets the display name shown to users on login pages. The default is null.
		/// </summary>
		public string AuthenticationDisplayName
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
		/// Used to indicate if the authentication handler should be registered. This is only done if ANCM indicates
		/// IIS has a non-anonymous authentication enabled, or for back compat with ANCMs that did not provide this information.
		/// </summary>
		internal bool ForwardWindowsAuthentication
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

		internal string[] ServerAddresses
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
		/// Gets or sets the maximum allowed size of any request body in bytes.
		/// When set to null, the maximum request body size is unlimited.
		/// This limit has no effect on upgraded connections which are always unlimited.
		/// This can be overridden per-request via <see cref="T:Microsoft.AspNetCore.Http.Features.IHttpMaxRequestBodySizeFeature" />.
		/// </summary>
		/// <remarks>
		/// Defaults to null (unlimited).
		/// </remarks>
		public long? MaxRequestBodySize
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

		public IISServerOptions()
		{
			throw null;
		}
	}
}
