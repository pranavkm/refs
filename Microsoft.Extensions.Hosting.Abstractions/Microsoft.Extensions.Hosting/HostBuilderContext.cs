using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace Microsoft.Extensions.Hosting
{
	/// <summary>
	/// Context containing the common services on the <see cref="T:Microsoft.Extensions.Hosting.IHost" />. Some properties may be null until set by the <see cref="T:Microsoft.Extensions.Hosting.IHost" />.
	/// </summary>
	public class HostBuilderContext
	{
		/// <summary>
		/// The <see cref="T:Microsoft.Extensions.Configuration.IConfiguration" /> containing the merged configuration of the application and the <see cref="T:Microsoft.Extensions.Hosting.IHost" />.
		/// </summary>
		public IConfiguration Configuration
		{
			get
			{
				throw null;
			}
			set
			{
			}
		}

		/// <summary>
		/// The <see cref="T:Microsoft.Extensions.Hosting.IHostEnvironment" /> initialized by the <see cref="T:Microsoft.Extensions.Hosting.IHost" />.
		/// </summary>
		public IHostEnvironment HostingEnvironment
		{
			get
			{
				throw null;
			}
			set
			{
			}
		}

		/// <summary>
		/// A central location for sharing state between components during the host building process.
		/// </summary>
		public IDictionary<object, object> Properties
		{
			get
			{
				throw null;
			}
		}

		public HostBuilderContext(IDictionary<object, object> properties)
		{
		}
	}
}
