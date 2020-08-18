using Microsoft.Extensions.Primitives;

namespace Microsoft.AspNetCore.Http
{
	/// <summary>
	/// HttpRequest extensions for working with request trailing headers.
	/// </summary>
	public static class RequestTrailerExtensions
	{
		/// <summary>
		/// Gets the request "Trailer" header that lists which trailers to expect after the body.
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public static StringValues GetDeclaredTrailers(this HttpRequest request)
		{
			throw null;
		}

		/// <summary>
		/// Indicates if the request supports receiving trailer headers.
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public static bool SupportsTrailers(this HttpRequest request)
		{
			throw null;
		}

		/// <summary>
		/// Checks if the request supports trailers and they are available to be read now.
		/// This does not mean that there are any trailers to read.
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public static bool CheckTrailersAvailable(this HttpRequest request)
		{
			throw null;
		}

		/// <summary>
		/// Gets the requested trailing header from the response. Check <see cref="M:Microsoft.AspNetCore.Http.RequestTrailerExtensions.SupportsTrailers(Microsoft.AspNetCore.Http.HttpRequest)" />
		/// or a NotSupportedException may be thrown.
		/// Check <see cref="M:Microsoft.AspNetCore.Http.RequestTrailerExtensions.CheckTrailersAvailable(Microsoft.AspNetCore.Http.HttpRequest)" /> or an InvalidOperationException may be thrown.
		/// </summary>
		/// <param name="request"></param>
		/// <param name="trailerName"></param>
		public static StringValues GetTrailer(this HttpRequest request, string trailerName)
		{
			throw null;
		}
	}
}
