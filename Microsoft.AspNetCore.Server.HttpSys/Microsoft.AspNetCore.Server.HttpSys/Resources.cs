using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Server.HttpSys
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

		/// <summary>The prefix '{0}' is not registered. Please run the following command as Administrator to register this prefix:
		/// netsh http add urlacl url={0} user={1}
		/// See "Preregister URL prefixes on the server" on https://go.microsoft.com/fwlink/?linkid=2127065 for more i ...</summary>
		internal static string Exception_AccessDenied
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The destination array is too small.</summary>
		internal static string Exception_ArrayTooSmall
		{
			get
			{
				throw null;
			}
		}

		/// <summary>End has already been called.</summary>
		internal static string Exception_EndCalledMultipleTimes
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The status code '{0}' is not supported.</summary>
		internal static string Exception_InvalidStatusCode
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The stream is not seekable.</summary>
		internal static string Exception_NoSeek
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The prefix '{0}' is already registered.</summary>
		internal static string Exception_PrefixAlreadyRegistered
		{
			get
			{
				throw null;
			}
		}

		/// <summary>This stream only supports read operations.</summary>
		internal static string Exception_ReadOnlyStream
		{
			get
			{
				throw null;
			}
		}

		/// <summary>More data written than specified in the Content-Length header.</summary>
		internal static string Exception_TooMuchWritten
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Only the http and https schemes are supported.</summary>
		internal static string Exception_UnsupportedScheme
		{
			get
			{
				throw null;
			}
		}

		/// <summary>This stream only supports write operations.</summary>
		internal static string Exception_WriteOnlyStream
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The given IAsyncResult does not match this opperation.</summary>
		internal static string Exception_WrongIAsyncResult
		{
			get
			{
				throw null;
			}
		}

		/// <summary>An exception occurred while running an action registered with {0}.</summary>
		internal static string Warning_ExceptionInOnResponseCompletedAction
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

		/// <summary>The prefix '{0}' is not registered. Please run the following command as Administrator to register this prefix:
		/// netsh http add urlacl url={0} user={1}
		/// See "Preregister URL prefixes on the server" on https://go.microsoft.com/fwlink/?linkid=2127065 for more i ...</summary>
		internal static string FormatException_AccessDenied(object p0, object p1)
		{
			throw null;
		}

		/// <summary>The status code '{0}' is not supported.</summary>
		internal static string FormatException_InvalidStatusCode(object p0)
		{
			throw null;
		}

		/// <summary>The prefix '{0}' is already registered.</summary>
		internal static string FormatException_PrefixAlreadyRegistered(object p0)
		{
			throw null;
		}

		/// <summary>An exception occurred while running an action registered with {0}.</summary>
		internal static string FormatWarning_ExceptionInOnResponseCompletedAction(object p0)
		{
			throw null;
		}
	}
}
