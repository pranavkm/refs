using Microsoft.Extensions.FileProviders;
using System;

namespace Microsoft.Extensions.Hosting
{
	/// <summary>
	/// Provides information about the hosting environment an application is running in.
	/// <para>
	///  This type is obsolete and will be removed in a future version.
	///  The recommended alternative is Microsoft.Extensions.Hosting.IHostEnvironment.
	/// </para>
	/// </summary>
	[Obsolete("This type is obsolete and will be removed in a future version. The recommended alternative is Microsoft.Extensions.Hosting.IHostEnvironment.", false)]
	public interface IHostingEnvironment
	{
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
		/// Gets or sets an <see cref="T:Microsoft.Extensions.FileProviders.IFileProvider" /> pointing at <see cref="P:Microsoft.Extensions.Hosting.IHostingEnvironment.ContentRootPath" />.
		/// </summary>
		IFileProvider ContentRootFileProvider
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
		/// Gets or sets the name of the environment. The host automatically sets this property to the value of the
		/// of the "environment" key as specified in configuration.
		/// </summary>
		string EnvironmentName
		{
			get;
			set;
		}
	}
}
