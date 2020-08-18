namespace Microsoft.Extensions.Hosting
{
	/// <summary>
	/// Constants for HostBuilder configuration keys.
	/// </summary>
	public static class HostDefaults
	{
		/// <summary>
		/// The configuration key used to set <see cref="P:Microsoft.Extensions.Hosting.IHostEnvironment.ApplicationName" />.
		/// </summary>
		public static readonly string ApplicationKey;

		/// <summary>
		/// The configuration key used to set <see cref="P:Microsoft.Extensions.Hosting.IHostEnvironment.ContentRootPath" />
		/// and <see cref="P:Microsoft.Extensions.Hosting.IHostEnvironment.ContentRootFileProvider" />.
		/// </summary>
		public static readonly string ContentRootKey;

		/// <summary>
		/// The configuration key used to set <see cref="P:Microsoft.Extensions.Hosting.IHostEnvironment.EnvironmentName" />.
		/// </summary>
		public static readonly string EnvironmentKey;
	}
}
