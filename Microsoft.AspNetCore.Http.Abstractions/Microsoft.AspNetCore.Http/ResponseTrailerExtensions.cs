using Microsoft.Extensions.Primitives;

namespace Microsoft.AspNetCore.Http
{
	public static class ResponseTrailerExtensions
	{
		/// <summary>
		/// Adds the given trailer name to the 'Trailer' response header. This must happen before the response headers are sent.
		/// </summary>
		/// <param name="response"></param>
		/// <param name="trailerName"></param>
		public static void DeclareTrailer(this HttpResponse response, string trailerName)
		{
			throw null;
		}

		/// <summary>
		/// Indicates if the server supports sending trailer headers for this response.
		/// </summary>
		/// <param name="response"></param>
		/// <returns></returns>
		public static bool SupportsTrailers(this HttpResponse response)
		{
			throw null;
		}

		/// <summary>
		/// Adds the given trailer header to the trailers collection to be sent at the end of the response body.
		/// Check <see cref="M:Microsoft.AspNetCore.Http.ResponseTrailerExtensions.SupportsTrailers(Microsoft.AspNetCore.Http.HttpResponse)" /> or an InvalidOperationException may be thrown.
		/// </summary>
		/// <param name="response"></param>
		/// <param name="trailerName"></param>
		/// <param name="trailerValues"></param>
		public static void AppendTrailer(this HttpResponse response, string trailerName, StringValues trailerValues)
		{
			throw null;
		}
	}
}
