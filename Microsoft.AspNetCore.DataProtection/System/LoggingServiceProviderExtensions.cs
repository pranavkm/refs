using Microsoft.Extensions.Logging;

namespace System
{
	/// <summary>
	/// Helpful logging-related extension methods on <see cref="T:System.IServiceProvider" />.
	/// </summary>
	internal static class LoggingServiceProviderExtensions
	{
		/// <summary>
		/// Retrieves an instance of <see cref="T:Microsoft.Extensions.Logging.ILogger" /> given the type name <typeparamref name="T" />.
		/// This is equivalent to <see cref="M:Microsoft.Extensions.Logging.LoggerFactoryExtensions.CreateLogger``1(Microsoft.Extensions.Logging.ILoggerFactory)" />.
		/// </summary>
		/// <returns>
		/// An <see cref="T:Microsoft.Extensions.Logging.ILogger" /> instance, or null if <paramref name="services" /> is null or the
		/// <see cref="T:System.IServiceProvider" /> cannot produce an <see cref="T:Microsoft.Extensions.Logging.ILoggerFactory" />.
		/// </returns>
		public static ILogger GetLogger<T>(this IServiceProvider services)
		{
			throw null;
		}

		/// <summary>
		/// Retrieves an instance of <see cref="T:Microsoft.Extensions.Logging.ILogger" /> given the type name <paramref name="type" />.
		/// This is equivalent to <see cref="M:Microsoft.Extensions.Logging.LoggerFactoryExtensions.CreateLogger``1(Microsoft.Extensions.Logging.ILoggerFactory)" />.
		/// </summary>
		/// <returns>
		/// An <see cref="T:Microsoft.Extensions.Logging.ILogger" /> instance, or null if <paramref name="services" /> is null or the
		/// <see cref="T:System.IServiceProvider" /> cannot produce an <see cref="T:Microsoft.Extensions.Logging.ILoggerFactory" />.
		/// </returns>
		public static ILogger GetLogger(this IServiceProvider services, Type type)
		{
			throw null;
		}
	}
}
