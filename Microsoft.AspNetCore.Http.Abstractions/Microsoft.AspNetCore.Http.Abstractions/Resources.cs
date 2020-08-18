using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Http.Abstractions
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

		/// <summary>'{0}' is not available.</summary>
		internal static string Exception_UseMiddlewareIServiceProviderNotAvailable
		{
			get
			{
				throw null;
			}
		}

		/// <summary>No public '{0}' or '{1}' method found for middleware of type '{2}'.</summary>
		internal static string Exception_UseMiddlewareNoInvokeMethod
		{
			get
			{
				throw null;
			}
		}

		/// <summary>'{0}' or '{1}' does not return an object of type '{2}'.</summary>
		internal static string Exception_UseMiddlewareNonTaskReturnType
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The '{0}' or '{1}' method's first argument must be of type '{2}'.</summary>
		internal static string Exception_UseMiddlewareNoParameters
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Multiple public '{0}' or '{1}' methods are available.</summary>
		internal static string Exception_UseMiddleMutlipleInvokes
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The path in '{0}' must start with '/'.</summary>
		internal static string Exception_PathMustStartWithSlash
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Unable to resolve service for type '{0}' while attempting to Invoke middleware '{1}'.</summary>
		internal static string Exception_InvokeMiddlewareNoService
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The '{0}' method must not have ref or out parameters.</summary>
		internal static string Exception_InvokeDoesNotSupportRefOrOutParams
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The value must be greater than zero.</summary>
		internal static string Exception_PortMustBeGreaterThanZero
		{
			get
			{
				throw null;
			}
		}

		/// <summary>No service for type '{0}' has been registered.</summary>
		internal static string Exception_UseMiddlewareNoMiddlewareFactory
		{
			get
			{
				throw null;
			}
		}

		/// <summary>'{0}' failed to create middleware of type '{1}'.</summary>
		internal static string Exception_UseMiddlewareUnableToCreateMiddleware
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Types that implement '{0}' do not support explicit arguments.</summary>
		internal static string Exception_UseMiddlewareExplicitArgumentsNotSupported
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Argument cannot be null or empty.</summary>
		internal static string ArgumentCannotBeNullOrEmpty
		{
			get
			{
				throw null;
			}
		}

		/// <summary>An element with the key '{0}' already exists in the {1}.</summary>
		internal static string RouteValueDictionary_DuplicateKey
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The type '{0}' defines properties '{1}' and '{2}' which differ only by casing. This is not supported by {3} which uses case-insensitive comparisons.</summary>
		internal static string RouteValueDictionary_DuplicatePropertyName
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

		/// <summary>'{0}' is not available.</summary>
		internal static string FormatException_UseMiddlewareIServiceProviderNotAvailable(object p0)
		{
			throw null;
		}

		/// <summary>No public '{0}' or '{1}' method found for middleware of type '{2}'.</summary>
		internal static string FormatException_UseMiddlewareNoInvokeMethod(object p0, object p1, object p2)
		{
			throw null;
		}

		/// <summary>'{0}' or '{1}' does not return an object of type '{2}'.</summary>
		internal static string FormatException_UseMiddlewareNonTaskReturnType(object p0, object p1, object p2)
		{
			throw null;
		}

		/// <summary>The '{0}' or '{1}' method's first argument must be of type '{2}'.</summary>
		internal static string FormatException_UseMiddlewareNoParameters(object p0, object p1, object p2)
		{
			throw null;
		}

		/// <summary>Multiple public '{0}' or '{1}' methods are available.</summary>
		internal static string FormatException_UseMiddleMutlipleInvokes(object p0, object p1)
		{
			throw null;
		}

		/// <summary>The path in '{0}' must start with '/'.</summary>
		internal static string FormatException_PathMustStartWithSlash(object p0)
		{
			throw null;
		}

		/// <summary>Unable to resolve service for type '{0}' while attempting to Invoke middleware '{1}'.</summary>
		internal static string FormatException_InvokeMiddlewareNoService(object p0, object p1)
		{
			throw null;
		}

		/// <summary>The '{0}' method must not have ref or out parameters.</summary>
		internal static string FormatException_InvokeDoesNotSupportRefOrOutParams(object p0)
		{
			throw null;
		}

		/// <summary>No service for type '{0}' has been registered.</summary>
		internal static string FormatException_UseMiddlewareNoMiddlewareFactory(object p0)
		{
			throw null;
		}

		/// <summary>'{0}' failed to create middleware of type '{1}'.</summary>
		internal static string FormatException_UseMiddlewareUnableToCreateMiddleware(object p0, object p1)
		{
			throw null;
		}

		/// <summary>Types that implement '{0}' do not support explicit arguments.</summary>
		internal static string FormatException_UseMiddlewareExplicitArgumentsNotSupported(object p0)
		{
			throw null;
		}

		/// <summary>An element with the key '{0}' already exists in the {1}.</summary>
		internal static string FormatRouteValueDictionary_DuplicateKey(object p0, object p1)
		{
			throw null;
		}

		/// <summary>The type '{0}' defines properties '{1}' and '{2}' which differ only by casing. This is not supported by {3} which uses case-insensitive comparisons.</summary>
		internal static string FormatRouteValueDictionary_DuplicatePropertyName(object p0, object p1, object p2, object p3)
		{
			throw null;
		}
	}
}
