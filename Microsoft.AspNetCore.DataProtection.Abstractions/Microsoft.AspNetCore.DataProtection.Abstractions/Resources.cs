using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.DataProtection.Abstractions
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

		/// <summary>The payload was invalid.</summary>
		internal static string CryptCommon_PayloadInvalid
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The purposes collection cannot be null or empty and cannot contain null elements.</summary>
		internal static string DataProtectionExtensions_NullPurposesCollection
		{
			get
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

		/// <summary>No service for type '{0}' has been registered.</summary>
		internal static string DataProtectionExtensions_NoService
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

		/// <summary>No service for type '{0}' has been registered.</summary>
		internal static string FormatDataProtectionExtensions_NoService(object p0)
		{
			throw null;
		}
	}
}
