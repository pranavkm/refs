using Microsoft.AspNetCore.HttpSys.Internal;
using Microsoft.AspNetCore.Server.IIS.Core;
using System;
using System.Runtime.InteropServices;

namespace Microsoft.AspNetCore.Server.IIS
{
	internal static class NativeMethods
	{
		public enum REQUEST_NOTIFICATION_STATUS
		{
			RQ_NOTIFICATION_CONTINUE,
			RQ_NOTIFICATION_PENDING,
			RQ_NOTIFICATION_FINISH_REQUEST
		}

		public delegate REQUEST_NOTIFICATION_STATUS PFN_REQUEST_HANDLER(IntPtr pInProcessHandler, IntPtr pvRequestContext);

		public delegate void PFN_DISCONNECT_HANDLER(IntPtr pvManagedHttpContext);

		public delegate bool PFN_SHUTDOWN_HANDLER(IntPtr pvRequestContext);

		public delegate REQUEST_NOTIFICATION_STATUS PFN_ASYNC_COMPLETION(IntPtr pvManagedHttpContext, int hr, int bytes);

		public delegate REQUEST_NOTIFICATION_STATUS PFN_WEBSOCKET_ASYNC_COMPLETION(IntPtr pInProcessHandler, IntPtr completionInfo, IntPtr pvCompletionContext);

		public delegate void PFN_REQUESTS_DRAINED_HANDLER(IntPtr pvRequestContext);

		internal const int HR_OK = 0;

		internal const int ERROR_NOT_FOUND = -2147023728;

		internal const int ERROR_OPERATION_ABORTED = -2147023901;

		internal const int ERROR_INVALID_PARAMETER = -2147024809;

		internal const int ERROR_HANDLE_EOF = -2147024858;

		internal const string AspNetCoreModuleDll = "aspnetcorev2_inprocess.dll";

		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		public static extern bool CloseHandle(IntPtr handle);

		public static bool IsAspNetCoreModuleLoaded()
		{
			throw null;
		}

		public static void HttpPostCompletion(NativeSafeHandle pInProcessHandler, int cbBytes)
		{
			throw null;
		}

		public static void HttpSetCompletionStatus(NativeSafeHandle pInProcessHandler, REQUEST_NOTIFICATION_STATUS rquestNotificationStatus)
		{
			throw null;
		}

		public static void HttpRegisterCallbacks(NativeSafeHandle pInProcessApplication, PFN_REQUEST_HANDLER requestCallback, PFN_SHUTDOWN_HANDLER shutdownCallback, PFN_DISCONNECT_HANDLER disconnectCallback, PFN_ASYNC_COMPLETION asyncCallback, PFN_REQUESTS_DRAINED_HANDLER requestsDrainedHandler, IntPtr pvRequestContext, IntPtr pvShutdownContext)
		{
			throw null;
		}

		internal unsafe static int HttpWriteResponseBytes(NativeSafeHandle pInProcessHandler, HttpApiTypes.HTTP_DATA_CHUNK* pDataChunks, int nChunks, out bool fCompletionExpected)
		{
			throw null;
		}

		public static int HttpFlushResponseBytes(NativeSafeHandle pInProcessHandler, bool fMoreData, out bool fCompletionExpected)
		{
			throw null;
		}

		internal unsafe static HttpApiTypes.HTTP_REQUEST_V2* HttpGetRawRequest(NativeSafeHandle pInProcessHandler)
		{
			throw null;
		}

		public static void HttpStopCallsIntoManaged(NativeSafeHandle pInProcessApplication)
		{
			throw null;
		}

		public static void HttpStopIncomingRequests(NativeSafeHandle pInProcessApplication)
		{
			throw null;
		}

		public static void HttpDisableBuffering(NativeSafeHandle pInProcessHandler)
		{
			throw null;
		}

		public static void HttpSetResponseStatusCode(NativeSafeHandle pInProcessHandler, ushort statusCode, string pszReason)
		{
			throw null;
		}

		public unsafe static int HttpReadRequestBytes(NativeSafeHandle pInProcessHandler, byte* pvBuffer, int cbBuffer, out int dwBytesReceived, out bool fCompletionExpected)
		{
			throw null;
		}

		public static void HttpGetCompletionInfo(IntPtr pCompletionInfo, out int cbBytes, out int hr)
		{
			throw null;
		}

		public static void HttpSetManagedContext(NativeSafeHandle pInProcessHandler, IntPtr pvManagedContext)
		{
			throw null;
		}

		internal static IISConfigurationData HttpGetApplicationProperties()
		{
			throw null;
		}

		public static bool HttpTryGetServerVariable(NativeSafeHandle pInProcessHandler, string variableName, out string value)
		{
			throw null;
		}

		public static void HttpSetServerVariable(NativeSafeHandle pInProcessHandler, string variableName, string value)
		{
			throw null;
		}

		public unsafe static int HttpWebsocketsReadBytes(NativeSafeHandle pInProcessHandler, byte* pvBuffer, int cbBuffer, PFN_WEBSOCKET_ASYNC_COMPLETION pfnCompletionCallback, IntPtr pvCompletionContext, out int dwBytesReceived, out bool fCompletionExpected)
		{
			throw null;
		}

		internal unsafe static int HttpWebsocketsWriteBytes(NativeSafeHandle pInProcessHandler, HttpApiTypes.HTTP_DATA_CHUNK* pDataChunks, int nChunks, PFN_WEBSOCKET_ASYNC_COMPLETION pfnCompletionCallback, IntPtr pvCompletionContext, out bool fCompletionExpected)
		{
			throw null;
		}

		public static void HttpEnableWebsockets(NativeSafeHandle pInProcessHandler)
		{
			throw null;
		}

		public static bool HttpTryCancelIO(NativeSafeHandle pInProcessHandler)
		{
			throw null;
		}

		public static void HttpCloseConnection(NativeSafeHandle pInProcessHandler)
		{
			throw null;
		}

		public unsafe static void HttpResponseSetUnknownHeader(NativeSafeHandle pInProcessHandler, byte* pszHeaderName, byte* pszHeaderValue, ushort usHeaderValueLength, bool fReplace)
		{
			throw null;
		}

		public unsafe static void HttpResponseSetKnownHeader(NativeSafeHandle pInProcessHandler, int headerId, byte* pHeaderValue, ushort length, bool fReplace)
		{
			throw null;
		}

		public static void HttpGetAuthenticationInformation(NativeSafeHandle pInProcessHandler, out string authType, out IntPtr token)
		{
			throw null;
		}

		internal static void HttpSetStartupErrorPageContent(byte[] content)
		{
			throw null;
		}

		internal unsafe static void HttpResponseSetTrailer(NativeSafeHandle pInProcessHandler, byte* pHeaderName, byte* pHeaderValue, ushort length, bool replace)
		{
			throw null;
		}

		internal static void HttpResetStream(NativeSafeHandle pInProcessHandler, ulong errorCode)
		{
			throw null;
		}

		internal static bool HttpSupportTrailer(NativeSafeHandle pInProcessHandler)
		{
			throw null;
		}
	}
}
