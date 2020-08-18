namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http3
{
	internal enum Http3SettingType : long
	{
		QPackMaxTableCapacity = 1L,
		/// <summary>
		/// SETTINGS_MAX_HEADER_LIST_SIZE, default is unlimited.
		/// </summary>
		MaxHeaderListSize = 6L,
		QPackBlockedStreams = 7L
	}
}
