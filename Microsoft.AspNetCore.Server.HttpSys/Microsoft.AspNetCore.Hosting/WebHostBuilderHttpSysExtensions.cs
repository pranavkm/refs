using Microsoft.AspNetCore.Server.HttpSys;
using System;

namespace Microsoft.AspNetCore.Hosting
{
	/// <summary>
	/// Provides extensions method to use Http.sys as the server for the web host.
	/// </summary>    
	public static class WebHostBuilderHttpSysExtensions
	{
		/// <summary>
		/// Specify Http.sys as the server to be used by the web host.
		/// </summary>
		/// <param name="hostBuilder">
		/// The Microsoft.AspNetCore.Hosting.IWebHostBuilder to configure.
		/// </param>
		/// <returns>
		/// A reference to the <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" /> parameter object.
		/// </returns>
		public static IWebHostBuilder UseHttpSys(this IWebHostBuilder hostBuilder)
		{
			throw null;
		}

		/// <summary>
		/// Specify Http.sys as the server to be used by the web host.
		/// </summary>
		/// <param name="hostBuilder">
		/// The Microsoft.AspNetCore.Hosting.IWebHostBuilder to configure.
		/// </param>
		/// <param name="options">
		/// A callback to configure Http.sys options.
		/// </param>
		/// <returns>
		/// A reference to the <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" /> parameter object.
		/// </returns>
		public static IWebHostBuilder UseHttpSys(this IWebHostBuilder hostBuilder, Action<HttpSysOptions> options)
		{
			throw null;
		}
	}
}
