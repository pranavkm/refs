using Microsoft.AspNetCore.Server.Kestrel.Transport.Sockets;
using System;

namespace Microsoft.AspNetCore.Hosting
{
	/// <summary>
	/// <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" /> extension methods to configure the Socket transport to be used by Kestrel.
	/// </summary>
	public static class WebHostBuilderSocketExtensions
	{
		/// <summary>
		/// Specify Sockets as the transport to be used by Kestrel.
		/// </summary>
		/// <param name="hostBuilder">
		/// The Microsoft.AspNetCore.Hosting.IWebHostBuilder to configure.
		/// </param>
		/// <returns>
		/// The Microsoft.AspNetCore.Hosting.IWebHostBuilder.
		/// </returns>
		public static IWebHostBuilder UseSockets(this IWebHostBuilder hostBuilder)
		{
			throw null;
		}

		/// <summary>
		/// Specify Sockets as the transport to be used by Kestrel.
		/// </summary>
		/// <param name="hostBuilder">
		/// The Microsoft.AspNetCore.Hosting.IWebHostBuilder to configure.
		/// </param>
		/// <param name="configureOptions">
		/// A callback to configure Libuv options.
		/// </param>
		/// <returns>
		/// The Microsoft.AspNetCore.Hosting.IWebHostBuilder.
		/// </returns>
		public static IWebHostBuilder UseSockets(this IWebHostBuilder hostBuilder, Action<SocketTransportOptions> configureOptions)
		{
			throw null;
		}
	}
}
