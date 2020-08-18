namespace Microsoft.AspNetCore.Server.HttpSys
{
	/// <summary>
	/// Enum declaring the allowed values for the verbosity level when http.sys reject requests due to throttling.
	/// </summary>
	public enum Http503VerbosityLevel : long
	{
		/// <summary>
		/// A 503 response is not sent; the connection is reset. This is the default HTTP Server API behavior.
		/// </summary>
		Basic,
		/// <summary>
		/// The HTTP Server API sends a 503 response with a "Service Unavailable" reason phrase.
		/// </summary>
		Limited,
		/// <summary>
		/// The HTTP Server API sends a 503 response with a detailed reason phrase. 
		/// </summary>
		Full
	}
}
