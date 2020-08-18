using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Builder
{
	public class IISOptions
	{
		/// <summary>
		/// If true the middleware should set HttpContext.User. If false the middleware will only provide an
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

		/// <summary>
		/// Populates the ITLSConnectionFeature if the MS-ASPNETCORE-CLIENTCERT request header is present.
		/// </summary>
		public bool ForwardClientCertificate
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

		public IISOptions()
		{
			throw null;
		}
	}
}
