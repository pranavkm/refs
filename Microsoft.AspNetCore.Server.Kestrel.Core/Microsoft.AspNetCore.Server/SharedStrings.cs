using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Server
{
	internal static class SharedStrings
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

		/// <summary>The client sent a {frameType} frame with length different than {expectedLength}.</summary>
		internal static string Http2ErrorUnexpectedFrameLength
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The received frame size of {size} exceeds the limit {limit}.</summary>
		internal static string Http2ErrorFrameOverLimit
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

		/// <summary>The client sent a {frameType} frame with length different than {expectedLength}.</summary>
		internal static string FormatHttp2ErrorUnexpectedFrameLength(object frameType, object expectedLength)
		{
			throw null;
		}

		/// <summary>The received frame size of {size} exceeds the limit {limit}.</summary>
		internal static string FormatHttp2ErrorFrameOverLimit(object size, object limit)
		{
			throw null;
		}
	}
}
