using System;

namespace Microsoft.Extensions.Hosting
{
	/// <summary>
	/// Options for <see cref="T:Microsoft.Extensions.Hosting.IHost" />
	/// </summary>
	public class HostOptions
	{
		/// <summary>
		/// The default timeout for <see cref="M:Microsoft.Extensions.Hosting.IHost.StopAsync(System.Threading.CancellationToken)" />.
		/// </summary>
		public TimeSpan ShutdownTimeout
		{
			get
			{
				throw null;
			}
			set
			{
			}
		}
	}
}
