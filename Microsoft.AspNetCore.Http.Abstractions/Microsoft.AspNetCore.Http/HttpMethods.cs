namespace Microsoft.AspNetCore.Http
{
	/// <summary>
	/// Contains methods to verify the request method of an HTTP request. 
	/// </summary>
	public static class HttpMethods
	{
		public static readonly string Connect;

		public static readonly string Delete;

		public static readonly string Get;

		public static readonly string Head;

		public static readonly string Options;

		public static readonly string Patch;

		public static readonly string Post;

		public static readonly string Put;

		public static readonly string Trace;

		/// <summary>
		/// Returns a value that indicates if the HTTP request method is CONNECT. 
		/// </summary>
		/// <param name="method">The HTTP request method.</param>
		/// <returns>
		/// <see langword="true" /> if the method is CONNECT; otherwise, <see langword="false" />.
		/// </returns>
		public static bool IsConnect(string method)
		{
			throw null;
		}

		/// <summary>
		/// Returns a value that indicates if the HTTP request method is DELETE. 
		/// </summary>
		/// <param name="method">The HTTP request method.</param>
		/// <returns>
		/// <see langword="true" /> if the method is DELETE; otherwise, <see langword="false" />.
		/// </returns>
		public static bool IsDelete(string method)
		{
			throw null;
		}

		/// <summary>
		/// Returns a value that indicates if the HTTP request method is GET. 
		/// </summary>
		/// <param name="method">The  HTTP request method.</param>
		/// <returns>
		/// <see langword="true" /> if the method is GET; otherwise, <see langword="false" />.
		/// </returns>
		public static bool IsGet(string method)
		{
			throw null;
		}

		/// <summary>
		/// Returns a value that indicates if the HTTP request method is HEAD. 
		/// </summary>
		/// <param name="method">The HTTP request method.</param>
		/// <returns>
		/// <see langword="true" /> if the method is HEAD; otherwise, <see langword="false" />.
		/// </returns>
		public static bool IsHead(string method)
		{
			throw null;
		}

		/// <summary>
		/// Returns a value that indicates if the HTTP request method is OPTIONS. 
		/// </summary>
		/// <param name="method">The HTTP request method.</param>
		/// <returns>
		/// <see langword="true" /> if the method is OPTIONS; otherwise, <see langword="false" />.
		/// </returns>
		public static bool IsOptions(string method)
		{
			throw null;
		}

		/// <summary>
		/// Returns a value that indicates if the HTTP request method is PATCH. 
		/// </summary>
		/// <param name="method">The HTTP request method.</param>
		/// <returns>
		/// <see langword="true" /> if the method is PATCH; otherwise, <see langword="false" />.
		/// </returns>
		public static bool IsPatch(string method)
		{
			throw null;
		}

		/// <summary>
		/// Returns a value that indicates if the HTTP request method is POST. 
		/// </summary>
		/// <param name="method">The HTTP request method.</param>
		/// <returns>
		/// <see langword="true" /> if the method is POST; otherwise, <see langword="false" />.
		/// </returns>
		public static bool IsPost(string method)
		{
			throw null;
		}

		/// <summary>
		/// Returns a value that indicates if the HTTP request method is PUT. 
		/// </summary>
		/// <param name="method">The HTTP request method.</param>
		/// <returns>
		/// <see langword="true" /> if the method is PUT; otherwise, <see langword="false" />.
		/// </returns>
		public static bool IsPut(string method)
		{
			throw null;
		}

		/// <summary>
		/// Returns a value that indicates if the HTTP request method is TRACE. 
		/// </summary>
		/// <param name="method">The HTTP request method.</param>
		/// <returns>
		/// <see langword="true" /> if the method is TRACE; otherwise, <see langword="false" />.
		/// </returns>
		public static bool IsTrace(string method)
		{
			throw null;
		}

		/// <summary>
		///  Returns the equivalent static instance, or the original instance if none match. This conversion is optional but allows for performance optimizations when comparing method values elsewhere.
		/// </summary>
		/// <param name="method"></param>
		/// <returns></returns>
		public static string GetCanonicalizedValue(string method)
		{
			throw null;
		}

		/// <summary>
		/// Returns a value that indicates if the HTTP methods are the same. 
		/// </summary>
		/// <param name="methodA">The first HTTP request method to compare.</param>
		/// <param name="methodB">The second HTTP request method to compare.</param>
		/// <returns>
		/// <see langword="true" /> if the methods are the same; otherwise, <see langword="false" />.
		/// </returns>
		public static bool Equals(string methodA, string methodB)
		{
			throw null;
		}
	}
}
