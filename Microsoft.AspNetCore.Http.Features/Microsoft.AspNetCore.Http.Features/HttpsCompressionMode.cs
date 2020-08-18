namespace Microsoft.AspNetCore.Http.Features
{
	/// <summary>
	/// Use to dynamically control response compression for HTTPS requests.
	/// </summary>
	public enum HttpsCompressionMode
	{
		/// <summary>
		/// No value has been specified, use the configured defaults.
		/// </summary>
		Default,
		/// <summary>
		/// Opts out of compression over HTTPS. Enabling compression on HTTPS requests for remotely manipulable content
		/// may expose security problems.
		/// </summary>
		DoNotCompress,
		/// <summary>
		/// Opts into compression over HTTPS. Enabling compression on HTTPS requests for remotely manipulable content
		/// may expose security problems.
		/// </summary>
		Compress
	}
}
