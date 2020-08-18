namespace Microsoft.AspNetCore.Cors.Infrastructure
{
	/// <summary>
	/// CORS-related constants.
	/// </summary>
	public static class CorsConstants
	{
		/// <summary>
		/// The HTTP method for the CORS preflight request.
		/// </summary>
		public static readonly string PreflightHttpMethod;

		/// <summary>
		/// The Origin request header.
		/// </summary>
		public static readonly string Origin;

		/// <summary>
		/// The value for the Access-Control-Allow-Origin response header to allow all origins.
		/// </summary>
		public static readonly string AnyOrigin;

		/// <summary>
		/// The Access-Control-Request-Method request header.
		/// </summary>
		public static readonly string AccessControlRequestMethod;

		/// <summary>
		/// The Access-Control-Request-Headers request header.
		/// </summary>
		public static readonly string AccessControlRequestHeaders;

		/// <summary>
		/// The Access-Control-Allow-Origin response header.
		/// </summary>
		public static readonly string AccessControlAllowOrigin;

		/// <summary>
		/// The Access-Control-Allow-Headers response header.
		/// </summary>
		public static readonly string AccessControlAllowHeaders;

		/// <summary>
		/// The Access-Control-Expose-Headers response header.
		/// </summary>
		public static readonly string AccessControlExposeHeaders;

		/// <summary>
		/// The Access-Control-Allow-Methods response header.
		/// </summary>
		public static readonly string AccessControlAllowMethods;

		/// <summary>
		/// The Access-Control-Allow-Credentials response header.
		/// </summary>
		public static readonly string AccessControlAllowCredentials;

		/// <summary>
		/// The Access-Control-Max-Age response header.
		/// </summary>
		public static readonly string AccessControlMaxAge;
	}
}
