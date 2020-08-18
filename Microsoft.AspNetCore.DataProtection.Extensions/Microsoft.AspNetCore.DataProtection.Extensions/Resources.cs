using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.DataProtection.Extensions
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

		/// <summary>An error occurred during a cryptographic operation.</summary>
		internal static string CryptCommon_GenericError
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The payload expired at {0}.</summary>
		internal static string TimeLimitedDataProtector_PayloadExpired
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The payload is invalid.</summary>
		internal static string TimeLimitedDataProtector_PayloadInvalid
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

		/// <summary>The payload expired at {0}.</summary>
		internal static string FormatTimeLimitedDataProtector_PayloadExpired(object p0)
		{
			throw null;
		}
	}
}
