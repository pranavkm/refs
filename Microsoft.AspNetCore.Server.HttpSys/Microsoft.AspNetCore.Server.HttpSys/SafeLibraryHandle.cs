using Microsoft.Win32.SafeHandles;
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.AspNetCore.Server.HttpSys
{
	/// <summary>
	/// Represents a handle to a Windows module (DLL).
	/// </summary>
	internal sealed class SafeLibraryHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		[SuppressUnmanagedCodeSecurity]
		private static class UnsafeNativeMethods
		{
			[DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal static extern bool FreeLibrary(IntPtr hModule);

			[DllImport("kernel32.dll", SetLastError = true)]
			internal static extern IntPtr GetProcAddress([In] SafeLibraryHandle hModule, [In] [MarshalAs(UnmanagedType.LPStr)] string lpProcName);

			[DllImport("kernel32.dll", EntryPoint = "LoadLibraryExW", SetLastError = true)]
			internal static extern SafeLibraryHandle LoadLibraryEx([In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [In] IntPtr hFile, [In] uint dwFlags);

			internal static void ThrowExceptionForLastWin32Error()
			{
				throw null;
			}
		}

		/// <summary>
		/// Returns a value stating whether the library exports a given proc.
		/// </summary>
		public bool DoesProcExist(string lpProcName)
		{
			throw null;
		}

		/// <summary>
		/// Gets a delegate pointing to a given export from this library.
		/// </summary>
		public TDelegate GetProcAddress<TDelegate>(string lpProcName, bool throwIfNotFound = true) where TDelegate : class
		{
			throw null;
		}

		/// <summary>
		/// Opens a library. If 'filename' is not a fully-qualified path, the default search path is used.
		/// </summary>
		public static SafeLibraryHandle Open(string filename)
		{
			throw null;
		}

		protected override bool ReleaseHandle()
		{
			throw null;
		}
	}
}
