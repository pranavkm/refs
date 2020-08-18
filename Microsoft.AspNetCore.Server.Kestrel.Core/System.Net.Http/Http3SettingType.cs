namespace System.Net.Http
{
	internal enum Http3SettingType : long
	{
		/// <summary>
		/// SETTINGS_QPACK_MAX_TABLE_CAPACITY
		/// The maximum dynamic table size. The default is 0.
		/// https://tools.ietf.org/html/draft-ietf-quic-qpack-11#section-5
		/// </summary>
		QPackMaxTableCapacity = 1L,
		/// <summary>
		/// SETTINGS_MAX_HEADER_LIST_SIZE
		/// The maximum size of headers. The default is unlimited.
		/// https://tools.ietf.org/html/draft-ietf-quic-http-24#section-7.2.4.1
		/// </summary>
		MaxHeaderListSize = 6L,
		/// <summary>
		/// SETTINGS_QPACK_BLOCKED_STREAMS
		/// The maximum number of request streams that can be blocked waiting for QPack instructions. The default is 0.
		/// https://tools.ietf.org/html/draft-ietf-quic-qpack-11#section-5
		/// </summary>
		QPackBlockedStreams = 7L
	}
}
