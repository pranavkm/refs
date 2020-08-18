using Microsoft.AspNetCore.DataProtection;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
	/// <summary>
	/// Extension methods for setting up data protection services in an <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.
	/// </summary>
	public static class DataProtectionServiceCollectionExtensions
	{
		/// <summary>
		/// Adds data protection services to the specified <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.
		/// </summary>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> to add services to.</param>
		public static IDataProtectionBuilder AddDataProtection(this IServiceCollection services)
		{
			throw null;
		}

		/// <summary>
		/// Adds data protection services to the specified <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.
		/// </summary>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> to add services to.</param>
		/// <param name="setupAction">An <see cref="T:System.Action`1" /> to configure the provided <see cref="T:Microsoft.AspNetCore.DataProtection.DataProtectionOptions" />.</param>
		/// <returns>A reference to this instance after the operation has completed.</returns>
		public static IDataProtectionBuilder AddDataProtection(this IServiceCollection services, Action<DataProtectionOptions> setupAction)
		{
			throw null;
		}
	}
}
