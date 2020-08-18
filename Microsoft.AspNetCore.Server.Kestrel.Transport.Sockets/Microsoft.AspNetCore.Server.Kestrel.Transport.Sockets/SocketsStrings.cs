using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Server.Kestrel.Transport.Sockets
{
	internal static class SocketsStrings
	{
		internal static ResourceManager ResourceManager
		{
			get
			{
				throw null;
			}
		}

		internal static CultureInfo Culture
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>The Socket transport does not support binding to file handles. Consider using the libuv transport instead.</summary>
		internal static string FileHandleEndPointNotSupported
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Only ListenType.IPEndPoint is supported by the Socket Transport. https://go.microsoft.com/fwlink/?linkid=874850</summary>
		internal static string OnlyIPEndPointsSupported
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Transport is already bound.</summary>
		internal static string TransportAlreadyBound
		{
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static string GetResourceString(string resourceKey, string defaultValue = null)
		{
			throw null;
		}
	}
}
