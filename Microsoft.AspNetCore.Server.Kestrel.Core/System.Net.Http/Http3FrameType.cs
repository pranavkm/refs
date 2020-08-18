namespace System.Net.Http
{
	internal enum Http3FrameType : long
	{
		Data = 0L,
		Headers = 1L,
		CancelPush = 3L,
		Settings = 4L,
		PushPromise = 5L,
		GoAway = 7L,
		MaxPushId = 13L,
		DuplicatePush = 14L
	}
}
