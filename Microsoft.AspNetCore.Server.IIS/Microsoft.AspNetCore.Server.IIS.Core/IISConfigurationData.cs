using System;
using System.Runtime.InteropServices;

namespace Microsoft.AspNetCore.Server.IIS.Core
{
	internal struct IISConfigurationData
	{
		public IntPtr pNativeApplication;

		[MarshalAs(UnmanagedType.BStr)]
		public string pwzFullApplicationPath;

		[MarshalAs(UnmanagedType.BStr)]
		public string pwzVirtualApplicationPath;

		public bool fWindowsAuthEnabled;

		public bool fBasicAuthEnabled;

		public bool fAnonymousAuthEnable;

		[MarshalAs(UnmanagedType.BStr)]
		public string pwzBindings;

		public int maxRequestBodySize;
	}
}
