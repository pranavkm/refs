using Microsoft.AspNetCore.DataProtection;
using Microsoft.Extensions.Options;

namespace Microsoft.AspNetCore.Antiforgery
{
	internal class AntiforgeryOptionsSetup : IConfigureOptions<AntiforgeryOptions>
	{
		public AntiforgeryOptionsSetup(IOptions<DataProtectionOptions> dataProtectionOptions)
		{
			throw null;
		}

		public void Configure(AntiforgeryOptions options)
		{
			throw null;
		}
	}
}
