namespace System.Net.Http
{
	/// <summary>
	/// Unidirectional stream types.
	/// </summary>
	/// <remarks>
	/// Bidirectional streams are always a request stream.
	/// </remarks>
	internal enum Http3StreamType : long
	{
		/// <summary>
		/// https://tools.ietf.org/html/draft-ietf-quic-http-24#section-6.2.1
		/// </summary>
		Control,
		/// <summary>
		/// https://tools.ietf.org/html/draft-ietf-quic-http-24#section-6.2.2
		/// </summary>
		Push,
		/// <summary>
		/// https://tools.ietf.org/html/draft-ietf-quic-qpack-11#section-4.2
		/// </summary>
		QPackEncoder,
		/// <summary>
		/// https://tools.ietf.org/html/draft-ietf-quic-qpack-11#section-4.2
		/// </summary>
		QPackDecoder
	}
}
