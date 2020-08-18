using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.DependencyInjection
{
	internal class HealthChecksBuilder : IHealthChecksBuilder
	{
		public IServiceCollection Services
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public HealthChecksBuilder(IServiceCollection services)
		{
			throw null;
		}

		public IHealthChecksBuilder Add(HealthCheckRegistration registration)
		{
			throw null;
		}
	}
}
