using Microsoft.Extensions.FileProviders;
using System;

namespace Microsoft.AspNetCore.Hosting
{
	/// <summary>
	/// Provides information about the web hosting environment an application is running in.
	/// <para>
	///  This type is obsolete and will be removed in a future version.
	///  The recommended alternative is Microsoft.AspNetCore.Hosting.IWebHostEnvironment.
	/// </para>
	/// </summary>
	[Obsolete("This type is obsolete and will be removed in a future version. The recommended alternative is Microsoft.AspNetCore.Hosting.IWebHostEnvironment.", false)]
	public interface IHostingEnvironment
	{
		/// <summary>
		/// Gets or sets the name of the environment. The host automatically sets this property to the value
		/// of the "ASPNETCORE_ENVIRONMENT" environment variable, or "environment" as specified in any other configuration source.
		/// </summary>
		string EnvironmentName
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets the name of the application. This property is automatically set by the host to the assembly containing
		/// the application entry point.
		/// </summary>
		string ApplicationName
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets the absolute path to the directory that contains the web-servable application content files.
		/// </summary>
		string WebRootPath
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets an <see cref="T:Microsoft.Extensions.FileProviders.IFileProvider" /> pointing at <see cref="P:Microsoft.AspNetCore.Hosting.IHostingEnvironment.WebRootPath" />.
		/// </summary>
		IFileProvider WebRootFileProvider
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets the absolute path to the directory that contains the application content files.
		/// </summary>
		string ContentRootPath
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets an <see cref="T:Microsoft.Extensions.FileProviders.IFileProvider" /> pointing at <see cref="P:Microsoft.AspNetCore.Hosting.IHostingEnvironment.ContentRootPath" />.
		/// </summary>
		IFileProvider ContentRootFileProvider
		{
			get;
			set;
		}
	}
}
