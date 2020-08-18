using Microsoft.AspNetCore.SignalR;

namespace Microsoft.Extensions.DependencyInjection
{
	/// <summary>
	/// Extension methods for <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.
	/// </summary>
	public static class SignalRDependencyInjectionExtensions
	{
		/// <summary>
		/// Adds the minimum essential SignalR services to the specified <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />. Additional services
		/// must be added separately using the <see cref="T:Microsoft.AspNetCore.SignalR.ISignalRServerBuilder" /> returned from this method.
		/// </summary>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> to add services to.</param>
		/// <returns>An <see cref="T:Microsoft.AspNetCore.SignalR.ISignalRServerBuilder" /> that can be used to further configure the SignalR services.</returns>
		public static ISignalRServerBuilder AddSignalRCore(this IServiceCollection services)
		{
			throw null;
		}
	}
}
