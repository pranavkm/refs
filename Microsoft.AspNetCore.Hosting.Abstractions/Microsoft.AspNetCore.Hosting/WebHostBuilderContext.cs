using Microsoft.Extensions.Configuration;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Hosting
{
	/// <summary>
	/// Context containing the common services on the <see cref="T:Microsoft.AspNetCore.Hosting.IWebHost" />. Some properties may be null until set by the <see cref="T:Microsoft.AspNetCore.Hosting.IWebHost" />.
	/// </summary>
	public class WebHostBuilderContext
	{
		/// <summary>
		/// The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostEnvironment" /> initialized by the <see cref="T:Microsoft.AspNetCore.Hosting.IWebHost" />.
		/// </summary>
		public IWebHostEnvironment HostingEnvironment
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
		/// The <see cref="T:Microsoft.Extensions.Configuration.IConfiguration" /> containing the merged configuration of the application and the <see cref="T:Microsoft.AspNetCore.Hosting.IWebHost" />.
		/// </summary>
		public IConfiguration Configuration
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

		public WebHostBuilderContext()
		{
			throw null;
		}
	}
}
