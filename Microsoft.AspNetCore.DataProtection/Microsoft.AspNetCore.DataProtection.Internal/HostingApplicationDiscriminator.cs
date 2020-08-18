using Microsoft.AspNetCore.DataProtection.Infrastructure;
using Microsoft.Extensions.Hosting;

namespace Microsoft.AspNetCore.DataProtection.Internal
{
	internal class HostingApplicationDiscriminator : IApplicationDiscriminator
	{
		public string Discriminator
		{
			get
			{
				throw null;
			}
		}

		public HostingApplicationDiscriminator()
		{
			throw null;
		}

		public HostingApplicationDiscriminator(IHostEnvironment hosting)
		{
			throw null;
		}
	}
}
