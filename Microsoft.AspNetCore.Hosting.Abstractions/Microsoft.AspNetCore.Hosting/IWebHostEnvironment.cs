using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;

namespace Microsoft.AspNetCore.Hosting
{
	/// <summary>
	/// Provides information about the web hosting environment an application is running in.
	/// </summary>
	public interface IWebHostEnvironment : IHostEnvironment
	{
		/// <summary>
		/// Gets or sets the absolute path to the directory that contains the web-servable application content files.
		/// </summary>
		string WebRootPath
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets an <see cref="T:Microsoft.Extensions.FileProviders.IFileProvider" /> pointing at <see cref="P:Microsoft.AspNetCore.Hosting.IWebHostEnvironment.WebRootPath" />.
		/// </summary>
		IFileProvider WebRootFileProvider
		{
			get;
			set;
		}
	}
}
