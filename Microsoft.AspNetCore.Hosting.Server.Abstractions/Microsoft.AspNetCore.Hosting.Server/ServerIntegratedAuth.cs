using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Hosting.Server
{
	/// <summary>
	/// Used by servers to advertise if they support integrated Windows authentication, if it's enabled, and it's scheme.
	/// </summary>
	public class ServerIntegratedAuth : IServerIntegratedAuth
	{
		/// <summary>
		/// Indicates if integrated Windows authentication is enabled for the current application instance.
		/// </summary>
		public bool IsEnabled
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
		/// The name of the authentication scheme for the server authentication handler.
		/// </summary>
		public string? AuthenticationScheme
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

		public ServerIntegratedAuth()
		{
			throw null;
		}
	}
}
