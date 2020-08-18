using Microsoft.AspNetCore.HttpSys.Internal;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.AspNetCore.Server.HttpSys
{
	internal static class HttpApi
	{
		internal unsafe delegate uint HttpSetRequestPropertyInvoker(SafeHandle requestQueueHandle, ulong requestId, HttpApiTypes.HTTP_REQUEST_PROPERTY propertyId, void* input, uint inputSize, IntPtr overlapped);

		internal static HttpApiTypes.HTTPAPI_VERSION Version
		{
			get
			{
				throw null;
			}
		}

		internal static HttpApiTypes.HTTP_API_VERSION ApiVersion
		{
			get
			{
				throw null;
			}
		}

		internal static SafeLibraryHandle HttpApiModule
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		internal static HttpSetRequestPropertyInvoker HttpSetRequestProperty
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		internal static bool SupportsTrailers
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		internal static bool SupportsReset
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		internal static bool Supported
		{
			get
			{
				throw null;
			}
		}

		[DllImport("httpapi.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
		internal unsafe static extern uint HttpInitialize(HttpApiTypes.HTTPAPI_VERSION version, uint flags, void* pReserved);

		[DllImport("httpapi.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
		internal static extern uint HttpReceiveRequestEntityBody(SafeHandle requestQueueHandle, ulong requestId, uint flags, IntPtr pEntityBuffer, uint entityBufferLength, out uint bytesReturned, SafeNativeOverlapped pOverlapped);

		[DllImport("httpapi.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
		internal unsafe static extern uint HttpReceiveClientCertificate(SafeHandle requestQueueHandle, ulong connectionId, uint flags, HttpApiTypes.HTTP_SSL_CLIENT_CERT_INFO* pSslClientCertInfo, uint sslClientCertInfoSize, uint* pBytesReceived, SafeNativeOverlapped pOverlapped);

		[DllImport("httpapi.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
		internal unsafe static extern uint HttpReceiveClientCertificate(SafeHandle requestQueueHandle, ulong connectionId, uint flags, byte* pSslClientCertInfo, uint sslClientCertInfoSize, uint* pBytesReceived, SafeNativeOverlapped pOverlapped);

		[DllImport("httpapi.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
		internal unsafe static extern uint HttpReceiveHttpRequest(SafeHandle requestQueueHandle, ulong requestId, uint flags, HttpApiTypes.HTTP_REQUEST* pRequestBuffer, uint requestBufferLength, uint* pBytesReturned, SafeNativeOverlapped pOverlapped);

		[DllImport("httpapi.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
		internal unsafe static extern uint HttpSendHttpResponse(SafeHandle requestQueueHandle, ulong requestId, uint flags, HttpApiTypes.HTTP_RESPONSE_V2* pHttpResponse, HttpApiTypes.HTTP_CACHE_POLICY* pCachePolicy, uint* pBytesSent, IntPtr pReserved1, uint Reserved2, SafeNativeOverlapped pOverlapped, IntPtr pLogData);

		[DllImport("httpapi.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
		internal unsafe static extern uint HttpSendResponseEntityBody(SafeHandle requestQueueHandle, ulong requestId, uint flags, ushort entityChunkCount, HttpApiTypes.HTTP_DATA_CHUNK* pEntityChunks, uint* pBytesSent, IntPtr pReserved1, uint Reserved2, SafeNativeOverlapped pOverlapped, IntPtr pLogData);

		[DllImport("httpapi.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
		internal static extern uint HttpCancelHttpRequest(SafeHandle requestQueueHandle, ulong requestId, IntPtr pOverlapped);

		[DllImport("httpapi.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
		internal static extern uint HttpWaitForDisconnectEx(SafeHandle requestQueueHandle, ulong connectionId, uint reserved, SafeNativeOverlapped overlapped);

		[DllImport("httpapi.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
		internal unsafe static extern uint HttpCreateServerSession(HttpApiTypes.HTTPAPI_VERSION version, ulong* serverSessionId, uint reserved);

		[DllImport("httpapi.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
		internal unsafe static extern uint HttpCreateUrlGroup(ulong serverSessionId, ulong* urlGroupId, uint reserved);

		[DllImport("httpapi.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
		internal static extern uint HttpAddUrlToUrlGroup(ulong urlGroupId, string pFullyQualifiedUrl, ulong context, uint pReserved);

		[DllImport("httpapi.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
		internal static extern uint HttpSetUrlGroupProperty(ulong urlGroupId, HttpApiTypes.HTTP_SERVER_PROPERTY serverProperty, IntPtr pPropertyInfo, uint propertyInfoLength);

		[DllImport("httpapi.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
		internal static extern uint HttpRemoveUrlFromUrlGroup(ulong urlGroupId, string pFullyQualifiedUrl, uint flags);

		[DllImport("httpapi.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
		internal static extern uint HttpCloseServerSession(ulong serverSessionId);

		[DllImport("httpapi.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
		internal static extern uint HttpCloseUrlGroup(ulong urlGroupId);

		[DllImport("httpapi.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
		internal static extern uint HttpSetRequestQueueProperty(SafeHandle requestQueueHandle, HttpApiTypes.HTTP_SERVER_PROPERTY serverProperty, IntPtr pPropertyInfo, uint propertyInfoLength, uint reserved, IntPtr pReserved);

		[DllImport("httpapi.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
		internal static extern uint HttpCreateRequestQueue(HttpApiTypes.HTTPAPI_VERSION version, string pName, UnsafeNclNativeMethods.SECURITY_ATTRIBUTES pSecurityAttributes, HttpApiTypes.HTTP_CREATE_REQUEST_QUEUE_FLAG flags, out HttpRequestQueueV2Handle pReqQueueHandle);

		[DllImport("httpapi.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
		internal static extern uint HttpCloseRequestQueue(IntPtr pReqQueueHandle);
	}
}
