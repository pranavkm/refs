namespace Microsoft.Extensions.Hosting
{
	/// <summary>
	/// Extension methods for <see cref="T:Microsoft.Extensions.Hosting.IHostEnvironment" />.
	/// </summary>
	public static class HostEnvironmentEnvExtensions
	{
		/// <summary>
		/// Checks if the current host environment name is <see cref="F:Microsoft.Extensions.Hosting.EnvironmentName.Development" />.
		/// </summary>
		/// <param name="hostEnvironment">An instance of <see cref="T:Microsoft.Extensions.Hosting.IHostEnvironment" />.</param>
		/// <returns>True if the environment name is <see cref="F:Microsoft.Extensions.Hosting.EnvironmentName.Development" />, otherwise false.</returns>
		public static bool IsDevelopment(this IHostEnvironment hostEnvironment)
		{
			throw null;
		}

		/// <summary>
		/// Compares the current host environment name against the specified value.
		/// </summary>
		/// <param name="hostEnvironment">An instance of <see cref="T:Microsoft.Extensions.Hosting.IHostEnvironment" />.</param>
		/// <param name="environmentName">Environment name to validate against.</param>
		/// <returns>True if the specified name is the same as the current environment, otherwise false.</returns>
		public static bool IsEnvironment(this IHostEnvironment hostEnvironment, string environmentName)
		{
			throw null;
		}

		/// <summary>
		/// Checks if the current host environment name is <see cref="F:Microsoft.Extensions.Hosting.EnvironmentName.Production" />.
		/// </summary>
		/// <param name="hostEnvironment">An instance of <see cref="T:Microsoft.Extensions.Hosting.IHostEnvironment" />.</param>
		/// <returns>True if the environment name is <see cref="F:Microsoft.Extensions.Hosting.EnvironmentName.Production" />, otherwise false.</returns>
		public static bool IsProduction(this IHostEnvironment hostEnvironment)
		{
			throw null;
		}

		/// <summary>
		/// Checks if the current host environment name is <see cref="F:Microsoft.Extensions.Hosting.EnvironmentName.Staging" />.
		/// </summary>
		/// <param name="hostEnvironment">An instance of <see cref="T:Microsoft.Extensions.Hosting.IHostEnvironment" />.</param>
		/// <returns>True if the environment name is <see cref="F:Microsoft.Extensions.Hosting.EnvironmentName.Staging" />, otherwise false.</returns>
		public static bool IsStaging(this IHostEnvironment hostEnvironment)
		{
			throw null;
		}
	}
}
