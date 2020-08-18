namespace Microsoft.AspNetCore.Http
{
	/// <summary>
	/// Extension methods for enabling buffering in an <see cref="T:Microsoft.AspNetCore.Http.HttpRequest" />.
	/// </summary>
	public static class HttpRequestRewindExtensions
	{
		/// <summary>
		/// Ensure the <paramref name="request" /> <see cref="P:Microsoft.AspNetCore.Http.HttpRequest.Body" /> can be read multiple times. Normally
		/// buffers request bodies in memory; writes requests larger than 30K bytes to disk.
		/// </summary>
		/// <param name="request">The <see cref="T:Microsoft.AspNetCore.Http.HttpRequest" /> to prepare.</param>
		/// <remarks>
		/// Temporary files for larger requests are written to the location named in the <c>ASPNETCORE_TEMP</c>
		/// environment variable, if any. If that environment variable is not defined, these files are written to the
		/// current user's temporary folder. Files are automatically deleted at the end of their associated requests.
		/// </remarks>
		public static void EnableBuffering(this HttpRequest request)
		{
			throw null;
		}

		/// <summary>
		/// Ensure the <paramref name="request" /> <see cref="P:Microsoft.AspNetCore.Http.HttpRequest.Body" /> can be read multiple times. Normally
		/// buffers request bodies in memory; writes requests larger than <paramref name="bufferThreshold" /> bytes to
		/// disk.
		/// </summary>
		/// <param name="request">The <see cref="T:Microsoft.AspNetCore.Http.HttpRequest" /> to prepare.</param>
		/// <param name="bufferThreshold">
		/// The maximum size in bytes of the in-memory <see cref="T:System.Buffers.ArrayPool`1" /> used to buffer the
		/// stream. Larger request bodies are written to disk.
		/// </param>
		/// <remarks>
		/// Temporary files for larger requests are written to the location named in the <c>ASPNETCORE_TEMP</c>
		/// environment variable, if any. If that environment variable is not defined, these files are written to the
		/// current user's temporary folder. Files are automatically deleted at the end of their associated requests.
		/// </remarks>
		public static void EnableBuffering(this HttpRequest request, int bufferThreshold)
		{
			throw null;
		}

		/// <summary>
		/// Ensure the <paramref name="request" /> <see cref="P:Microsoft.AspNetCore.Http.HttpRequest.Body" /> can be read multiple times. Normally
		/// buffers request bodies in memory; writes requests larger than 30K bytes to disk.
		/// </summary>
		/// <param name="request">The <see cref="T:Microsoft.AspNetCore.Http.HttpRequest" /> to prepare.</param>
		/// <param name="bufferLimit">
		/// The maximum size in bytes of the request body. An attempt to read beyond this limit will cause an
		/// <see cref="T:System.IO.IOException" />.
		/// </param>
		/// <remarks>
		/// Temporary files for larger requests are written to the location named in the <c>ASPNETCORE_TEMP</c>
		/// environment variable, if any. If that environment variable is not defined, these files are written to the
		/// current user's temporary folder. Files are automatically deleted at the end of their associated requests.
		/// </remarks>
		public static void EnableBuffering(this HttpRequest request, long bufferLimit)
		{
			throw null;
		}

		/// <summary>
		/// Ensure the <paramref name="request" /> <see cref="P:Microsoft.AspNetCore.Http.HttpRequest.Body" /> can be read multiple times. Normally
		/// buffers request bodies in memory; writes requests larger than <paramref name="bufferThreshold" /> bytes to
		/// disk.
		/// </summary>
		/// <param name="request">The <see cref="T:Microsoft.AspNetCore.Http.HttpRequest" /> to prepare.</param>
		/// <param name="bufferThreshold">
		/// The maximum size in bytes of the in-memory <see cref="T:System.Buffers.ArrayPool`1" /> used to buffer the
		/// stream. Larger request bodies are written to disk.
		/// </param>
		/// <param name="bufferLimit">
		/// The maximum size in bytes of the request body. An attempt to read beyond this limit will cause an
		/// <see cref="T:System.IO.IOException" />.
		/// </param>
		/// <remarks>
		/// Temporary files for larger requests are written to the location named in the <c>ASPNETCORE_TEMP</c>
		/// environment variable, if any. If that environment variable is not defined, these files are written to the
		/// current user's temporary folder. Files are automatically deleted at the end of their associated requests.
		/// </remarks>
		public static void EnableBuffering(this HttpRequest request, int bufferThreshold, long bufferLimit)
		{
			throw null;
		}
	}
}
