using System;
using System.Runtime.InteropServices;

namespace Microsoft.AspNetCore.HttpSys.Internal
{
	internal static class UnsafeNclNativeMethods
	{
		internal static class ErrorCodes
		{
			internal const uint ERROR_SUCCESS = 0u;

			internal const uint ERROR_FILE_NOT_FOUND = 2u;

			internal const uint ERROR_ACCESS_DENIED = 5u;

			internal const uint ERROR_SHARING_VIOLATION = 32u;

			internal const uint ERROR_HANDLE_EOF = 38u;

			internal const uint ERROR_NOT_SUPPORTED = 50u;

			internal const uint ERROR_INVALID_PARAMETER = 87u;

			internal const uint ERROR_INVALID_NAME = 123u;

			internal const uint ERROR_ALREADY_EXISTS = 183u;

			internal const uint ERROR_MORE_DATA = 234u;

			internal const uint ERROR_OPERATION_ABORTED = 995u;

			internal const uint ERROR_IO_PENDING = 997u;

			internal const uint ERROR_NOT_FOUND = 1168u;

			internal const uint ERROR_CONNECTION_INVALID = 1229u;
		}

		[Flags]
		internal enum FileCompletionNotificationModes : byte
		{
			None = 0x0,
			SkipCompletionPortOnSuccess = 0x1,
			SkipSetEventOnHandle = 0x2
		}

		internal static class SafeNetHandles
		{
			[DllImport("sspicli.dll", ExactSpelling = true, SetLastError = true)]
			internal static extern int FreeContextBuffer([In] IntPtr contextBuffer);

			[DllImport("api-ms-win-core-handle-l1-1-0.dll", ExactSpelling = true, SetLastError = true)]
			internal static extern bool CloseHandle(IntPtr handle);

			[DllImport("api-ms-win-core-heap-obsolete-L1-1-0.dll", EntryPoint = "LocalAlloc", SetLastError = true)]
			internal static extern SafeLocalFreeChannelBinding LocalAllocChannelBinding(int uFlags, UIntPtr sizetdwBytes);

			[DllImport("api-ms-win-core-heap-obsolete-L1-1-0.dll", ExactSpelling = true, SetLastError = true)]
			internal static extern IntPtr LocalFree(IntPtr handle);
		}

		internal static class TokenBinding
		{
			internal struct TOKENBINDING_RESULT_DATA
			{
				public uint identifierSize;

				public unsafe TOKENBINDING_IDENTIFIER* identifierData;

				public TOKENBINDING_EXTENSION_FORMAT extensionFormat;

				public uint extensionSize;

				public IntPtr extensionData;
			}

			internal struct TOKENBINDING_IDENTIFIER
			{
				public TOKENBINDING_TYPE bindingType;

				public TOKENBINDING_HASH_ALGORITHM hashAlgorithm;

				public TOKENBINDING_SIGNATURE_ALGORITHM signatureAlgorithm;
			}

			internal enum TOKENBINDING_TYPE : byte
			{
				TOKENBINDING_TYPE_PROVIDED,
				TOKENBINDING_TYPE_REFERRED
			}

			internal enum TOKENBINDING_HASH_ALGORITHM : byte
			{
				TOKENBINDING_HASH_ALGORITHM_SHA256 = 4
			}

			internal enum TOKENBINDING_SIGNATURE_ALGORITHM : byte
			{
				TOKENBINDING_SIGNATURE_ALGORITHM_RSA = 1,
				TOKENBINDING_SIGNATURE_ALGORITHM_ECDSAP256 = 3
			}

			internal enum TOKENBINDING_EXTENSION_FORMAT
			{
				TOKENBINDING_EXTENSION_FORMAT_UNDEFINED
			}

			internal struct TOKENBINDING_RESULT_LIST
			{
				public uint resultCount;

				public unsafe TOKENBINDING_RESULT_DATA* resultData;
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		internal class SECURITY_ATTRIBUTES
		{
			public int nLength;

			public SafeLocalMemHandle lpSecurityDescriptor;

			public bool bInheritHandle;

			public SECURITY_ATTRIBUTES()
			{
				throw null;
			}
		}

		[DllImport("api-ms-win-core-io-l1-1-0.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
		internal static extern uint CancelIoEx(SafeHandle handle, SafeNativeOverlapped overlapped);

		[DllImport("api-ms-win-core-kernel32-legacy-l1-1-0.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
		internal static extern bool SetFileCompletionNotificationModes(SafeHandle handle, FileCompletionNotificationModes modes);

		[DllImport("tokenbinding.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
		public unsafe static extern int TokenBindingVerifyMessage([In] byte* tokenBindingMessage, [In] uint tokenBindingMessageSize, [In] char* keyType, [In] byte* tlsUnique, [In] uint tlsUniqueSize, out HeapAllocHandle resultList);

		[DllImport("api-ms-win-core-heap-L1-2-0.dll", SetLastError = true)]
		internal static extern IntPtr GetProcessHeap();

		[DllImport("api-ms-win-core-heap-L1-2-0.dll", SetLastError = true)]
		internal static extern bool HeapFree([In] IntPtr hHeap, [In] uint dwFlags, [In] IntPtr lpMem);
	}
}
