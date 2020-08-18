namespace Microsoft.AspNetCore.Hosting
{
	/// <summary>
	/// Represents platform specific configuration that will be applied to a <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" /> when building an <see cref="T:Microsoft.AspNetCore.Hosting.IWebHost" />.
	/// </summary>
	public interface IHostingStartup
	{
		/// <summary>
		/// Configure the <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" />.
		/// </summary>
		/// <remarks>
		/// Configure is intended to be called before user code, allowing a user to overwrite any changes made.
		/// </remarks>
		/// <param name="builder"></param>
		void Configure(IWebHostBuilder builder);
	}
}
