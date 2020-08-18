using System;

namespace Microsoft.Extensions.Hosting
{
	/// <summary>
	/// Commonly used environment names.
	/// <para>
	///  This type is obsolete and will be removed in a future version.
	///  The recommended alternative is Microsoft.Extensions.Hosting.Environments.
	/// </para>
	/// </summary>
	[Obsolete("This type is obsolete and will be removed in a future version. The recommended alternative is Microsoft.Extensions.Hosting.Environments.", false)]
	public static class EnvironmentName
	{
		public static readonly string Development;

		public static readonly string Production;

		public static readonly string Staging;
	}
}
