using Microsoft.Extensions.WebEncoders;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
	/// <summary>
	/// Extension methods for setting up web encoding services in an <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.
	/// </summary>
	public static class EncoderServiceCollectionExtensions
	{
		/// <summary>
		/// Adds <see cref="T:System.Text.Encodings.Web.HtmlEncoder" />, <see cref="T:System.Text.Encodings.Web.JavaScriptEncoder" /> and <see cref="T:System.Text.Encodings.Web.UrlEncoder" />
		/// to the specified <paramref name="services" />.
		/// </summary>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.</param>
		/// <returns>The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> so that additional calls can be chained.</returns>
		public static IServiceCollection AddWebEncoders(this IServiceCollection services)
		{
			throw null;
		}

		/// <summary>
		/// Adds <see cref="T:System.Text.Encodings.Web.HtmlEncoder" />, <see cref="T:System.Text.Encodings.Web.JavaScriptEncoder" /> and <see cref="T:System.Text.Encodings.Web.UrlEncoder" />
		/// to the specified <paramref name="services" />.
		/// </summary>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.</param>
		/// <param name="setupAction">An <see cref="T:System.Action`1" /> to configure the provided <see cref="T:Microsoft.Extensions.WebEncoders.WebEncoderOptions" />.</param>
		/// <returns>The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> so that additional calls can be chained.</returns>
		public static IServiceCollection AddWebEncoders(this IServiceCollection services, Action<WebEncoderOptions> setupAction)
		{
			throw null;
		}
	}
}
