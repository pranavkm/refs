using Microsoft.Extensions.Logging;

namespace Microsoft.AspNetCore.Server.HttpSys
{
	internal static class LoggerEventIds
	{
		public static EventId HttpSysListenerCtorError;

		public static EventId BindingToDefault;

		public static EventId ClearedPrefixes;

		public static EventId AcceptErrorStopping;

		public static EventId AcceptError;

		public static EventId RequestProcessError;

		public static EventId RequestsDrained;

		public static EventId StopCancelled;

		public static EventId WaitingForRequestsToDrain;

		public static EventId DisconnectRegistrationError;

		public static EventId RegisterDisconnectListener;

		public static EventId UnknownDisconnectError;

		public static EventId DisconnectHandlerError;

		public static EventId ListenerStarting;

		public static EventId ListenerDisposeError;

		public static EventId RequestListenerProcessError;

		public static EventId AttachedToQueue;

		public static EventId SetUrlPropertyError;

		public static EventId RegisteringPrefix;

		public static EventId UnregisteringPrefix;

		public static EventId CloseUrlGroupError;

		public static EventId ChannelBindingUnSupported;

		public static EventId ChannelBindingMissing;

		public static EventId RequestError;

		public static EventId ErrorInReadingCertificate;

		public static EventId ChannelBindingNeedsHttps;

		public static EventId ChannelBindingRetrived;

		public static EventId AbortError;

		public static EventId ErrorWhileRead;

		public static EventId ErrorWhenReadBegun;

		public static EventId ErrorWhenReadAsync;

		public static EventId ErrorWhenFlushAsync;

		public static EventId FewerBytesThanExpected;

		public static EventId WriteError;

		public static EventId WriteErrorIgnored;

		public static EventId WriteFlushCancelled;

		public static EventId ClearedAddresses;

		public static EventId FileSendAsyncError;

		public static EventId FileSendAsyncCancelled;

		public static EventId FileSendAsyncErrorIgnored;

		public static EventId WriteCancelled;

		public static EventId ListenerStopping;

		public static EventId ListenerStartError;

		public static EventId DisconnectTriggered;

		public static EventId ListenerStopError;

		public static EventId ListenerDisposing;
	}
}
