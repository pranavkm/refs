using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using System;

namespace Microsoft.AspNetCore.StaticFiles
{
	/// <summary>
	/// Defines *all* the logger messages produced by static files
	/// </summary>
	internal static class LoggerExtensions
	{
		public static void RequestMethodNotSupported(this ILogger logger, string method)
		{
			throw null;
		}

		public static void FileServed(this ILogger logger, string virtualPath, string physicalPath)
		{
			throw null;
		}

		public static void EndpointMatched(this ILogger logger)
		{
			throw null;
		}

		public static void PathMismatch(this ILogger logger, string path)
		{
			throw null;
		}

		public static void FileTypeNotSupported(this ILogger logger, string path)
		{
			throw null;
		}

		public static void FileNotFound(this ILogger logger, string path)
		{
			throw null;
		}

		public static void FileNotModified(this ILogger logger, string path)
		{
			throw null;
		}

		public static void PreconditionFailed(this ILogger logger, string path)
		{
			throw null;
		}

		public static void Handled(this ILogger logger, int statusCode, string path)
		{
			throw null;
		}

		public static void RangeNotSatisfiable(this ILogger logger, string path)
		{
			throw null;
		}

		public static void SendingFileRange(this ILogger logger, StringValues range, string path)
		{
			throw null;
		}

		public static void CopyingFileRange(this ILogger logger, StringValues range, string path)
		{
			throw null;
		}

		public static void WriteCancelled(this ILogger logger, Exception ex)
		{
			throw null;
		}
	}
}
