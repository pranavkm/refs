using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Cors
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

		/// <summary>The CORS protocol does not allow specifying a wildcard (any) origin and credentials at the same time. Configure the CORS policy by listing individual origins if credentials needs to be supported.</summary>
		internal static string InsecureConfiguration
		{
			get
			{
				throw null;
			}
		}

		/// <summary>PreflightMaxAge must be greater than or equal to 0.</summary>
		internal static string PreflightMaxAgeOutOfRange
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
