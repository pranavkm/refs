using Microsoft.AspNetCore.Http.Features;

namespace Microsoft.AspNetCore.Http
{
	/// <summary>
	/// Provides methods to create and dispose of <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> instances.
	/// </summary>
	public interface IHttpContextFactory
	{
		/// <summary>
		/// Creates an <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> instance for the specified set of HTTP features.
		/// </summary>
		/// <param name="featureCollection">The collection of HTTP features to set on the created instance.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> instance.</returns>
		HttpContext Create(IFeatureCollection featureCollection);

		/// <summary>
		/// Releases resources held by the <see cref="T:Microsoft.AspNetCore.Http.HttpContext" />.
		/// </summary>
		/// <param name="httpContext">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> to dispose.</param>
		void Dispose(HttpContext httpContext);
	}
}
