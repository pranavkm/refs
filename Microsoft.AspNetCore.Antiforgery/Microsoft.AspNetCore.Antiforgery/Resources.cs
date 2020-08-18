using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Antiforgery
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

		/// <summary>The provided identity of type '{0}' is marked {1} = {2} but does not have a value for {3}. By default, the antiforgery system requires that all authenticated identities have a unique {3}. If it is not possible to provide a unique {3} for this identity, con ...</summary>
		internal static string AntiforgeryTokenValidator_AuthenticatedUserWithoutUsername
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The provided antiforgery token failed a custom data check.</summary>
		internal static string AntiforgeryToken_AdditionalDataCheckFailed
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The provided antiforgery token was meant for a different claims-based user than the current user.</summary>
		internal static string AntiforgeryToken_ClaimUidMismatch
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The antiforgery token could not be decrypted.</summary>
		internal static string AntiforgeryToken_DeserializationFailed
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The antiforgery cookie token and request token do not match.</summary>
		internal static string AntiforgeryToken_SecurityTokenMismatch
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Validation of the provided antiforgery token failed. The cookie token and the request token were swapped.</summary>
		internal static string AntiforgeryToken_TokensSwapped
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The provided antiforgery token was meant for user "{0}", but the current user is "{1}".</summary>
		internal static string AntiforgeryToken_UsernameMismatch
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The antiforgery cookie token is invalid.</summary>
		internal static string Antiforgery_CookieToken_IsInvalid
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The required antiforgery cookie "{0}" is not present.</summary>
		internal static string Antiforgery_CookieToken_MustBeProvided
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The required antiforgery cookie token must be provided.</summary>
		internal static string Antiforgery_CookieToken_MustBeProvided_Generic
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The required antiforgery form field "{0}" is not present.</summary>
		internal static string Antiforgery_FormToken_MustBeProvided
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The required antiforgery header value "{0}" is not present.</summary>
		internal static string Antiforgery_HeaderToken_MustBeProvided
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The required antiforgery request token was not provided in either form field "{0}" or header value "{1}".</summary>
		internal static string Antiforgery_RequestToken_MustBeProvided
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The required antiforgery request token must be provided.</summary>
		internal static string Antiforgery_RequestToken_MustBeProvided_Generic
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The antiforgery system has the configuration value {optionName} = {value}, but the current request is not an SSL request.</summary>
		internal static string Antiforgery_RequiresSSL
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Value cannot be null or empty.</summary>
		internal static string ArgumentCannotBeNullOrEmpty
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

		/// <summary>The provided identity of type '{0}' is marked {1} = {2} but does not have a value for {3}. By default, the antiforgery system requires that all authenticated identities have a unique {3}. If it is not possible to provide a unique {3} for this identity, con ...</summary>
		internal static string FormatAntiforgeryTokenValidator_AuthenticatedUserWithoutUsername(object p0, object p1, object p2, object p3, object p4, object p5)
		{
			throw null;
		}

		/// <summary>The provided antiforgery token was meant for user "{0}", but the current user is "{1}".</summary>
		internal static string FormatAntiforgeryToken_UsernameMismatch(object p0, object p1)
		{
			throw null;
		}

		/// <summary>The required antiforgery cookie "{0}" is not present.</summary>
		internal static string FormatAntiforgery_CookieToken_MustBeProvided(object p0)
		{
			throw null;
		}

		/// <summary>The required antiforgery form field "{0}" is not present.</summary>
		internal static string FormatAntiforgery_FormToken_MustBeProvided(object p0)
		{
			throw null;
		}

		/// <summary>The required antiforgery header value "{0}" is not present.</summary>
		internal static string FormatAntiforgery_HeaderToken_MustBeProvided(object p0)
		{
			throw null;
		}

		/// <summary>The required antiforgery request token was not provided in either form field "{0}" or header value "{1}".</summary>
		internal static string FormatAntiforgery_RequestToken_MustBeProvided(object p0, object p1)
		{
			throw null;
		}

		/// <summary>The antiforgery system has the configuration value {optionName} = {value}, but the current request is not an SSL request.</summary>
		internal static string FormatAntiforgery_RequiresSSL(object optionName, object value)
		{
			throw null;
		}
	}
}
