using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Cryptography.Internal
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

		/// <summary>A provider could not be found for algorithm '{0}'.</summary>
		internal static string BCryptAlgorithmHandle_ProviderNotFound
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The key length {0} is invalid. Valid key lengths are {1} to {2} bits (step size {3}).</summary>
		internal static string BCRYPT_KEY_LENGTHS_STRUCT_InvalidKeyLength
		{
			get
			{
				throw null;
			}
		}

		/// <summary>This operation requires Windows 7 / Windows Server 2008 R2 or later.</summary>
		internal static string Platform_Windows7Required
		{
			get
			{
				throw null;
			}
		}

		/// <summary>This operation requires Windows 8 / Windows Server 2012 or later.</summary>
		internal static string Platform_Windows8Required
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

		/// <summary>A provider could not be found for algorithm '{0}'.</summary>
		internal static string FormatBCryptAlgorithmHandle_ProviderNotFound(object p0)
		{
			throw null;
		}

		/// <summary>The key length {0} is invalid. Valid key lengths are {1} to {2} bits (step size {3}).</summary>
		internal static string FormatBCRYPT_KEY_LENGTHS_STRUCT_InvalidKeyLength(object p0, object p1, object p2, object p3)
		{
			throw null;
		}
	}
}
