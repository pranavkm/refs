using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Server.IIS
{
	internal static class CoreStrings
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

		/// <summary>Cannot write to response body after connection has been upgraded.</summary>
		internal static string ResponseStreamWasUpgraded
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The response has been aborted due to an unhandled application exception.</summary>
		internal static string UnhandledApplicationException
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Cannot upgrade a non-upgradable request. Check IHttpUpgradeFeature.IsUpgradableRequest to determine if a request can be upgraded.</summary>
		internal static string CannotUpgradeNonUpgradableRequest
		{
			get
			{
				throw null;
			}
		}

		/// <summary>IHttpUpgradeFeature.UpgradeAsync was already called and can only be called once per connection.</summary>
		internal static string UpgradeCannotBeCalledMultipleTimes
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Synchronous operations are disallowed. Call ReadAsync or set AllowSynchronousIO to true instead.</summary>
		internal static string SynchronousReadsDisallowed
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Synchronous operations are disallowed. Call WriteAsync or set AllowSynchronousIO to true instead.</summary>
		internal static string SynchronousWritesDisallowed
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Cannot write to the response body, the response has completed.</summary>
		internal static string WritingToResponseBodyAfterResponseCompleted
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The connection was aborted by the application.</summary>
		internal static string ConnectionAbortedByApplication
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The connection or stream was aborted because a write operation was aborted with a CancellationToken.</summary>
		internal static string ConnectionOrStreamAbortedByCancellationToken
		{
			get
			{
				throw null;
			}
		}

		/// <summary>{name} cannot be set because the response has already started.</summary>
		internal static string ParameterReadOnlyAfterResponseStarted
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Request body too large.</summary>
		internal static string BadRequest_RequestBodyTooLarge
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The maximum request body size cannot be modified after the app has already started reading from the request body.</summary>
		internal static string MaxRequestBodySizeCannotBeModifiedAfterRead
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The maximum request body size cannot be modified after the request has been upgraded.</summary>
		internal static string MaxRequestBodySizeCannotBeModifiedForUpgradedRequests
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Value must be null or a non-negative number.</summary>
		internal static string NonNegativeNumberOrNullRequired
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Bad request.</summary>
		internal static string BadRequest
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Increasing the MaxRequestBodySize conflicts with the max value for IIS limit maxAllowedContentLength. HTTP requests that have a content length greater than maxAllowedContentLength will still be rejected by IIS. You can disable the limit by either removing  ...</summary>
		internal static string MaxRequestLimitWarning
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

		/// <summary>{name} cannot be set because the response has already started.</summary>
		internal static string FormatParameterReadOnlyAfterResponseStarted(object name)
		{
			throw null;
		}
	}
}
