namespace Microsoft.AspNetCore.Hosting
{
	/// <summary>
	/// Extension methods for <see cref="T:Microsoft.AspNetCore.Hosting.IHostingEnvironment" />.
	/// </summary>
	public static class HostingEnvironmentExtensions
	{
		/// <summary>
		/// Checks if the current hosting environment name is <see cref="F:Microsoft.AspNetCore.Hosting.EnvironmentName.Development" />.
		/// </summary>
		/// <param name="hostingEnvironment">An instance of <see cref="T:Microsoft.AspNetCore.Hosting.IHostingEnvironment" />.</param>
		/// <returns>True if the environment name is <see cref="F:Microsoft.AspNetCore.Hosting.EnvironmentName.Development" />, otherwise false.</returns>
		public static bool IsDevelopment(this IHostingEnvironment hostingEnvironment)
		{
			throw null;
		}

		/// <summary>
		/// Checks if the current hosting environment name is <see cref="F:Microsoft.AspNetCore.Hosting.EnvironmentName.Staging" />.
		/// </summary>
		/// <param name="hostingEnvironment">An instance of <see cref="T:Microsoft.AspNetCore.Hosting.IHostingEnvironment" />.</param>
		/// <returns>True if the environment name is <see cref="F:Microsoft.AspNetCore.Hosting.EnvironmentName.Staging" />, otherwise false.</returns>
		public static bool IsStaging(this IHostingEnvironment hostingEnvironment)
		{
			throw null;
		}

		/// <summary>
		/// Checks if the current hosting environment name is <see cref="F:Microsoft.AspNetCore.Hosting.EnvironmentName.Production" />.
		/// </summary>
		/// <param name="hostingEnvironment">An instance of <see cref="T:Microsoft.AspNetCore.Hosting.IHostingEnvironment" />.</param>
		/// <returns>True if the environment name is <see cref="F:Microsoft.AspNetCore.Hosting.EnvironmentName.Production" />, otherwise false.</returns>
		public static bool IsProduction(this IHostingEnvironment hostingEnvironment)
		{
			throw null;
		}

		/// <summary>
		/// Compares the current hosting environment name against the specified value.
		/// </summary>
		/// <param name="hostingEnvironment">An instance of <see cref="T:Microsoft.AspNetCore.Hosting.IHostingEnvironment" />.</param>
		/// <param name="environmentName">Environment name to validate against.</param>
		/// <returns>True if the specified name is the same as the current environment, otherwise false.</returns>
		public static bool IsEnvironment(this IHostingEnvironment hostingEnvironment, string environmentName)
		{
			throw null;
		}
	}
}
