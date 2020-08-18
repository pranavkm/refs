using System;
using System.Runtime.InteropServices;

namespace Microsoft.AspNetCore.Server.IISIntegration
{
	internal static class NativeMethods
	{
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		public static extern bool CloseHandle(IntPtr handle);
	}
}
