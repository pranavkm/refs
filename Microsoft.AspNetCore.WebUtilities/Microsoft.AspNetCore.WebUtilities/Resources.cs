using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.WebUtilities
{
	internal static class Resources
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

		/// <summary>The stream must support reading.</summary>
		internal static string HttpRequestStreamReader_StreamNotReadable
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The stream must support writing.</summary>
		internal static string HttpResponseStreamWriter_StreamNotWritable
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Invalid {0}, {1} or {2} length.</summary>
		internal static string WebEncoders_InvalidCountOffsetOrLength
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

		/// <summary>Invalid {0}, {1} or {2} length.</summary>
		internal static string FormatWebEncoders_InvalidCountOffsetOrLength(object p0, object p1, object p2)
		{
			throw null;
		}
	}
}
